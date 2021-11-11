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
        public string tabela;
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrese_Click(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                tabela = "TB_Cliente";
            }
            else if (rdbUsuario.Checked)
            {
                tabela = "TB_Usuario";
            }
            Controle controle = new Controle();
      
            long fone = Convert.ToInt64(txtFone.Text);
            long cpf = Convert.ToInt64(txtCpf.Text);

            bool verifica = controle.verificarCadastro(txtLogin.Text, tabela);

            if (verifica.Equals(false))
            {
                string mensagem = controle.cadastrar(txtNome.Text, txtEndereco.Text, txtLogin.Text, txtSenha.Text, txtConfSenha.Text, fone, cpf, tabela);

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
                MessageBox.Show(controle.Mensagem + " " + "Usuário/Cliente já cadastrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

            txtIdCliente.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtLogin.Clear();
            txtFone.Clear();
            txtCpf.Clear();
            txtSenha.Clear();
            txtConfSenha.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                tabela = "TB_Cliente";
            }
            else if (rdbUsuario.Checked)
            {
                tabela = "TB_Usuario";
            }
            Controle controle = new Controle();

            if (txtIdCliente.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir algum valor para a pesquisa", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(txtIdCliente.Text);
                controle.IdCliente(id, tabela);

                txtNome.Text = controle.nome;
                txtEndereco.Text = controle.endereco;
                txtLogin.Text = controle.email;
                txtFone.Text = Convert.ToString(controle.fone);
                txtCpf.Text = Convert.ToString(controle.doc);
                txtSenha.Text = controle.senha;
            }            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                tabela = "TB_Cliente";
            }
            else if (rdbUsuario.Checked)
            {
                tabela = "TB_Usuario";
            }
            Controle controle = new Controle();
            
            int id = Convert.ToInt32(txtIdCliente.Text);

            controle.apagar(id, tabela);
            if (controle.Mensagem.Equals(""))
            {    
                MessageBox.Show("Registro apagado com sucesso!!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdCliente.Clear();
                txtNome.Clear();
                txtEndereco.Clear();
                txtLogin.Clear();
                txtFone.Clear();
                txtCpf.Clear();
                txtSenha.Clear();
                txtConfSenha.Clear();
            }
            else
            {
                MessageBox.Show(controle.Mensagem + " " + "Não foi possível apagar esse registro,Cliente com reserva de quarto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                tabela = "TB_Cliente";
            }
            else if (rdbUsuario.Checked)
            {
                tabela = "TB_Usuario";
            }
            Controle controle = new Controle();

            long fone = Convert.ToInt64(txtFone.Text);
            long cpf = Convert.ToInt64(txtCpf.Text);
            int id = Convert.ToInt32(txtIdCliente.Text);

            string mensagem = controle.atualizar(txtNome.Text, txtEndereco.Text, txtLogin.Text, txtSenha.Text, txtConfSenha.Text, fone, cpf, id, tabela);

            if (controle.Existe)
            {
                MessageBox.Show(mensagem, "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }

            txtIdCliente.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtLogin.Clear();
            txtFone.Clear();
            txtCpf.Clear();
            txtSenha.Clear();
            txtConfSenha.Clear();
        }

        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            setEnable(true);
        }
        private void rdbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            setEnable(true);
        }
        private void setEnable(bool enable)
        {
            txtNome.Enabled = enable;
            txtEndereco.Enabled = enable;
            txtCpf.Enabled = enable;
            txtLogin.Enabled = enable;
            txtSenha.Enabled = enable;
            txtConfSenha.Enabled = enable;
            txtIdCliente.Enabled = enable;
            txtFone.Enabled = enable;
            btnApagar.Enabled = enable;
            btnAtualizar.Enabled = enable;
            btnBuscar.Enabled = enable;
            btnCadastrese.Enabled = enable;
        }
    }
}
