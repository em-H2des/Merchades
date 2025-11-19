

CREATE TABLE PRODUTOS (
	ID_PRODUTOS int identity primary key, -- Identificação da tabela
	NOME_PRODUTOS varchar (70), -- Nome do Produto
	TIPO_PRODUTOS varchar (30),  -- Exemplo: Higiene, Alimento, Limpeza...
	TIPO_UNITARIO varchar (30),  -- Exemplo: Grama, , Kilograma, Litro, Mililitro, Fardo...
	PRECO_PRODUTOS money, -- Gerenciar o dinheiro do mercado e atribuir valor aos produtos 
	CODIGO_DE_BARRAS int, -- Identificação do produto nas notas fiscais e no sistema
	QTD_ESTOQUE int -- Saber quanto que tem do produto em específico no estoque
);
 
CREATE TABLE FORNECEDOR (
	ID_FORNECEDOR int identity primary key, -- Identificação da tabela e separação de cada fornecedor através do ID
	NOME_FORNECEDOR varchar (50), -- Identificação do fornecedor por nome
	TELEFONE_FORNECEDOR varchar (15), -- Contato via telefone
	EMAIL_FORNECEDOR varchar (180), -- Contato via correio eletrônico
	ESTADO_FORNECEDOR char (2), -- Estado em que o fornecedor está localizado. Detalhe está em char pois só iremos usar 2 letras para as siglas dos estados exemplo: (RJ, MG, SP, BH...)
	CEP_FORNECEDOR varchar (8), -- Bairro em que o fornecedor se localiza
	CNPJ_FORNECEDOR varchar (14) -- Documento da empresa
);

CREATE TABLE NOTA_FISCAL_FORNECEDOR (
    ID_NOTA_FISCAL_FORNEC int identity primary key,
    DATA_EMISSAO date, -- Data que será emitida na compra com o fornecedor
    VALOR_COMPRA money, -- Quanto foi gasto com o fornecedor
    COD_NOTA_FORN varchar (50), -- Código da nota fiscal do fornecedor, para dividir e saber qual nota é
    OBSERVACAO varchar (150), -- Alguma especificação
	PAGO char(1),
    ID_FORNECEDOR int foreign key references FORNECEDOR (ID_FORNECEDOR) -- Identificação do fornecedor via id
);

CREATE TABLE ESTOQUE ( 	
	ID_ESTOQUE int identity primary key, 		 	
	QTD_ESTOQUE_ADDED int, -- quantidade adicionada no estoque
	ID_PRODUTOS int foreign key references PRODUTOS (ID_PRODUTOS), 	
	ID_NOTA_FISCAL_FORNEC int foreign key references NOTA_FISCAL_FORNECEDOR (ID_NOTA_FISCAL_FORNEC)
);

-- Saída --

CREATE TABLE LOGIN_USUARIO (
	ID_USUARIO int identity (1,1) primary key, -- Id gerado altomaticamente para cada usuário e senha cadastrado
	NOME_CADASTRADO varchar (100) NOT NULL, -- Nome do usuário
	USUARIO varchar (70) NOT NULL UNIQUE, -- Nome que o usuário cadastrar para acessar a plataforma
	SENHA_USUARIO varchar (255) NOT NULL, -- Senha que o usuário definir para acessar a plataforma
	NIVEL_USUARIO int NOT NULL, -- Nivel que for definido para o usuário como "1 = funcionario, 2 = gerente"
);

CREATE TABLE CLIENTE (
	ID_CLIENTE int identity primary key, -- Identificação da tabela e separação de cada cliente através do IDD
	CPF_CNPJ_CLIENTE varchar (14), -- Documento do cliente (CPF ou CNPJ)
);

CREATE TABLE METODO_PAGAMENTO (
    ID_METODO_PAGAMENTO int identity primary key,
    DESCRICAO varchar (255) -- Descrição do metodo de pagamento 
);

