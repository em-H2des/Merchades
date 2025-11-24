using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMerchades.Formularios.Financeiro
{
    public partial class frmRelFinanceiro : Form
    {
        public frmRelFinanceiro()
        {
            InitializeComponent();
        }

        private void frmRelFinanceiro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDadosFinanceiro.RELATORIO_FINANCEIRO' table. You can move, or remove it, as needed.
            this.rELATORIO_FINANCEIROTableAdapter.Fill(this.dsDadosFinanceiro.RELATORIO_FINANCEIRO);
            // TODO: This line of code loads data into the 'dsDadosFinanceiro.Vw_RELATORIO_FINANCEIRO_GANHOS' table. You can move, or remove it, as needed.
            this.vw_RELATORIO_FINANCEIRO_GANHOSTableAdapter.Fill(this.dsDadosFinanceiro.Vw_RELATORIO_FINANCEIRO_GANHOS);
            // TODO: This line of code loads data into the 'dsDadosFinanceiro.Vw_RELATORIO_FINANCEIRO_DESPESAS' table. You can move, or remove it, as needed.
            this.vw_RELATORIO_FINANCEIRO_DESPESASTableAdapter.Fill(this.dsDadosFinanceiro.Vw_RELATORIO_FINANCEIRO_DESPESAS);


            this.rvGastos.RefreshReport();
            this.rvGeral.RefreshReport();
            this.rvVendas.RefreshReport();
        }

        //============================FUNÇÕES DOS DATE TIME PICKERS============================//

        //Função para garantir que o DateTimePicker que marca o fim do período seja maior ou igual do que o o início
        private void dtpGastosInicioPeriodo_ValueChanged(object sender, EventArgs e)
        {
            dtpGastosFimPeriodo.MinDate = dtpGastosInicioPeriodo.Value;
        }

        //Função para garantir que o DateTimePicker que marca o fim do período seja maior ou igual do que o o início
        private void dtpVendasInicioPeriodo_ValueChanged(object sender, EventArgs e)
        {
            dtpVendasFimPeriodo.MinDate = dtpVendasInicioPeriodo.Value;
        }

        //Função para garantir que o DateTimePicker que marca o fim do período seja maior ou igual do que o o início
        private void dtpGeralInicioPeriodo_ValueChanged(object sender, EventArgs e)
        {
            dtpGeralFimPeriodo.MinDate = dtpGeralInicioPeriodo.Value;
        }

        //============================FUNÇÕES DE FILTRAGEM============================//

        //============================GASTOS============================//

        //Aplica os filtros dos date pickers para o report viewer de gastos
        private void btnGastosFiltrar_Click(object sender, EventArgs e)
        {
            //Pega o valor dos dias de início de fim do período
            string dataInicio = dtpGastosInicioPeriodo.Value.ToString();
            string dataFim = dtpGastosFimPeriodo.Value.ToString();
            //Aplica o filtro com base nos valores dos DateTimePickers
            this.vwRELATORIOFINANCEIRODESPESASBindingSource.Filter = $"DATA_EMISSAO >= '{dataInicio}' AND DATA_EMISSAO <= '{dataFim}'";
            //Atualiza o ReportViewer
            this.rvGastos.RefreshReport();
        }

        //Limpa o filtro de data de gastos
        private void btnGastosLimpar_Click(object sender, EventArgs e)
        {
            this.vwRELATORIOFINANCEIRODESPESASBindingSource.Filter = ""; //Limpa o filtro
            this.rvGastos.RefreshReport();
        }

        //============================VENDAS============================//

        //Aplica os filtros dos date pickers para o report viewer de vendas
        private void btnVendasFiltrar_Click(object sender, EventArgs e)
        {
            //Pega o valor dos dias de início de fim do período
            string dataInicio = dtpVendasInicioPeriodo.Value.ToString();
            string dataFim = dtpVendasFimPeriodo.Value.ToString();
            //Aplica o filtro com base nos valores dos DateTimePickers
            this.vwRELATORIOFINANCEIROGANHOSBindingSource.Filter = $"DATA_EMISSAO >= '{dataInicio}' AND DATA_EMISSAO <= '{dataFim}'";
            //Atualiza o ReportViewer
            this.rvVendas.RefreshReport();
        }

        //Limpa o filtro de data de vendas
        private void btnVendasLimpar_Click(object sender, EventArgs e)
        {
            this.vwRELATORIOFINANCEIROGANHOSBindingSource.Filter = ""; //Limpa o filtro
            this.rvVendas.RefreshReport();
        }

        //============================GERAL============================//

        //Aplica os filtros dos date pickers para o report viewer do geral
        private void btnGeralFiltrar_Click(object sender, EventArgs e)
        {
            //Pega o valor dos dias de início de fim do período
            string dataInicio = dtpGeralInicioPeriodo.Value.ToString();
            string dataFim = dtpGeralFimPeriodo.Value.ToString();
            //Aplica o filtro com base nos valores dos DateTimePickers
            this.rELATORIOFINANCEIROBindingSource.Filter = $"DATA_EMISSAO >= '{dataInicio}' AND DATA_EMISSAO <= '{dataFim}'";
            //Atualiza o ReportViewer
            this.rvGeral.RefreshReport();
        }

        //Limpa o filtro de data de vendas
        private void btnGeralLimpar_Click(object sender, EventArgs e)
        {
            this.rELATORIOFINANCEIROBindingSource.Filter = ""; //Limpa o filtro
            this.rvGeral.RefreshReport();
        }
    }
}
