﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmAdvice : Form
    {
        public frmAdvice()
        {
            InitializeComponent();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void btnAgregarConsejo_Click(object sender, EventArgs e)
        {
            frmAgregarConsejo MiForma = new frmAgregarConsejo();
            MiForma.Show();
        }
    }
}