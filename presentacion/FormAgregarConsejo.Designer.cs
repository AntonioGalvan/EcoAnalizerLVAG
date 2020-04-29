namespace presentacion
{
    partial class frmAgregarConsejo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.adviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdConsejos = new MetroFramework.Controls.MetroGrid();
            this.pnlAgregarEditar = new MetroFramework.Controls.MetroPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.lblTexto = new MetroFramework.Controls.MetroLabel();
            this.lblAutor = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtTexto = new MetroFramework.Controls.MetroTextBox();
            this.txtAutor = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsejos)).BeginInit();
            this.pnlAgregarEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(49, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(449, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestor de Consejos";
            // 
            // grdConsejos
            // 
            this.grdConsejos.AllowUserToResizeRows = false;
            this.grdConsejos.AutoGenerateColumns = false;
            this.grdConsejos.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.grdConsejos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdConsejos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdConsejos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConsejos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grdConsejos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsejos.DataSource = this.adviceBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConsejos.DefaultCellStyle = dataGridViewCellStyle14;
            this.grdConsejos.EnableHeadersVisualStyles = false;
            this.grdConsejos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdConsejos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConsejos.Location = new System.Drawing.Point(59, 112);
            this.grdConsejos.Name = "grdConsejos";
            this.grdConsejos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConsejos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grdConsejos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdConsejos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsejos.Size = new System.Drawing.Size(501, 203);
            this.grdConsejos.TabIndex = 2;
            // 
            // pnlAgregarEditar
            // 
            this.pnlAgregarEditar.Controls.Add(this.btnGuardar);
            this.pnlAgregarEditar.Controls.Add(this.btnCancelar);
            this.pnlAgregarEditar.Controls.Add(this.btnEliminar);
            this.pnlAgregarEditar.Controls.Add(this.txtAutor);
            this.pnlAgregarEditar.Controls.Add(this.txtTexto);
            this.pnlAgregarEditar.Controls.Add(this.txtId);
            this.pnlAgregarEditar.Controls.Add(this.lblAutor);
            this.pnlAgregarEditar.Controls.Add(this.lblTexto);
            this.pnlAgregarEditar.Controls.Add(this.lblId);
            this.pnlAgregarEditar.Enabled = false;
            this.pnlAgregarEditar.HorizontalScrollbarBarColor = true;
            this.pnlAgregarEditar.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAgregarEditar.HorizontalScrollbarSize = 10;
            this.pnlAgregarEditar.Location = new System.Drawing.Point(582, 99);
            this.pnlAgregarEditar.Name = "pnlAgregarEditar";
            this.pnlAgregarEditar.Size = new System.Drawing.Size(291, 216);
            this.pnlAgregarEditar.TabIndex = 3;
            this.pnlAgregarEditar.VerticalScrollbarBarColor = true;
            this.pnlAgregarEditar.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAgregarEditar.VerticalScrollbarSize = 10;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(461, 347);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar Consejos";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(27, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(27, 71);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(39, 19);
            this.lblTexto.TabIndex = 3;
            this.lblTexto.Text = "Texto";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(27, 103);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(42, 19);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(127, 40);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(121, 23);
            this.txtId.TabIndex = 5;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTexto
            // 
            // 
            // 
            // 
            this.txtTexto.CustomButton.Image = null;
            this.txtTexto.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtTexto.CustomButton.Name = "";
            this.txtTexto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTexto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTexto.CustomButton.TabIndex = 1;
            this.txtTexto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTexto.CustomButton.UseSelectable = true;
            this.txtTexto.CustomButton.Visible = false;
            this.txtTexto.Lines = new string[0];
            this.txtTexto.Location = new System.Drawing.Point(127, 71);
            this.txtTexto.MaxLength = 32767;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.PasswordChar = '\0';
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTexto.SelectedText = "";
            this.txtTexto.SelectionLength = 0;
            this.txtTexto.SelectionStart = 0;
            this.txtTexto.ShortcutsEnabled = true;
            this.txtTexto.Size = new System.Drawing.Size(121, 23);
            this.txtTexto.TabIndex = 6;
            this.txtTexto.UseSelectable = true;
            this.txtTexto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTexto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAutor
            // 
            // 
            // 
            // 
            this.txtAutor.CustomButton.Image = null;
            this.txtAutor.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtAutor.CustomButton.Name = "";
            this.txtAutor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAutor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAutor.CustomButton.TabIndex = 1;
            this.txtAutor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAutor.CustomButton.UseSelectable = true;
            this.txtAutor.CustomButton.Visible = false;
            this.txtAutor.Lines = new string[0];
            this.txtAutor.Location = new System.Drawing.Point(127, 103);
            this.txtAutor.MaxLength = 32767;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PasswordChar = '\0';
            this.txtAutor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAutor.SelectedText = "";
            this.txtAutor.SelectionLength = 0;
            this.txtAutor.SelectionStart = 0;
            this.txtAutor.ShortcutsEnabled = true;
            this.txtAutor.Size = new System.Drawing.Size(121, 23);
            this.txtAutor.TabIndex = 7;
            this.txtAutor.UseSelectable = true;
            this.txtAutor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAutor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(356, 347);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Consejo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 170);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(103, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(191, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarConsejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnlAgregarEditar);
            this.Controls.Add(this.grdConsejos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarConsejo";
            this.Text = "FormAgregarConsejo";
            ((System.ComponentModel.ISupportInitialize)(this.adviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsejos)).EndInit();
            this.pnlAgregarEditar.ResumeLayout(false);
            this.pnlAgregarEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.BindingSource adviceBindingSource;
        private MetroFramework.Controls.MetroGrid grdConsejos;
        private MetroFramework.Controls.MetroPanel pnlAgregarEditar;
        private MetroFramework.Controls.MetroLabel lblTexto;
        private MetroFramework.Controls.MetroLabel lblId;
        private System.Windows.Forms.Button btnEditar;
        private MetroFramework.Controls.MetroLabel lblAutor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private MetroFramework.Controls.MetroTextBox txtAutor;
        private MetroFramework.Controls.MetroTextBox txtTexto;
        private MetroFramework.Controls.MetroTextBox txtId;
        private System.Windows.Forms.Button btnAgregar;
    }
}