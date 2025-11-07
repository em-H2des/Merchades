using Merchad;
using prjMerchades.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchades
    {
        public partial class frmMenu : Form
        {
            public frmMenu()
            {
                InitializeComponent();
                this.WindowState = FormWindowState.Maximized; // abre em tela cheia
            }

            // Abre formulários dentro de uma aba
            private void AbrirFormulario(Form form, string titulo)
            {
                foreach (TabPage page in tabControlSaida.TabPages)
                {
                    if (page.Text == titulo)
                    {
                        tabControlSaida.SelectedTab = page;
                        return;
                    }
                }

                TabPage novaAba = new TabPage(titulo);
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                novaAba.Controls.Add(form);
                tabControlSaida.TabPages.Add(novaAba);
                tabControlSaida.SelectedTab = novaAba;

                form.Show();
            }


        //==================================Aba do Caixa==================================//

        private void btnCancelaVenda_Click(object sender, EventArgs e)
        {
            frmMenuSaida novoForm = new frmMenuSaida();
            this.Hide(); // apenas esconde o atual
            novoForm.ShowDialog();
            this.Close(); // fecha depois que o novo for fechado
        }

        private void btnFinalizaCompra_Click(object sender, EventArgs e)
        {
            frmPagamento novoForm = new frmPagamento();
            novoForm.Show();//Abre uma tela do formProdutos
        }

        //Botão que leva para a aba estoque para adicionar um item ao carrinho
        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            //Troca para a aba de estoque
            tabControlSaida.SelectedIndex = 1;
        }

        private void btnAumentaQtd_Click(object sender, EventArgs e)
        {
            //Verifica se um item foi selecionado para aumentar a quantidade
            if (dataGridViewProdutosCarrinho.SelectedRows.Count == 0)
            {
                //Se não selecionou um item, vai dar um alert
                MessageBox.Show("Selecione um produto para aumentar a quantidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Aumenta a quantidade de todos os itens selecionados em 1
                for (int i = 0; i < dataGridViewProdutosCarrinho.SelectedRows.Count; i++)
                {
                    dataGridViewProdutosCarrinho.SelectedRows[i].Cells[1].Value = int.Parse(dataGridViewProdutosCarrinho.SelectedRows[i].Cells[1].Value.ToString()) + 1;
                }
            }
        }

        private void btnDiminuiQtd_Click(object sender, EventArgs e)
        {
            //Verifica se um item foi selecionado para aumentar a quantidade
            if (dataGridViewProdutosCarrinho.SelectedRows.Count == 0)
            {
                //Se não selecionou um item, vai dar um alert
                MessageBox.Show("Selecione um produto para diminuir a quantidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult acaoDoUsuario = MessageBox.Show("Deseja apagar o(s) produto(s) selecionados do carrinho?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (acaoDoUsuario == DialogResult.Yes)
                {
                    //Loop para diminuir a quantidade de todos os itens selecionados em 1
                    int numDeItensSelecionados = dataGridViewProdutosCarrinho.SelectedRows.Count;
                    for (int i = 0; i < numDeItensSelecionados; i++)
                    {
                        //Verifica se o item vai zerar a quantidade caso seja removida uma unidade
                        if (int.Parse(dataGridViewProdutosCarrinho.SelectedRows[0].Cells[1].Value.ToString()) == 1)
                        {
                            //Remove o item inteiro (ele pega na posição 0 porque quando um item é removido o array diminui em tamanho, então ele tem que apagar todos na posição 0)
                            dataGridViewProdutosCarrinho.Rows.RemoveAt(dataGridViewProdutosCarrinho.SelectedRows[0].Index);
                        }
                        else
                        {
                            //Remove uma unidade do item no carrinho caso ainda tenha mais de uma unidade
                            dataGridViewProdutosCarrinho.SelectedRows[i].Cells[1].Value = int.Parse(dataGridViewProdutosCarrinho.SelectedRows[i].Cells[1].Value.ToString()) - 1;
                        }
                    }
                }
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            DialogResult acaoDoUsuario = MessageBox.Show("Deseja apagar o(s) produto(s) selecionados do carrinho?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (acaoDoUsuario == DialogResult.Yes)
            {

                int numDeItensSelecionados = dataGridViewProdutosCarrinho.SelectedRows.Count;
                for (int i = 0; i < numDeItensSelecionados; i++)
                {
                    dataGridViewProdutosCarrinho.Rows.RemoveAt(dataGridViewProdutosCarrinho.SelectedRows[0].Index);
                }
            }
        }

        //==================================Aba do Estoque==================================//

        //Carrega os dados do DataGrid de Estoque através do TableAdapter ResumoEstoque no dsDadosSaida
        private void formMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDadosSaida.ResumoEstoque' table. You can move, or remove it, as needed.
            this.resumoEstoqueTableAdapter.FillResumoEstoque(this.dsDadosSaida.ResumoEstoque);

        }

        //Botão da que volta para a aba Caixa
        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            /*formMerchades novoForm = new formMerchades();
            this.Hide(); // apenas esconde o atual
            novoForm.ShowDialog();
            this.Close(); // fecha depois que o novo for fechado*/
            // Abre o formCaixa dentro da aba "Caixa"
            // Seleciona a aba "Caixa" dentro do tabControlSaida
            foreach (TabPage page in tabControlSaida.TabPages)
            {
                if (page.Name == "tabCaixa") // ou use page.Text se quiser pelo título da aba
                {
                    tabControlSaida.SelectedTab = page;
                    break;
                }
            }
        }

        //Botão de Aplicar o filtro e a coluna de ordenação
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string palavraChave = txtBuscarEstoque.Text;
            string parametroFiltro = cmbFiltro.Text;
            string parametroOrdenar = cmbOrdenar.Text;

            //Verifica se os parâmetros estão preenchidos corretamente
            if (!string.IsNullOrEmpty(palavraChave) && !string.IsNullOrEmpty(parametroFiltro))
            {
                //Caso preenchidos corretamente cria a query de filtro com base na palavra chave e coluna de filtro

                //Converte o texto que está sendo mostrado pro usuário para
                //o nome real da coluna no banco (por exemplo, Código e CODIGO_DE_BARRAS)

                switch (parametroFiltro)
                {
                    case "Código":
                        parametroFiltro = "CODIGO_DE_BARRAS";
                        break;
                    case "Nome":
                        parametroFiltro = "NOME_PRODUTOS";
                        break;
                    case "Unidade de Medida":
                        parametroFiltro = "TIPO_UNITARIO";
                        break;
                    case "Categoria":
                        parametroFiltro = "TIPO_PRODUTOS";
                        break;
                    case "Estoque Atual":
                        parametroFiltro = "QTD_ESTOQUE";
                        break;
                    case "Preço de Venda":
                        parametroFiltro = "PRECO_PRODUTOS";
                        break;
                }

                string queryFiltro = $"{parametroFiltro} LIKE '%{palavraChave}%'";

                //Aplica a query de filtro no binding source
                this.resumoEstoqueBindingSource.Filter = queryFiltro;
            }
            //Caso os parâmetros palavra-chave e filtro não estejam preenchidos ou estejam preenchidos parcialmente
            else
            {
                //Limpa o filtro do binding source
                this.resumoEstoqueBindingSource.Filter = null;
            }

            // Converte o texto da interface para o nome real da coluna do banco
            switch (parametroOrdenar)
            {
                case "Código":
                    parametroOrdenar = "CODIGO_DE_BARRAS";
                    break;
                case "Nome":
                    parametroOrdenar = "NOME_PRODUTOS";
                    break;
                case "Unidade de Medida":
                    parametroOrdenar = "TIPO_UNITARIO";
                    break;
                case "Categoria":
                    parametroOrdenar = "TIPO_PRODUTOS";
                    break;
                case "Estoque Atual":
                    parametroOrdenar = "QTD_ESTOQUE";
                    break;
                case "Preço de Venda":
                    parametroOrdenar = "PRECO_PRODUTOS";
                    break;
                default:
                    parametroOrdenar = string.Empty; // Se não for selecionado, zera
                    break;
            }

            // Aplica a ordenação usando a propriedade Sort
            if (!string.IsNullOrEmpty(parametroOrdenar))
            {
                this.resumoEstoqueBindingSource.Sort = parametroOrdenar;
            }
            else
            {
                this.resumoEstoqueBindingSource.Sort = null; // Limpa a ordenação se não houver seleção
            }
        }

        //Botão para limpar o filtro e a ordem
        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            //Reseta o valor dos campos de palavra-chave, filtrar por e ordenar por
            txtBuscarEstoque.Text = "";
            cmbFiltro.SelectedIndex = -1;
            cmbOrdenar.SelectedIndex = -1;

            //Tira o filtro do binding source para mostrar todos os dados sem filtro no DataGrid
            this.resumoEstoqueBindingSource.Filter = null;

            //Reseta a ordenação do binding source
            this.resumoEstoqueBindingSource.Sort = null;
        }

        //Botão que adiciona os itens selecionados do estoque para o carrinho
        private void btnAddItemCarrinho_Click(object sender, EventArgs e)
        {
            //Verifica se o usuário selecionou algum item
            if (dataGridViewProdutosDisponiveis.SelectedRows.Count == 0)
            {
                //Se não selecionou vai dar um alert
                MessageBox.Show("Selecione um produto para enviar ao carrinho.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Cria um array que aceita vários tipos de dados para armazenar os dados de um produto
                object[] informacoesDoProduto = new object[3];

                //Segue abaixo o index de cada informação dentro do array:
                //informacoesDoProduto[0] = Nome do produto
                //informacoesDoProduto[1] = Quantidade do produto
                //informacoesDoProduto[2] = Preço unitário do produto

                //Se selecionou mais de um produto, vai enviar todos para o carrinho, um em cada ciclo do int i
                for (int i=dataGridViewProdutosDisponiveis.SelectedRows.Count-1; i>=0; i--)
                {
                    //Loop para verificar se o produto já está no carrinho
                    bool produtoJaEstavaNoCarrinho = false; //Variável para controlar se o produto já estava no carrinho ou não
                    for (int aux=0; aux<dataGridViewProdutosCarrinho.Rows.Count; aux++)
                    {
                        //Condição: Se o produto que está sendo adicionado já estiver no carrinho adicione um para a quantidade
                        if (dataGridViewProdutosCarrinho.Rows[aux].Cells[0].Value == dataGridViewProdutosDisponiveis.SelectedRows[i].Cells[1].Value)
                        {
                            //Adiciona mais uma unidade à quantidade do produto no carrinho
                            dataGridViewProdutosCarrinho.Rows[aux].Cells[1].Value = int.Parse(dataGridViewProdutosCarrinho.Rows[aux].Cells[1].Value.ToString()) + 1;

                            //Muda a flag que verifica se o item já estava no carrinho para true
                            produtoJaEstavaNoCarrinho = true;
                        }
                    }

                    //Cadastra o produto no carrinho com uma unidade caso ele já não esteja lá
                    if (!produtoJaEstavaNoCarrinho)
                    {
                        //Pega as informações do item
                        informacoesDoProduto[0] = dataGridViewProdutosDisponiveis.SelectedRows[i].Cells[1].Value; //Pega o valor da célula de index [1] da linha, que no caso é a coluna Nome
                        informacoesDoProduto[1] = 1; // Envia uma unidade do produto para o carrinho, onde a quantidade pode ser alterada facilmente
                        informacoesDoProduto[2] = dataGridViewProdutosDisponiveis.SelectedRows[i].Cells[5].Value; //Pega o preço de venda do produto

                        //Envia para o DataGrid de carrinho
                        dataGridViewProdutosCarrinho.Rows.Add(informacoesDoProduto);
                    }  
                }

            }
        }
    }
}


