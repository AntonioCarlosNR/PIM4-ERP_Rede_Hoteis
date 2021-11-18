using PIM4.Apresentacao.GestaoView.AdmModelo;
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
    public partial class Administrativo : Form
    {
        public Administrativo()
        {
            InitializeComponent();
        }

        private void btnInOut_Click(object sender, EventArgs e)
        {
            CheckInOut inout = new CheckInOut();
            inout.Show();
        }

        private void btnAmdFunc_Click(object sender, EventArgs e)
        {
            AdmFuncionario adm = new AdmFuncionario();
            adm.Show();
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
