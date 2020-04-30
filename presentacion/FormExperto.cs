using presentacion.Data;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmExperto : MetroFramework.Forms.MetroForm
    {
        public frmExperto()
        {
            InitializeComponent();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidos_Click(object sender, EventArgs e)
        {

        }

        private void lblCiudad_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void frmExperto_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                expertBindingSource.DataSource =
                    dataContext.Experts.ToList();
            }
            pnlExpert.Enabled = false;
            Expert expert = expertBindingSource.Current as Expert;
            if (expert != null && expert.ImageUrl != null)
                ptrExpert.Image = Image.FromFile(expert.ImageUrl);
            else
                ptrExpert.Image = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlExpert.Enabled = true;
            ptrExpert.Image = null;
            expertBindingSource.Add(new Expert());
            expertBindingSource.MoveLast();
            txtNombre.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd =
                new OpenFileDialog()
                {
                    Filter = "archivos GIF|*.gif|archivos JPEG|*.jpg|archivos PNG|*.png"
                }) 
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    ptrExpert.Image = Image.FromFile(ofd.FileName);
                    Expert expert = 
                        expertBindingSource.Current as Expert;
                    if (expert != null)
                        expert.ImageUrl = ofd.FileName;
                    else
                        ptrExpert.Image = null; 
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Expert expert =
                    expertBindingSource.Current as Expert;
                if (expert != null)
                {
                    if (dataContext.Entry<Expert>(expert).State == EntityState.Detached)
                        dataContext.Set<Expert>().Attach(expert);
                    if (expert.Id == 0)
                        dataContext.Entry<Expert>(expert).State = EntityState.Added;
                    else
                        dataContext.Entry<Expert>(expert).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Consejo guardado");
                    grdExpertos.Refresh();
                    pnlExpert.Enabled = false;
                }
            }
        }
    }
}
