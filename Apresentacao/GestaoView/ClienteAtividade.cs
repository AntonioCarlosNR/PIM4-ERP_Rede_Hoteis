using PIM4.Apresentacao.GestaoView.CliAtvModelo;
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

namespace PIM4.Apresentacao.GestaoView
{
    public partial class ClienteAtividade : Form
    {
        public ClienteAtividade()
        {
            InitializeComponent();
        }

        private void btnCadastroCli_Click(object sender, EventArgs e)
        {
            //para chamar outra view instanciar a classe da view e chamar com .Show()
            Cadastrar cadastra = new Cadastrar();
            cadastra.Show();
        }

        private void btnAgendaQuartos_Click(object sender, EventArgs e)
        {
            AgendamentoQuartos agendamento = new AgendamentoQuartos();
            agendamento.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //fecha tela atual
            this.Hide();
            //abre nova tela
            BoasVindas bv = new BoasVindas();
            bv.Closed += (s, args) => this.Close();
            bv.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