CREATE TABLE NOTA_FISCAL_VENDA (
	ID_NOTA_VENDA int identity primary key, -- Detalhamento do pedido 
	DATA_EMISSAO date, -- Data de emissão da nota fiscal
	VALOR_VENDA money,
	COD_NOTA_VENDA int,
	QTD_PARCELAS int,
    CPF_CNPJ_VENDA varchar (14),
	OBSERVACAO varchar (150),
	STATUS_VENDA char (1) CHECK (STATUS_VENDA IN ('F', 'A')),
	ID_METODO_PAGAMENTO int foreign key references METODO_PAGAMENTO (ID_METODO_PAGAMENTO), -- Forma de pagamento para incluir na nota fiscal
);

CREATE TABLE ITENS_NOTA_VENDA (
    ID_ITENS_NOTA_VENDA int identity primary key,
	QTD_PRODUTO int, -- Saber a quantidade do produto em uma venda
    ID_PRODUTOS int foreign key references PRODUTOS (ID_PRODUTOS),
	ID_NOTA_VENDA int foreign key references NOTA_FISCAL_VENDA (ID_NOTA_VENDA)
);

CREATE TABLE ITENS_NOTA_FORNECEDOR (
    ID_ITENS_NOTA_FORNEC int identity primary key,
    QTD_UNIT_PAC int,
    NUM_LOTE int, -- Identificação do lote
    OBSERVACAO varchar(80), -- Alguma especificação
    ID_PRODUTOS int foreign key references PRODUTOS (ID_PRODUTOS),
    ID_NOTA_FISCAL_FORNEC int foreign key references NOTA_FISCAL_FORNECEDOR (ID_NOTA_FISCAL_FORNEC)
);

CREATE TABLE RELATORIO_FINANCEIRO ( -- mostra os gastos e ganhos individualmente, tem uma procedure pra ver por período
    ID_RELATORIO_FINANCEIRO int identity primary key,
	OBSERVACAO varchar (255), -- Motivo da compra
	VALOR money, -- mostra o valor de gasto/ganho (despesa = negativo, ganho = positivo)
	DATA_EMISSAO date, -- Saber a data que foi feita a emissão
    TIPO CHAR(1) CHECK (TIPO IN ('G', 'D')) -- G = ganho, D = despesa
);

CREATE TABLE PARCELAS (
    ID_PARCELAS int identity primary key,
    VALOR_TOTAL money, -- Valor total de todas as parcelas
    QTD_PARCELAS int, -- Quantidade total da venda de parcelas
    STATUS_GERAL varchar (50), -- Se esta paga ou vencida
    ID_CLIENTE int foreign key references CLIENTE (ID_CLIENTE),
    ID_NOTA_VENDA int foreign key references NOTA_FISCAL_VENDA (ID_NOTA_VENDA)
);

CREATE TABLE DEBITO_PARCELAS (
    ID_DEBITO_PARCELA int identity primary key,
    NUM_PARCELA int, -- Quantidade de parcelas
    VALOR_PARCELA money,-- Valor de cada parcela individual
    DATA_VENCIMENTO date, -- Data de vencimento das parcelas
    STATUS varchar (50), -- Se está paga ou vencida
    DATA_PAGAMENTO date, -- Quando foi efetuado o pagamento
    OBSERVACAO varchar, -- Alguma especificação
    ID_PARCELAS int foreign key references PARCELAS (ID_PARCELAS) -- Identificação das parcelas via id
);
 
CREATE TABLE FERIADOS (
    ID_FERIADO int identity primary key,
    DIA int NOT NULL,
    MES int NOT NULL,
    DESCRICAO varchar (100) NOT NULL
);
-- Triggers --


-- Entrada --

