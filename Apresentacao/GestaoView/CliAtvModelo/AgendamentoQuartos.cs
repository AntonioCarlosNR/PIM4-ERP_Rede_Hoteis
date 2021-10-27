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
            txtId.Text = Convert.ToString(controle.getIdCliente(txtNomeHospede.Text));

            if(controle.getIdCliente(txtNomeHospede.Text) != 0)
            {
                // inserir campo pra ID do cliente
                int qtd = int.Parse(txtQtdPessoas.Text);
                int valor = int.Parse(txtValor.Text);
                int quarto = int.Parse(txtQuarto.Text);

                string mensagem = controle.agendar(txtNomeHospede.Text, qtd, valor, dtcheckin.Value.Date.ToString("yyyy-MM-dd"), dtCheckout.Value.Date.ToString("yyyy-MM-dd"), quarto, controle.getIdCliente(txtNomeHospede.Text));

                if (controle.Existe)
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(controle.Mensagem);
                }
            }
            else
            {
                MessageBox.Show("Cliente não cadastrado", "ID não encoontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            int id = Convert.ToInt32(txtIdReserva.Text);
            controle.buscardados(id);

            txtNomeHospede.Text = controle.nomeHospede;
            txtQtdPessoas.Text = Convert.ToString(controle.qtdPessoas);
            txtQuarto.Text = Convert.ToString(controle.quarto);
            txtValor.Text = Convert.ToString(controle.valor);
            txtId.Text = Convert.ToString(controle.id);
            dtcheckin.Value = controle.checkin;
            dtCheckout.Value = controle.checkout;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.apagar(Convert.ToInt32(txtIdReserva.Text));
            if (!controle.Existe.Equals(""))
            {
                MessageBox.Show("Registro apagado com sucesso!!", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdReserva.Clear();
                txtNomeHospede.Clear();
                txtQtdPessoas.Clear();
                txtQuarto.Clear();
                txtValor.Clear();
                txtId.Clear();
                //dtcheckin.Value = controle.checkin;
                //dtCheckout.Value = controle.checkout;

            }
            else
            {
                MessageBox.Show(controle.Mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // inserir campo pra ID do cliente
            int qtd = int.Parse(txtQtdPessoas.Text);
            int valor = int.Parse(txtValor.Text);
            int quarto = int.Parse(txtQuarto.Text);
            Controle controle = new Controle();

            string mensagem = controle.atualizarReserva(txtNomeHospede.Text, qtd, valor, dtcheckin.Value.Date.ToString("yyyy-MM-dd"), dtCheckout.Value.Date.ToString("yyyy-MM-dd"), quarto, Convert.ToInt32(txtId.Text),Convert.ToInt32(txtIdReserva.Text));

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
