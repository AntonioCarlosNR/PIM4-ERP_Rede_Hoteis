using PIM4.Apresentacao;
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

namespace PIM4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn2entrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text,txtSenha.Text);
            if (controle.Mensagem.Equals(""))
            {
                if (controle.Existe)
                {
                    MessageBox.Show("Logado com sucesso!!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BoasVindas bv = new BoasVindas();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
            
        }

        private void lbl2senha_Click(object sender, EventArgs e)
        {

        }
    }
}