GO
CREATE TRIGGER TR_AI_AtualizaEstoque_Entrada
ON ITENS_NOTA_FORNECEDOR
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Variável de controle (boa prática para triggers)
    IF NOT EXISTS(SELECT * FROM inserted) RETURN;
    
    -- Atualização (Para produtos que JÁ EXISTEM no ESTOQUE)

    -- Soma a nova quantidade (QTD_UNIT_PAC) à QTD_ESTOQUE_ADDED existente.

    UPDATE P
    SET P.QTD_ESTOQUE = P.QTD_ESTOQUE + I.QTD_UNIT_PAC
    FROM PRODUTOS P
    INNER JOIN INSERTED I ON P.ID_PRODUTOS = I.ID_PRODUTOS;

    INSERT INTO ESTOQUE (
        QTD_ESTOQUE_ADDED,
        ID_PRODUTOS,
        ID_NOTA_FISCAL_FORNEC
    )
    SELECT 
        I.QTD_UNIT_PAC, -- QTD_ESTOQUE_ADDED é o valor da entrada
        I.ID_PRODUTOS, -- ID do produto
        I.ID_NOTA_FISCAL_FORNEC -- ID da nota de fornecedor
    FROM INSERTED I
    -- Não precisamos da NOTA_FISCAL_FORNECEDOR (NF) aqui, pois todos os campos necessários já estão em INSERTED (I)
    LEFT JOIN ESTOQUE E ON E.ID_PRODUTOS = I.ID_PRODUTOS
    
    -- Inserção (Para produtos que NÃO EXISTEM no ESTOQUE)
    
    -- Insere novos registros, preenchendo apenas as 3 colunas que existem.
    -- O LEFT JOIN + WHERE E.ID_PRODUTOS IS NULL encontra apenas os NOVOS.
END;

-- No caso de saida - quando produtos são vendidos, e altera o estoque do mercado, de novo usei a tabela estoque

GO
CREATE TRIGGER TR_AI_AtualizaEstoque_Saida -- CORRIGIR !!! QTD_ESTOQUE NO PRODUTO
ON ITENS_NOTA_VENDA
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Atualiza o estoque subtraindo a quantidade vendida
    UPDATE P
    SET P.QTD_ESTOQUE = P.QTD_ESTOQUE - I.QTD_PRODUTO
    FROM PRODUTOS P
    INNER JOIN INSERTED I ON P.ID_PRODUTOS = I.ID_PRODUTOS
    WHERE P.QTD_ESTOQUE >= I.QTD_PRODUTO; -- caso não tenha estoque é necessário indicar isso no sistema mesmo!! (com error ou aviso)
	-- não usar where, usar condição!
END;

-----

 GO

CREATE TRIGGER TR_AI_ITENS_NOTA_VENDA

ON ITENS_NOTA_VENDA

AFTER INSERT

AS

