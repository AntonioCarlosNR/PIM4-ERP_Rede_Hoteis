using PIM4.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM4.Apresentacao.GestaoView.FinanceiroModelo
{
    public partial class ContasPagar : Form
    {
        public ContasPagar()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            double fornecedores = Convert.ToInt32(txtFornecedores.Text == "" ? 0 : txtFornecedores.Text);
            double impostos = Convert.ToInt32(txtImpostos.Text == "" ? 0: txtImpostos.Text);
            double folhapg = Convert.ToInt32(txtFolhaPg.Text == "" ? 0 : txtFolhaPg.Text);
            double benficios = Convert.ToInt32(txtBeneficios.Text == "" ? 0 : txtBeneficios.Text);
            double alimentacao = Convert.ToInt32(txtAlimentacao.Text == "" ? 0 : txtAlimentacao.Text);
            double dividendos = Convert.ToInt32(txtDividendos.Text == "" ? 0 : txtDividendos.Text);
            double agua = Convert.ToInt32(txtDividendos.Text == "" ? 0 : txtDividendos.Text);
            double banco = Convert.ToInt32(txtTarifaBancaria.Text == "" ? 0 : txtTarifaBancaria.Text);
            double limpeza = Convert.ToInt32(txtMaterialLimpeza.Text == "" ? 0 : txtMaterialLimpeza.Text);
            double escritorio = Convert.ToInt32(txtEscritorio.Text == "" ? 0 : txtEscritorio.Text);
            double manut = Convert.ToInt32(txtManutencaoServicos.Text == "" ? 0 : txtManutencaoServicos.Text);
            double aquimoveis = Convert.ToInt32(txtAquisicaoBens.Text == "" ? 0 : txtAquisicaoBens.Text);
            double consultoria = Convert.ToInt32(txtConsultoria.Text == "" ? 0 : txtConsultoria.Text);
            double telefone = Convert.ToInt32(txtTelefoneInternet.Text == "" ? 0 : txtTelefoneInternet.Text);


            controle.inserirCp(fornecedores, impostos, folhapg, benficios, alimentacao, dividendos, agua, banco,
                limpeza, escritorio, manut, aquimoveis, consultoria, telefone);
            lblResposta.Text = controle.Mensagem;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.apagar();
            lblResposta.Text = controle.Mensagem;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RelatoriosContPag contPag = new RelatoriosContPag();
            contPag.Show();
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.GerarPDF();
        }
    }
}
