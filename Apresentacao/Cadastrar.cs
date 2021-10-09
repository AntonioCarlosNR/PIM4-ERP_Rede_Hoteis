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
    }
}
