using PIM4.Apresentacao.GestaoView.FinanceiroModelo;
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
    public partial class Financeiro : Form
    {
        public Financeiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Show();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            ContasPagar contasPagar = new ContasPagar();
            contasPagar.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
