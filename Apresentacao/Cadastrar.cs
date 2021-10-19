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

namespace PIM4.Apresentacao
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrese_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            // inserir campo pra nomes 
            long fone = Convert.ToInt64(txtFone.Text);
            long cpf = Convert.ToInt64(txtCpf.Text);

            string mensagem = controle.cadastrar(txtNome.Text, txtEndereco.Text,txtLogin.Text,txtSenha.Text, txtConfSenha.Text, fone, cpf);

            if (controle.Existe)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            int id = Convert.ToInt32(txtIdCliente.Text);
            controle.IdCliente(id);

            txtNome.Text = controle.nome;
            txtEndereco.Text = controle.endereco;
            txtLogin.Text = controle.email;
            txtFone.Text = Convert.ToString(controle.fone);
            txtCpf.Text = Convert.ToString(controle.doc);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            // inserir campo pra nomes 
            long fone = Convert.ToInt64(txtFone.Text);
            long cpf = Convert.ToInt64(txtCpf.Text);
            int id = Convert.ToInt32(txtIdCliente.Text);

            controle.apagar(id);
            if (controle.Mensagem.Equals(""))
            {
                if (!controle.Existe)
                {
                    MessageBox.Show("Registro apagado com sucesso!!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdCliente.Clear();
                    txtNome.Clear();
                    txtEndereco.Clear();
                    txtLogin.Clear();
                    txtFone.Clear();
                    txtCpf.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possível apagar esse registro,Cliente com reserva de quarto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
        }
    }
}