BEGIN

    SET NOCOUNT ON;

    PRINT 'TR_ITENS_NOTA_VENDA em execução!...';


    DECLARE 
        @ID_NOTA_VENDA INT,
        @STATUS_VENDA CHAR(1),
        @VALOR_TOTAL MONEY,
        @CPF_CNPJ VARCHAR(14);
    -- Calcula o valor total do(s) item(ns) inserido(s)
    SELECT 
        @VALOR_TOTAL = SUM(p.PRECO_PRODUTOS * i.QTD_PRODUTO)
    FROM INSERTED i
    INNER JOIN PRODUTOS p ON i.ID_PRODUTOS = p.ID_PRODUTOS;
    -- Pega o ID da nota mais recente
    SELECT TOP 1 @ID_NOTA_VENDA = ID_NOTA_VENDA
    FROM ITENS_NOTA_VENDA
    ORDER BY ID_ITENS_NOTA_VENDA DESC;
    -- Busca informações da nota
    SELECT 
        @STATUS_VENDA = NFV.STATUS_VENDA,
        @CPF_CNPJ = NFV.CPF_CNPJ_VENDA
    FROM NOTA_FISCAL_VENDA NFV
    WHERE NFV.ID_NOTA_VENDA = @ID_NOTA_VENDA;
    -- Se ainda não tiver cliente vinculado à nota
        IF NOT EXISTS (SELECT 1 FROM CLIENTE WHERE CPF_CNPJ_CLIENTE = @CPF_CNPJ)
            BEGIN
                INSERT INTO CLIENTE (CPF_CNPJ_CLIENTE)
                VALUES (@CPF_CNPJ);
                PRINT 'Cliente criado com CPF/CNPJ informado.';
            END
            ELSE
            BEGIN
                PRINT 'Cliente existente (verificado por CPF/CNPJ) vinculado à nota fiscal.';
        END
    -- Se a nota estiver fechada, interrompe
    IF @STATUS_VENDA = 'F'
    BEGIN
        PRINT 'Nota fiscal já encerrada. Nenhuma ação executada!';
        RETURN;
    END
    -- Se não houver nota aberta, cria nova
    IF @ID_NOTA_VENDA IS NULL
    BEGIN
        INSERT INTO NOTA_FISCAL_VENDA (
            DATA_EMISSAO,
            VALOR_VENDA,
            COD_NOTA_VENDA,
            STATUS_VENDA,
            OBSERVACAO
        ) VALUES (
            GETDATE(),
            @VALOR_TOTAL,
            ABS(CHECKSUM(NEWID())) % 100000,
            'A',
            'Nota fiscal gerada automaticamente pela trigger.'
        );
        SET @ID_NOTA_VENDA = SCOPE_IDENTITY();
        PRINT 'Nova nota fiscal criada automaticamente.';
    END
    ELSE
    BEGIN
        -- Atualiza o valor total da nota existente
        UPDATE NOTA_FISCAL_VENDA
        SET VALOR_VENDA = ISNULL(VALOR_VENDA, 0) + @VALOR_TOTAL
        WHERE ID_NOTA_VENDA = @ID_NOTA_VENDA;
    END
    -- Vincula o item inserido à nota correspondente
    UPDATE ITENS_NOTA_VENDA
    SET ID_NOTA_VENDA = @ID_NOTA_VENDA
    WHERE ID_ITENS_NOTA_VENDA IN (SELECT ID_ITENS_NOTA_VENDA FROM INSERTED);
    PRINT 'Nota fiscal atualizada e cliente vinculado com sucesso!';
END;
GO




-----

