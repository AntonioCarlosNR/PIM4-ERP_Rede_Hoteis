using PIM4.Apresentacao.GestaoView;
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
    public partial class BoasVindas : Form
    {
        public BoasVindas()
        {
            InitializeComponent();
            
        }

        private void btnCliAtv_Click(object sender, EventArgs e)
        {
            //fecha tela atual
            this.Hide();
            //abre nova tela
            ClienteAtividade cliatv = new ClienteAtividade();
            cliatv.Closed += (s, args) => this.Close();
            cliatv.Show();
        }
        private void btnAdm_Click(object sender, EventArgs e)
        {
            //fecha tela atual
            this.Hide();
            //abre nova tela
            Administrativo adm = new Administrativo();
            adm.Closed += (s, args) => this.Close();
            adm.Show();

        }
        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            //fecha tela atual
            this.Hide();
            //abre nova tela
            Financeiro financeiro = new Financeiro();
            financeiro.Closed += (s, args) => this.Close();
            financeiro.Show();
        }

        private void BoasVindas_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
