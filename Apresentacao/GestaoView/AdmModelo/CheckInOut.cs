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

namespace PIM4.Apresentacao.GestaoView.AdmModelo
{
    public partial class CheckInOut : Form
    {
        private Controle Meucontrole;
        public CheckInOut()
        {
            InitializeComponent();
        }

        private void lblNomeReser_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            Meucontrole = new Controle(Convert.ToInt32(txtIdReser.Text));
            lblStatus.Text = Meucontrole.Mensagem;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string checkin = "in";
            Meucontrole = new Controle(Convert.ToInt32(txtIdReser.Text),checkin);
            lblStatus.Text = Meucontrole.Mensagem;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string checkout = "out";
            Meucontrole = new Controle(Convert.ToInt32(txtIdReser.Text), checkout);
            lblStatus.Text = Meucontrole.Mensagem;
        }
    }
}
