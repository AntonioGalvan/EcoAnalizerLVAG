using presentacion.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmAgregarConsejo : Form
    {
        public frmAgregarConsejo()
        {
            InitializeComponent();
        }
       
        private void frmAgregarConsejo_Load_1(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                adviceBindingSource.DataSource =
                    dataContext.Advices.ToList();
            }
            pnlAgregarEditar.Enabled = false;
            Advice advice = adviceBindingSource.Current as Advice;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlAgregarEditar.Enabled = true;
            adviceBindingSource.Add(new Advice());
            adviceBindingSource.MoveLast();
            txtTexto.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlAgregarEditar.Enabled = true;
            txtTexto.Focus();
            Advice advice =
                adviceBindingSource.Current as Advice;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
            "¿Quieres eliminar el Consejo?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Advice advice = adviceBindingSource.Current as Advice;
                    if (advice != null)
                    {
                        if (dataContext.Entry<Advice>(advice).State == EntityState.Detached)
                            dataContext.Set<Advice>().Attach(advice);
                        dataContext.Entry<Advice>(advice).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Empleado eliminado");
                        adviceBindingSource.RemoveCurrent();
                        pnlAgregarEditar.Enabled = false;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAgregarEditar.Enabled = false;
            adviceBindingSource.ResetBindings(false);
            frmAgregarConsejo_Load_1(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Advice advice =
                    adviceBindingSource.Current as Advice;
                if (advice != null)
                {
                    if (dataContext.Entry<Advice>(advice).State == EntityState.Detached)
                        dataContext.Set<Advice>().Attach(advice);
                    if (advice.Id == 0)
                        dataContext.Entry<Advice>(advice).State = EntityState.Added;
                    else
                        dataContext.Entry<Advice>(advice).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Consejo guardado");
                    grdConsejos.Refresh();
                    pnlAgregarEditar.Enabled = false;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

