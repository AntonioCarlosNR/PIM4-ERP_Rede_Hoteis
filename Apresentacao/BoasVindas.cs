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
            ClienteAtividade cliatv = new ClienteAtividade();
            cliatv.Show();
        }
        private void btnAdm_Click(object sender, EventArgs e)
        {
            Administrativo adm = new Administrativo();
            adm.Show();

        }
        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            Financeiro financeiro = new Financeiro();
            financeiro.Show();
        }

        private void BoasVindas_Load(object sender, EventArgs e)
        {

        }

        
    }
}
