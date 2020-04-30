namespace presentacion
{
    partial class frmAdvice
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
            this.lblConsejos = new System.Windows.Forms.Label();
            this.btnGenerarConsejo = new System.Windows.Forms.Label();
            this.btnAgregarConsejo = new System.Windows.Forms.Button();
            this.btnCierre = new System.Windows.Forms.Button();
            this.adviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsejos
            // 
            this.lblConsejos.AutoSize = true;
            this.lblConsejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsejos.Location = new System.Drawing.Point(51, 44);
            this.lblConsejos.Name = "lblConsejos";
            this.lblConsejos.Size = new System.Drawing.Size(225, 55);
            this.lblConsejos.TabIndex = 1;
            this.lblConsejos.Text = "Consejos";
            // 
            // btnGenerarConsejo
            // 
            this.btnGenerarConsejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarConsejo.Location = new System.Drawing.Point(54, 121);
            this.btnGenerarConsejo.Name = "btnGenerarConsejo";
            this.btnGenerarConsejo.Size = new System.Drawing.Size(468, 259);
            this.btnGenerarConsejo.TabIndex = 5;
            this.btnGenerarConsejo.Text = "Click Aquí para generar un consejo aleatorio";
            this.btnGenerarConsejo.Click += new System.EventHandler(this.btnGenerarConsejo_Click);
            // 
            // btnAgregarConsejo
            // 
            this.btnAgregarConsejo.BackColor = System.Drawing.Color.White;
            this.btnAgregarConsejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarConsejo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarConsejo.Location = new System.Drawing.Point(61, 432);
            this.btnAgregarConsejo.Name = "btnAgregarConsejo";
            this.btnAgregarConsejo.Size = new System.Drawing.Size(421, 36);
            this.btnAgregarConsejo.TabIndex = 6;
            this.btnAgregarConsejo.Text = "¿Quieres agregar un Consejo? Click Aquí";
            this.btnAgregarConsejo.UseVisualStyleBackColor = false;
            this.btnAgregarConsejo.Click += new System.EventHandler(this.btnAgregarConsejo_Click);
            // 
            // btnCierre
            // 
            this.btnCierre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierre.Location = new System.Drawing.Point(592, 449);
            this.btnCierre.Margin = new System.Windows.Forms.Padding(2);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(56, 19);
            this.btnCierre.TabIndex = 7;
            this.btnCierre.Text = "Salir";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // adviceBindingSource
            // 
            this.adviceBindingSource.DataSource = typeof(presentacion.Data.Advice);
            // 
            // frmAdvice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 480);
            this.Controls.Add(this.btnCierre);
            this.Controls.Add(this.btnAgregarConsejo);
            this.Controls.Add(this.btnGenerarConsejo);
            this.Controls.Add(this.lblConsejos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdvice";
            this.Text = "FormAdvice";
            ((System.ComponentModel.ISupportInitialize)(this.adviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsejos;
        private System.Windows.Forms.Label btnGenerarConsejo;
        private System.Windows.Forms.Button btnAgregarConsejo;
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.BindingSource adviceBindingSource;
    }
}