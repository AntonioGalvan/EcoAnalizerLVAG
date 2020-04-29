namespace presentacion
{
    partial class FormExpert
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
            this.grdExpert = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlExpert = new MetroFramework.Controls.MetroPanel();
            this.lblEdad = new MetroFramework.Controls.MetroLabel();
            this.lblCiudad = new MetroFramework.Controls.MetroLabel();
            this.lblGrado = new MetroFramework.Controls.MetroLabel();
            this.lblApellidoMaterno = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.ptrExpert = new System.Windows.Forms.PictureBox();
            this.txtApellidos = new MetroFramework.Controls.MetroTextBox();
            this.txtGradoEstudiantil = new MetroFramework.Controls.MetroTextBox();
            this.txtCiudad = new MetroFramework.Controls.MetroTextBox();
            this.txtEdad = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertBindingSource)).BeginInit();
            this.pnlExpert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrExpert)).BeginInit();
            this.SuspendLayout();
            // 
            // grdExpert
            // 
            this.grdExpert.AllowUserToResizeRows = false;
            this.grdExpert.AutoGenerateColumns = false;
            this.grdExpert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdExpert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdExpert.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdExpert.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExpert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdExpert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.usersDataGridViewTextBoxColumn,
            this.testsDataGridViewTextBoxColumn});
            this.grdExpert.DataSource = this.expertBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdExpert.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdExpert.EnableHeadersVisualStyles = false;
            this.grdExpert.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdExpert.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdExpert.Location = new System.Drawing.Point(9, 63);
            this.grdExpert.Name = "grdExpert";
            this.grdExpert.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExpert.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdExpert.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdExpert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExpert.Size = new System.Drawing.Size(247, 233);
            this.grdExpert.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // 
            // testsDataGridViewTextBoxColumn
            // 
            this.testsDataGridViewTextBoxColumn.DataPropertyName = "Tests";
            this.testsDataGridViewTextBoxColumn.HeaderText = "Tests";
            this.testsDataGridViewTextBoxColumn.Name = "testsDataGridViewTextBoxColumn";
            // 
            // expertBindingSource
            // 
            this.expertBindingSource.DataSource = typeof(presentacion.Data.Expert);
            // 
            // pnlExpert
            // 
            this.pnlExpert.Controls.Add(this.txtId);
            this.pnlExpert.Controls.Add(this.lblId);
            this.pnlExpert.Controls.Add(this.txtNombre);
            this.pnlExpert.Controls.Add(this.txtEdad);
            this.pnlExpert.Controls.Add(this.txtCiudad);
            this.pnlExpert.Controls.Add(this.txtGradoEstudiantil);
            this.pnlExpert.Controls.Add(this.txtApellidos);
            this.pnlExpert.Controls.Add(this.lblEdad);
            this.pnlExpert.Controls.Add(this.lblCiudad);
            this.pnlExpert.Controls.Add(this.lblGrado);
            this.pnlExpert.Controls.Add(this.lblApellidoMaterno);
            this.pnlExpert.Controls.Add(this.lblNombre);
            this.pnlExpert.Controls.Add(this.btnGuardar);
            this.pnlExpert.Controls.Add(this.btnEliminar);
            this.pnlExpert.Controls.Add(this.btnEditar);
            this.pnlExpert.Controls.Add(this.btnAgregar);
            this.pnlExpert.Controls.Add(this.ptrExpert);
            this.pnlExpert.HorizontalScrollbarBarColor = true;
            this.pnlExpert.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlExpert.HorizontalScrollbarSize = 10;
            this.pnlExpert.Location = new System.Drawing.Point(276, 50);
            this.pnlExpert.Name = "pnlExpert";
            this.pnlExpert.Size = new System.Drawing.Size(427, 274);
            this.pnlExpert.TabIndex = 1;
            this.pnlExpert.VerticalScrollbarBarColor = true;
            this.pnlExpert.VerticalScrollbarHighlightOnWheel = false;
            this.pnlExpert.VerticalScrollbarSize = 10;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(144, 121);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(39, 19);
            this.lblEdad.TabIndex = 13;
            this.lblEdad.Text = "Edad";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(144, 160);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(51, 19);
            this.lblCiudad.TabIndex = 12;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(144, 197);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(108, 19);
            this.lblGrado.TabIndex = 11;
            this.lblGrado.Text = "Grado Estudiantil";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(144, 54);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(63, 19);
            this.lblApellidoMaterno.TabIndex = 10;
            this.lblApellidoMaterno.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(144, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(349, 236);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(43, 236);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(198, 236);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 139);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            // 
            // ptrExpert
            // 
            this.ptrExpert.Location = new System.Drawing.Point(18, 13);
            this.ptrExpert.Name = "ptrExpert";
            this.ptrExpert.Size = new System.Drawing.Size(100, 120);
            this.ptrExpert.TabIndex = 2;
            this.ptrExpert.TabStop = false;
            // 
            // txtApellidos
            // 
            // 
            // 
            // 
            this.txtApellidos.CustomButton.Image = null;
            this.txtApellidos.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtApellidos.CustomButton.Name = "";
            this.txtApellidos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellidos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellidos.CustomButton.TabIndex = 1;
            this.txtApellidos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellidos.CustomButton.UseSelectable = true;
            this.txtApellidos.CustomButton.Visible = false;
            this.txtApellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertBindingSource, "LastName", true));
            this.txtApellidos.Lines = new string[0];
            this.txtApellidos.Location = new System.Drawing.Point(261, 50);
            this.txtApellidos.MaxLength = 32767;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.ShortcutsEnabled = true;
            this.txtApellidos.Size = new System.Drawing.Size(163, 23);
            this.txtApellidos.TabIndex = 14;
            this.txtApellidos.UseSelectable = true;
            this.txtApellidos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellidos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGradoEstudiantil
            // 
            // 
            // 
            // 
            this.txtGradoEstudiantil.CustomButton.Image = null;
            this.txtGradoEstudiantil.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtGradoEstudiantil.CustomButton.Name = "";
            this.txtGradoEstudiantil.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGradoEstudiantil.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGradoEstudiantil.CustomButton.TabIndex = 1;
            this.txtGradoEstudiantil.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGradoEstudiantil.CustomButton.UseSelectable = true;
            this.txtGradoEstudiantil.CustomButton.Visible = false;
            this.txtGradoEstudiantil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertBindingSource, "Degree", true));
            this.txtGradoEstudiantil.Lines = new string[0];
            this.txtGradoEstudiantil.Location = new System.Drawing.Point(261, 193);
            this.txtGradoEstudiantil.MaxLength = 32767;
            this.txtGradoEstudiantil.Name = "txtGradoEstudiantil";
            this.txtGradoEstudiantil.PasswordChar = '\0';
            this.txtGradoEstudiantil.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGradoEstudiantil.SelectedText = "";
            this.txtGradoEstudiantil.SelectionLength = 0;
            this.txtGradoEstudiantil.SelectionStart = 0;
            this.txtGradoEstudiantil.ShortcutsEnabled = true;
            this.txtGradoEstudiantil.Size = new System.Drawing.Size(163, 23);
            this.txtGradoEstudiantil.TabIndex = 15;
            this.txtGradoEstudiantil.UseSelectable = true;
            this.txtGradoEstudiantil.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGradoEstudiantil.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCiudad
            // 
            // 
            // 
            // 
            this.txtCiudad.CustomButton.Image = null;
            this.txtCiudad.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtCiudad.CustomButton.Name = "";
            this.txtCiudad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCiudad.CustomButton.TabIndex = 1;
            this.txtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCiudad.CustomButton.UseSelectable = true;
            this.txtCiudad.CustomButton.Visible = false;
            this.txtCiudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertBindingSource, "City", true));
            this.txtCiudad.Lines = new string[0];
            this.txtCiudad.Location = new System.Drawing.Point(261, 156);
            this.txtCiudad.MaxLength = 32767;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.PasswordChar = '\0';
            this.txtCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCiudad.SelectedText = "";
            this.txtCiudad.SelectionLength = 0;
            this.txtCiudad.SelectionStart = 0;
            this.txtCiudad.ShortcutsEnabled = true;
            this.txtCiudad.Size = new System.Drawing.Size(163, 23);
            this.txtCiudad.TabIndex = 16;
            this.txtCiudad.UseSelectable = true;
            this.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCiudad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEdad
            // 
            // 
            // 
            // 
            this.txtEdad.CustomButton.Image = null;
            this.txtEdad.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtEdad.CustomButton.Name = "";
            this.txtEdad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEdad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEdad.CustomButton.TabIndex = 1;
            this.txtEdad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEdad.CustomButton.UseSelectable = true;
            this.txtEdad.CustomButton.Visible = false;
            this.txtEdad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertBindingSource, "Age", true));
            this.txtEdad.Lines = new string[0];
            this.txtEdad.Location = new System.Drawing.Point(261, 117);
            this.txtEdad.MaxLength = 32767;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEdad.SelectedText = "";
            this.txtEdad.SelectionLength = 0;
            this.txtEdad.SelectionStart = 0;
            this.txtEdad.ShortcutsEnabled = true;
            this.txtEdad.Size = new System.Drawing.Size(163, 23);
            this.txtEdad.TabIndex = 17;
            this.txtEdad.UseSelectable = true;
            this.txtEdad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEdad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertBindingSource, "Name", true));
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(261, 82);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(163, 23);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(144, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expertBindingSource, "Id", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(261, 19);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(163, 23);
            this.txtId.TabIndex = 20;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormExpert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlExpert);
            this.Controls.Add(this.grdExpert);
            this.Name = "FormExpert";
            this.Text = "FormExpert";
            ((System.ComponentModel.ISupportInitialize)(this.grdExpert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertBindingSource)).EndInit();
            this.pnlExpert.ResumeLayout(false);
            this.pnlExpert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrExpert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdExpert;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource expertBindingSource;
        private MetroFramework.Controls.MetroPanel pnlExpert;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.PictureBox ptrExpert;
        private MetroFramework.Controls.MetroLabel lblEdad;
        private MetroFramework.Controls.MetroLabel lblCiudad;
        private MetroFramework.Controls.MetroLabel lblGrado;
        private MetroFramework.Controls.MetroLabel lblApellidoMaterno;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtEdad;
        private MetroFramework.Controls.MetroTextBox txtCiudad;
        private MetroFramework.Controls.MetroTextBox txtGradoEstudiantil;
        private MetroFramework.Controls.MetroTextBox txtApellidos;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
    }
}