GO
CREATE TRIGGER TR_VERIFICA_FORNECEDOR_NOTA_FISCAL
ON NOTA_FISCAL_FORNECEDOR
INSTEAD OF INSERT
AS
BEGIN
    -- Verifica se existe algum registro na inserção que tenha um fornecedor inexistente
    IF EXISTS (
        SELECT 1
        FROM INSERTED i
        WHERE NOT EXISTS (
            SELECT 1
            FROM FORNECEDOR f
            WHERE f.ID_FORNECEDOR = i.ID_FORNECEDOR
        )
    )
    BEGIN
        -- Lança um erro se o fornecedor NÃO EXISTIR
        RAISERROR('Fornecedor não cadastrado. Por favor, cadastre o fornecedor antes de inserir a nota fiscal.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
    
    -- *** SE CHEGOU AQUI, O FORNECEDOR EXISTE. ENTÃO, FAZEMOS O INSERT ORIGINAL! ***
    INSERT INTO NOTA_FISCAL_FORNECEDOR (
        DATA_EMISSAO, VALOR_COMPRA, COD_NOTA_FORN, OBSERVACAO, ID_FORNECEDOR
    )
    SELECT
        DATA_EMISSAO, VALOR_COMPRA, COD_NOTA_FORN, OBSERVACAO, ID_FORNECEDOR
    FROM INSERTED;

END;
GO

-- Saída --

GO
CREATE TRIGGER TR_AI_CadastraCliente
ON NOTA_FISCAL_VENDA
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Insere na tabela CLIENTE
    INSERT INTO CLIENTE (CPF_CNPJ_CLIENTE)
    
    -- Seleciona APENAS os CPFs que ainda não existem
    SELECT DISTINCT 
        i.CPF_CNPJ_VENDA 
    FROM 
        INSERTED i -- Pega  as linhas que acabaram de ser inseridas
    LEFT JOIN 
        CLIENTE c ON i.CPF_CNPJ_VENDA = c.CPF_CNPJ_CLIENTE -- Tenta cruzar com clientes existentes
    WHERE c.CPF_CNPJ_CLIENTE IS NULL; -- A mágica: só insere se o cliente (c) NÃO foi encontrado
END;
GO

 GO

CREATE TRIGGER TR_AI_GerarParcelas

ON NOTA_FISCAL_VENDA

AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE 

        @ID_NOTA_VENDA INT,

        @ID_CLIENTE INT,

        @CPF_CNPJ_VENDA VARCHAR(14),

        @VALOR_VENDA MONEY,

        @QTD_PARCELAS INT,

        @DATA_EMISSAO DATE,

        @VALOR_UNIT MONEY,

        @ID_PARCELAS INT,

        @I INT,

        @DATA_VENC DATE;


    DECLARE cursorNotas CURSOR FOR

    SELECT ID_NOTA_VENDA, CPF_CNPJ_VENDA, VALOR_VENDA, QTD_PARCELAS, DATA_EMISSAO

    FROM inserted;


    OPEN cursorNotas;

    FETCH NEXT FROM cursorNotas INTO @ID_NOTA_VENDA, @CPF_CNPJ_VENDA, @VALOR_VENDA, @QTD_PARCELAS, @DATA_EMISSAO;


    WHILE @@FETCH_STATUS = 0

    BEGIN
	SELECT @ID_CLIENTE = ID_CLIENTE
        FROM CLIENTE
        WHERE CPF_CNPJ_CLIENTE = @CPF_CNPJ_VENDA;

        -- Validação mínima de parcelas

		IF @ID_CLIENTE IS NULL
        BEGIN
            INSERT INTO CLIENTE (CPF_CNPJ_CLIENTE)
            VALUES (@CPF_CNPJ_VENDA); -- Define um nome padrão temporário

            SET @ID_CLIENTE = SCOPE_IDENTITY(); -- Pega o ID que acabou de ser gerado
        END

        IF @QTD_PARCELAS <= 0 SET @QTD_PARCELAS = 1;


        -- Ajuste para valor mínimo por parcela (opcional)

		
        --WHILE (@VALOR_VENDA / @QTD_PARCELAS) < 15 AND @QTD_PARCELAS > 1

        --BEGIN

            --SET @QTD_PARCELAS = @QTD_PARCELAS - 1;

        --END;


        SET @VALOR_UNIT = ROUND(@VALOR_VENDA / @QTD_PARCELAS, 2);


        -- Registro principal de parcelamento

        INSERT INTO PARCELAS (VALOR_TOTAL, QTD_PARCELAS, STATUS_GERAL, ID_CLIENTE, ID_NOTA_VENDA)

        VALUES (@VALOR_VENDA, @QTD_PARCELAS, 'Pendente', @ID_CLIENTE, @ID_NOTA_VENDA);


        SET @ID_PARCELAS = SCOPE_IDENTITY();


        SET @I = 1;

        WHILE @I <= @QTD_PARCELAS

        BEGIN

            DECLARE @DATA_BASE DATE = DATEADD(MONTH, @I - 1, @DATA_EMISSAO);

            SET @DATA_VENC = dbo.FN_PROXIMO_DIA_UTIL(@DATA_BASE);


            -- Última parcela ajustada para compensar arredondamento

            DECLARE @VALOR_PARCELA MONEY = 

                CASE 

                    WHEN @I = @QTD_PARCELAS THEN @VALOR_VENDA - (@VALOR_UNIT * (@QTD_PARCELAS - 1))

                    ELSE @VALOR_UNIT

                END;


            INSERT INTO DEBITO_PARCELAS (

                ID_PARCELAS, NUM_PARCELA, VALOR_PARCELA, DATA_VENCIMENTO, STATUS

            )

            VALUES (

                @ID_PARCELAS, @I, @VALOR_PARCELA, @DATA_VENC, 'Pendente'

            );


            SET @I += 1;

        END;


        FETCH NEXT FROM cursorNotas INTO @ID_NOTA_VENDA, @CPF_CNPJ_VENDA, @VALOR_VENDA, @QTD_PARCELAS, @DATA_EMISSAO;

    END;


    CLOSE cursorNotas;

    DEALLOCATE cursorNotas;

END;

-- Views de relatório --
GO
CREATE VIEW
Vw_RELATORIO_FINANCEIRO_DESPESAS 
AS SELECT * FROM RELATORIO_FINANCEIRO 
WHERE TIPO = 'D';

GO
CREATE VIEW
Vw_RELATORIO_FINANCEIRO_GANHOS 
AS SELECT * FROM RELATORIO_FINANCEIRO 
WHERE TIPO = 'G';


-- triggers de relatório --

GO
CREATE TRIGGER TR_AI_Relatorio_Venda
ON NOTA_FISCAL_VENDA
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO RELATORIO_FINANCEIRO (OBSERVACAO, VALOR, DATA_EMISSAO, TIPO)
    SELECT 
        CONCAT('Venda registrada - Nota ', i.COD_NOTA_VENDA),
        i.VALOR_VENDA,  -- positivo = ganho
        i.DATA_EMISSAO,
        'G'
    FROM INSERTED i
    WHERE i.STATUS_VENDA = 'F';

    PRINT 'Relatório financeiro atualizado com ganho de venda.';
END;
GO

CREATE TRIGGER TR_AI_Relatorio_Fornecedor
ON NOTA_FISCAL_FORNECEDOR
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO RELATORIO_FINANCEIRO (OBSERVACAO, VALOR, DATA_EMISSAO, TIPO)
    SELECT 
        CONCAT('Compra de fornecedor - Nota ', i.COD_NOTA_FORN),
        -ABS(i.VALOR_COMPRA),  -- negativo = gasto
        i.DATA_EMISSAO,
        'D'
    FROM INSERTED i;

    PRINT 'Relatório financeiro atualizado com gasto de fornecedor.';
END;
GO


-- Procedures --

-- de relatorio financeiro --

CREATE PROCEDURE PR_GerarRelatorioFinanceiro
    @DataInicio DATE,
    @DataFim DATE
AS
BEGIN
    SET NOCOUNT ON;

    IF @DataInicio IS NULL OR @DataFim IS NULL OR @DataInicio > @DataFim
    BEGIN
        RAISERROR('Período inválido. Verifique as datas informadas.', 16, 1);
        RETURN;
    END;

    PRINT 'Gerando relatório financeiro...';

    SELECT 
        ID_RELATORIO_FINANCEIRO,
        OBSERVACAO,
        VALOR,
        DATA_EMISSAO
    FROM RELATORIO_FINANCEIRO
    WHERE DATA_EMISSAO BETWEEN @DataInicio AND @DataFim
    ORDER BY DATA_EMISSAO;

    DECLARE 
        @TotalGanhos MONEY,
        @TotalDespesas MONEY,
        @SaldoFinal MONEY;

    SELECT 
        @TotalGanhos = ISNULL(SUM(VALOR), 0)
        FROM RELATORIO_FINANCEIRO
        WHERE VALOR > 0 AND DATA_EMISSAO BETWEEN @DataInicio AND @DataFim;

    SELECT 
        @TotalDespesas = ISNULL(SUM(VALOR), 0)
        FROM RELATORIO_FINANCEIRO
        WHERE VALOR < 0 AND DATA_EMISSAO BETWEEN @DataInicio AND @DataFim;

    SET @SaldoFinal = @TotalGanhos + @TotalDespesas;

    PRINT '--- RESUMO FINANCEIRO ---';

    SELECT 
        @TotalGanhos AS TOTAL_GANHOS,
        @TotalDespesas AS TOTAL_DESPESAS,
        @SaldoFinal AS SALDO_FINAL;
END;
GO

--


CREATE PROCEDURE PR_PagarParcelas
    @ID_PARCELA INT, -- id na tabela PARCELAS
    @NUM_PARCELAS VARCHAR(35),
    @OBS VARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @NUM_PARCELAS = 'ALL'
    BEGIN
        UPDATE DEBITO_PARCELAS
        SET STATUS = 'Paga',
            DATA_PAGAMENTO = GETDATE(),
            OBSERVACAO = @OBS
        WHERE ID_PARCELAS = @ID_PARCELA; -- <-- CORREÇÃO: Usando ID_PARCELAS (FK)
    END
    ELSE
    BEGIN
        UPDATE DEBITO_PARCELAS
        SET STATUS = 'Paga',
            DATA_PAGAMENTO = GETDATE(),
            OBSERVACAO = @OBS
        WHERE ID_PARCELAS = @ID_PARCELA -- <-- CORREÇÃO: Usando ID_PARCELAS (FK)
          AND NUM_PARCELA IN (
              SELECT value FROM STRING_SPLIT(@NUM_PARCELAS, ',')
          );
    END

    -- Atualiza status geral se todas estiverem pagas
    IF EXISTS (
        SELECT 1
        FROM DEBITO_PARCELAS
        -- CORREÇÃO: Checa se há alguma parcela PENDENTE referente a este ID da Parcela Mãe
        WHERE ID_PARCELAS = @ID_PARCELA AND STATUS <> 'Paga' 
    )
        RETURN;

    UPDATE PARCELAS
    SET STATUS_GERAL = 'Paga'
    WHERE ID_PARCELAS = @ID_PARCELA;
END;

GO
CREATE FUNCTION FN_PROXIMO_DIA_UTIL (@Data DATE)
RETURNS DATE
AS
BEGIN
    DECLARE @Res DATE = @Data;
    DECLARE @Ano INT = YEAR(@Res);

    -- Calcula Páscoa e derivados
    DECLARE @Pascoa DATE = dbo.FN_calcPascoa(@Ano);
    DECLARE @Carnaval DATE = DATEADD(DAY, -47, @Pascoa);
    DECLARE @SextaSanta DATE = DATEADD(DAY, -2, @Pascoa);
    DECLARE @CorpusChristi DATE = DATEADD(DAY, 60, @Pascoa);

    WHILE 1 = 1
    BEGIN
        -- Verifica se é sábado (5) ou domingo (6)
        IF (DATEDIFF(DAY, 0, @Res) % 7) IN (5, 6)
        BEGIN
            SET @Res = DATEADD(DAY, 1, @Res);
            CONTINUE;
        END

        -- Verifica feriados fixos cadastrados na tabela (apenas dia/mês)
        IF EXISTS (
            SELECT 1 
            FROM FERIADOS 
            WHERE DIA = DAY(@Res) AND MES = MONTH(@Res)
        )
        BEGIN
            SET @Res = DATEADD(DAY, 1, @Res);
            CONTINUE;
        END

        -- Verifica feriados móveis
        IF @Res IN (@Pascoa, @Carnaval, @SextaSanta, @CorpusChristi)
        BEGIN
            SET @Res = DATEADD(DAY, 1, @Res);
            CONTINUE;
        END

        BREAK; -- achou um dia útil
    END

    RETURN @Res;
END;
GO

-- Outros --

INSERT INTO FERIADOS (DIA, MES, DESCRICAO)
VALUES
(1, 1, 'Confraternização Universal'),
(21, 4, 'Tiradentes'),
(1, 5, 'Dia do Trabalho'),
(7, 9, 'Independência do Brasil'),
(12, 10, 'Nossa Senhora Aparecida'),
(2, 11, 'Finados'),
(15, 11, 'Proclamação da República'),
(25, 12, 'Natal');

ALTER TABLE DEBITO_PARCELAS
ADD CONSTRAINT CHK_Status_Parcela -- restringe a esses valores ai
CHECK (STATUS IN ('Pendente', 'Paga', 'Vencida')); -- pra padronizar os tipos de status

ALTER TABLE PARCELAS
ADD CONSTRAINT CHK_Status_Geral
CHECK (STATUS_GERAL IN ('Pendente', 'Paga', 'Vencida'));


SELECT * FROM CLIENTE