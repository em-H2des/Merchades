-- DADOS BASE (Sem dependências de FK ou triggers)
-- -----------------------------------------------------

-- Produtos (ID 1, 2, 3)
INSERT INTO PRODUTOS (NOME_PRODUTOS, TIPO_PRODUTOS, TIPO_UNITARIO, PRECO_PRODUTOS, CODIGO_DE_BARRAS)
VALUES
('Detergente Ypê', 'Limpeza', 'Litro', 2.50, 111223344),
('Coca-Cola 2L', 'Bebida', 'Litro', 5.99, 223344556),
('Leite Longa Vida', 'Alimento', 'Litro', 3.20, 334455667);

-- Fornecedores (ID 1, 2, 3)
INSERT INTO FORNECEDOR (NOME_FORNECEDOR, TELEFONE_FORNECEDOR, EMAIL_FORNECEDOR, ESTADO_FORNECEDOR, CEP_FORNECEDOR, CNPJ_FORNECEDOR)
VALUES
('Fornecedor A', '11987654321', 'fornecedora@empresa.com', 'SP', '01010010', '12345678000123'),
('Fornecedor B', '21998765432', 'contato@bempresa.com', 'RJ', '20010010', '98765432000145'),
('Fornecedor C', '31912345678', 'suporte@cempresa.com', 'MG', '30330040', '54321098000167');

-- Clientes (ID 1 e um cliente genérico será criado pela trigger no teste de venda)
INSERT INTO CLIENTE (NOME_CLIENTE, CPF_CNPJ_CLIENTE)
VALUES ('João Silva', '12345678900');

-- Métodos de pagamento (ID 1, 2, 3, 4)
INSERT INTO METODO_PAGAMENTO (DESCRICAO)
VALUES
('Cartão de Crédito'),
('Dinheiro'),
('Boleto Bancário'),
('Pix');


-- INSERÇÕES DE ENTRADA (COMPRA/ESTOQUE)
-- -----------------------------------------------------

-- 1. Insere NOTA_FISCAL_FORNECEDOR (ID 1).
--    TRIGGER TR_AI_Relatorio_Fornecedor disparam e insere Despesa no RELATORIO_FINANCEIRO.
INSERT INTO NOTA_FISCAL_FORNECEDOR (DATA_EMISSAO, VALOR_COMPRA, COD_NOTA_FORN, OBSERVACAO, ID_FORNECEDOR)
VALUES (GETDATE(), 900.00, 'NF123', 'Compra de produtos para reposição', 1);

-- 2. Insere ITENS_NOTA_FORNECEDOR.
--    TRIGGER TR_AI_AtualizaEstoque_Entrada dispara.
--    - Como o produto 1 NÃO existe no ESTOQUE (a sua inserção original foi removida), ele será INSERIDO no ESTOQUE (QTD: 100).
INSERT INTO ITENS_NOTA_FORNECEDOR (QTD_UNIT_PAC, NUM_LOTE, OBSERVACAO, ID_PRODUTOS, ID_NOTA_FISCAL_FORNEC)
VALUES (100, 20251031, 'Primeiro lote', 1, 1);


-- INSERÇÕES DE SAÍDA (VENDA)
-- -----------------------------------------------------

-- 1. Insere ITENS_NOTA_VENDA.
--    - TR_AI_ITENS_NOTA_VENDA: Calcula o valor (2 * 2.50 = 5.00) e ATUALIZA VALOR_VENDA na NOTA_FISCAL_VENDA 1.
--    - TR_AI_AtualizaEstoque_Saida: Reduz o estoque (100 - 2 = 98).
INSERT INTO ITENS_NOTA_VENDA (QTD_PRODUTO, ID_PRODUTOS, ID_NOTA_VENDA)
VALUES (2, 1, 1);

-- FINALIZANDO A NOTA (TESTE DE PARCELAS E RELATÓRIO)
-- -----------------------------------------------------

-- 2. Finaliza a NOTA_FISCAL_VENDA (ID 1).
UPDATE NOTA_FISCAL_VENDA
SET STATUS_VENDA = 'F', VALOR_VENDA = 5.00 -- Valor final da venda
WHERE ID_NOTA_VENDA = 1;

-- 3. Insere uma nova NOTA_FISCAL_VENDA (ID 2) com QTD_PARCELAS > 0 e STATUS_VENDA 'F'
--    - TR_AI_GerarParcelas: Dispara ao INSERIR e cria PARCELAS e DEBITO_PARCELAS.
--    - TR_AI_Relatorio_Venda: Dispara ao INSERIR ('F') e insere Ganho no RELATORIO_FINANCEIRO.
INSERT INTO NOTA_FISCAL_VENDA
(DATA_EMISSAO, VALOR_VENDA, COD_NOTA_VENDA, QTD_PARCELAS, STATUS_VENDA, ID_CLIENTE, ID_FORNECEDOR, ID_METODO_PAGAMENTO)
VALUES (GETDATE(), 100.00, 999111, 4, 'F', 1, 1, 1);

SELECT * FROM PRODUTOS
SELECT * FROM FORNECEDOR
SELECT * FROM CLIENTE
SELECT * FROM METODO_PAGAMENTO
SELECT * FROM ESTOQUE
SELECT * FROM NOTA_FISCAL_VENDA
SELECT * FROM NOTA_FISCAL_FORNECEDOR
SELECT * FROM ITENS_NOTA_VENDA
SELECT * FROM ITENS_NOTA_FORNECEDOR
SELECT * FROM RELATORIO_FINANCEIRO
SELECT * FROM PARCELAS
SELECT * FROM DEBITO_PARCELAS