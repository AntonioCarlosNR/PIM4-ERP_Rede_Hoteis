﻿using PIM4.Apresentacao.GestaoView.AdmModelo;
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
    }
}
