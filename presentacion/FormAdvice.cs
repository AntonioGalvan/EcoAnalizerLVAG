using System;
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

        private void btnAgregarConsejo_Click(object sender, EventArgs e)
        {
            frmAgregarConsejo MiForma = new frmAgregarConsejo();
            MiForma.Show();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void btnGenerarConsejo_Click(object sender, EventArgs e)
        {
            var randomNumber = new Random().Next(0, 5);
            switch (randomNumber)
            {
                case 0:
                    lblGenerarConsejo.Text = "";
                    break;
                case 1:
                    lblGenerarConsejo.Text = "Compra productos sin plástico";
                    break;
                case 2:
                    lblGenerarConsejo.Text = "Usa calentador solar.";
                    break;
                case 3:
                    lblGenerarConsejo.Text = "No desperdicies energía";
                    break;
                case 4:
                    lblGenerarConsejo.Text = "Usa ollas a presión";
                    break;
                case 5:
                    lblGenerarConsejo.Text = "Báñate en menos tiempo";
                    break;
            }
        }
    }
}
