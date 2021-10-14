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

namespace PIM4.Apresentacao.GestaoView.CliAtvModelo
{
    public partial class AgendamentoQuartos : Form
    {
        public AgendamentoQuartos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgendarQuarto_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            // inserir campo pra ID do cliente
            int qtd = int.Parse(txtQtdPessoas.Text);
            int valor = int.Parse(txtValor.Text);
  
            string mensagem = controle.agendar(txtNomeHospede.Text, qtd, valor, dtcheckin.Value.Date.ToString("yyyy-MM-dd"), dtCheckout.Value.Date.ToString("yyyy-MM-dd"));

            if (controle.Existe)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
        }
    }
}
