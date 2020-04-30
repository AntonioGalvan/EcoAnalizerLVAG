namespace presentacion
{
    partial class frmExperto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdExpertos = new MetroFramework.Controls.MetroGrid();
            this.pnlExpert = new MetroFramework.Controls.MetroPanel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.lblApellidos = new MetroFramework.Controls.MetroLabel();
            this.txtApellidos = new MetroFramework.Controls.MetroTextBox();
            this.lblEdad = new MetroFramework.Controls.MetroLabel();
            this.txtEdad = new MetroFramework.Controls.MetroTextBox();
            this.lblCiudad = new MetroFramework.Controls.MetroLabel();
            this.lblGrado = new MetroFramework.Controls.MetroLabel();
            this.txtGrado = new MetroFramework.Controls.MetroTextBox();
            this.txtCiudad = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.ptrExpert = new System.Windows.Forms.PictureBox();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.expertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpertos)).BeginInit();
            this.pnlExpert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrExpert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdExpertos
            // 
            this.grdExpertos.AllowUserToResizeRows = false;
            this.grdExpertos.AutoGenerateColumns = false;
            this.grdExpertos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdExpertos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdExpertos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdExpertos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExpertos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdExpertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.usersDataGridViewTextBoxColumn,
            this.testsDataGridViewTextBoxColumn});
            this.grdExpertos.DataSource = this.expertBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdExpertos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdExpertos.EnableHeadersVisualStyles = false;
            this.grdExpertos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdExpertos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdExpertos.Location = new System.Drawing.Point(23, 63);
            this.grdExpertos.Name = "grdExpertos";
            this.grdExpertos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExpertos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdExpertos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdExpertos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExpertos.Size = new System.Drawing.Size(343, 150);
            this.grdExpertos.TabIndex = 0;
            this.grdExpertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // pnlExpert
            // 
            this.pnlExpert.Controls.Add(this.btnBuscar);
            this.pnlExpert.Controls.Add(this.btnGuardar);
            this.pnlExpert.Controls.Add(this.btnEliminar);
            this.pnlExpert.Controls.Add(this.btnEditar);
            this.pnlExpert.Controls.Add(this.lblApellidos);
            this.pnlExpert.Controls.Add(this.txtApellidos);
            this.pnlExpert.Controls.Add(this.lblEdad);
            this.pnlExpert.Controls.Add(this.txtEdad);
            this.pnlExpert.Controls.Add(this.lblCiudad);
            this.pnlExpert.Controls.Add(this.lblGrado);
            this.pnlExpert.Controls.Add(this.txtGrado);
            this.pnlExpert.Controls.Add(this.txtCiudad);
            this.pnlExpert.Controls.Add(this.lblNombre);
            this.pnlExpert.Controls.Add(this.txtNombre);
            this.pnlExpert.Controls.Add(this.ptrExpert);
            this.pnlExpert.HorizontalScrollbarBarColor = true;
            this.pnlExpert.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlExpert.HorizontalScrollbarSize = 10;
            this.pnlExpert.Location = new System.Drawing.Point(400, 63);
            this.pnlExpert.Name = "pnlExpert";
            this.pnlExpert.Size = new System.Drawing.Size(377, 214);
            this.pnlExpert.TabIndex = 1;
            this.pnlExpert.VerticalScrollbarBarColor = true;
            this.pnlExpert.VerticalScrollbarHighlightOnWheel = false;
            this.pnlExpert.VerticalScrollbarSize = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(23, 141);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(289, 182);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(106, 182);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(196, 182);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(400, 293);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(142, 47);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(63, 19);
            this.lblApellidos.TabIndex = 14;
            this.lblApellidos.Text = "Apellidos";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtApellidos
            // 
            // 
            // 
            // 
            this.txtApellidos.CustomButton.Image = null;
            this.txtApellidos.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtApellidos.CustomButton.Name = "";
            this.txtApellidos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellidos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellidos.CustomButton.TabIndex = 1;
            this.txtApellidos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellidos.CustomButton.UseSelectable = true;
            this.txtApellidos.CustomButton.Visible = false;
            this.txtApellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertBindingSource, "LastName", true));
            this.txtApellidos.Lines = new string[0];
            this.txtApellidos.Location = new System.Drawing.Point(241, 43);
            this.txtApellidos.MaxLength = 32767;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.ShortcutsEnabled = true;
            this.txtApellidos.Size = new System.Drawing.Size(133, 23);
            this.txtApellidos.TabIndex = 13;
            this.txtApellidos.UseSelectable = true;
            this.txtApellidos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellidos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidos.Click += new System.EventHandler(this.txtApellidos_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(142, 76);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(39, 19);
            this.lblEdad.TabIndex = 12;
            this.lblEdad.Text = "Edad";
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEdad
            // 
            // 
            // 
            // 
            this.txtEdad.CustomButton.Image = null;
            this.txtEdad.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtEdad.CustomButton.Name = "";
            this.txtEdad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEdad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEdad.CustomButton.TabIndex = 1;
            this.txtEdad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEdad.CustomButton.UseSelectable = true;
            this.txtEdad.CustomButton.Visible = false;
            this.txtEdad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertBindingSource, "Age", true));
            this.txtEdad.Lines = new string[0];
            this.txtEdad.Location = new System.Drawing.Point(241, 72);
            this.txtEdad.MaxLength = 32767;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEdad.SelectedText = "";
            this.txtEdad.SelectionLength = 0;
            this.txtEdad.SelectionStart = 0;
            this.txtEdad.ShortcutsEnabled = true;
            this.txtEdad.Size = new System.Drawing.Size(133, 23);
            this.txtEdad.TabIndex = 11;
            this.txtEdad.UseSelectable = true;
            this.txtEdad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEdad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(142, 105);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(51, 19);
            this.lblCiudad.TabIndex = 10;
            this.lblCiudad.Text = "Ciudad";
            this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCiudad.Click += new System.EventHandler(this.lblCiudad_Click);
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(142, 135);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(46, 19);
            this.lblGrado.TabIndex = 8;
            this.lblGrado.Text = "Grado";
            this.lblGrado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGrado
            // 
            // 
            // 
            // 
            this.txtGrado.CustomButton.Image = null;
            this.txtGrado.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtGrado.CustomButton.Name = "";
            this.txtGrado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGrado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrado.CustomButton.TabIndex = 1;
            this.txtGrado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrado.CustomButton.UseSelectable = true;
            this.txtGrado.CustomButton.Visible = false;
            this.txtGrado.Lines = new string[0];
            this.txtGrado.Location = new System.Drawing.Point(241, 131);
            this.txtGrado.MaxLength = 32767;
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.PasswordChar = '\0';
            this.txtGrado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrado.SelectedText = "";
            this.txtGrado.SelectionLength = 0;
            this.txtGrado.SelectionStart = 0;
            this.txtGrado.ShortcutsEnabled = true;
            this.txtGrado.Size = new System.Drawing.Size(133, 23);
            this.txtGrado.TabIndex = 7;
            this.txtGrado.UseSelectable = true;
            this.txtGrado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCiudad
            // 
            // 
            // 
            // 
            this.txtCiudad.CustomButton.Image = null;
            this.txtCiudad.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtCiudad.CustomButton.Name = "";
            this.txtCiudad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCiudad.CustomButton.TabIndex = 1;
            this.txtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCiudad.CustomButton.UseSelectable = true;
            this.txtCiudad.CustomButton.Visible = false;
            this.txtCiudad.Lines = new string[0];
            this.txtCiudad.Location = new System.Drawing.Point(241, 101);
            this.txtCiudad.MaxLength = 32767;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.PasswordChar = '\0';
            this.txtCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCiudad.SelectedText = "";
            this.txtCiudad.SelectionLength = 0;
            this.txtCiudad.SelectionStart = 0;
            this.txtCiudad.ShortcutsEnabled = true;
            this.txtCiudad.Size = new System.Drawing.Size(133, 23);
            this.txtCiudad.TabIndex = 5;
            this.txtCiudad.UseSelectable = true;
            this.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCiudad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(142, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertBindingSource, "Name", true));
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(241, 15);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(133, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // ptrExpert
            // 
            this.ptrExpert.Location = new System.Drawing.Point(12, 15);
            this.ptrExpert.Name = "ptrExpert";
            this.ptrExpert.Size = new System.Drawing.Size(100, 120);
            this.ptrExpert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrExpert.TabIndex = 2;
            this.ptrExpert.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(689, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // expertBindingSource
            // 
            this.expertBindingSource.DataSource = typeof(presentacion.Data.Expert);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Degree";
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            // 
            // usersDataGridViewTextBoxColumn
            // 
            this.usersDataGridViewTextBoxColumn.DataPropertyName = "Users";
            this.usersDataGridViewTextBoxColumn.HeaderText = "Users";
            this.usersDataGridViewTextBoxColumn.Name = "usersDataGridViewTextBoxColumn";
            this.usersDataGridViewTextBoxColumn.Visible = false;
            // 
            // testsDataGridViewTextBoxColumn
            // 
            this.testsDataGridViewTextBoxColumn.DataPropertyName = "Tests";
            this.testsDataGridViewTextBoxColumn.HeaderText = "Tests";
            this.testsDataGridViewTextBoxColumn.Name = "testsDataGridViewTextBoxColumn";
            this.testsDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmExperto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlExpert);
            this.Controls.Add(this.grdExpertos);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmExperto";
            this.Text = "FormExperto";
            this.Load += new System.EventHandler(this.frmExperto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdExpertos)).EndInit();
            this.pnlExpert.ResumeLayout(false);
            this.pnlExpert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrExpert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdExpertos;
        private System.Windows.Forms.BindingSource expertBindingSource;
        private MetroFramework.Controls.MetroPanel pnlExpert;
        private MetroFramework.Controls.MetroLabel lblApellidos;
        private MetroFramework.Controls.MetroTextBox txtApellidos;
        private MetroFramework.Controls.MetroLabel lblEdad;
        private MetroFramework.Controls.MetroTextBox txtEdad;
        private MetroFramework.Controls.MetroLabel lblCiudad;
        private MetroFramework.Controls.MetroLabel lblGrado;
        private MetroFramework.Controls.MetroTextBox txtGrado;
        private MetroFramework.Controls.MetroTextBox txtCiudad;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private System.Windows.Forms.PictureBox ptrExpert;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testsDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnBuscar;
    }
}