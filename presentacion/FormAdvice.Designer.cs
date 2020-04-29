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
            this.lblConsejos = new System.Windows.Forms.Label();
            this.btnCierre = new System.Windows.Forms.Button();
            this.btnGenerarConsejo = new System.Windows.Forms.Label();
            this.btnAgregarConsejo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConsejos
            // 
            this.lblConsejos.AutoSize = true;
            this.lblConsejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsejos.Location = new System.Drawing.Point(48, 40);
            this.lblConsejos.Name = "lblConsejos";
            this.lblConsejos.Size = new System.Drawing.Size(225, 55);
            this.lblConsejos.TabIndex = 0;
            this.lblConsejos.Text = "Consejos";
            // 
            // btnCierre
            // 
            this.btnCierre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierre.Location = new System.Drawing.Point(592, 450);
            this.btnCierre.Margin = new System.Windows.Forms.Padding(2);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(56, 19);
            this.btnCierre.TabIndex = 3;
            this.btnCierre.Text = "Salir";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // btnGenerarConsejo
            // 
            this.btnGenerarConsejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarConsejo.Location = new System.Drawing.Point(51, 139);
            this.btnGenerarConsejo.Name = "btnGenerarConsejo";
            this.btnGenerarConsejo.Size = new System.Drawing.Size(468, 259);
            this.btnGenerarConsejo.TabIndex = 4;
            this.btnGenerarConsejo.Text = "Click Aquí para generar un consejo aleatorio";
            // 
            // btnAgregarConsejo
            // 
            this.btnAgregarConsejo.BackColor = System.Drawing.Color.White;
            this.btnAgregarConsejo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarConsejo.Location = new System.Drawing.Point(58, 433);
            this.btnAgregarConsejo.Name = "btnAgregarConsejo";
            this.btnAgregarConsejo.Size = new System.Drawing.Size(421, 36);
            this.btnAgregarConsejo.TabIndex = 5;
            this.btnAgregarConsejo.Text = "Quieres agregar un Consejo? Click Aquí";
            this.btnAgregarConsejo.UseVisualStyleBackColor = false;
            this.btnAgregarConsejo.Click += new System.EventHandler(this.btnAgregarConsejo_Click);
            // 
            // frmAdvice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 480);
            this.Controls.Add(this.btnAgregarConsejo);
            this.Controls.Add(this.btnGenerarConsejo);
            this.Controls.Add(this.btnCierre);
            this.Controls.Add(this.lblConsejos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAdvice";
            this.Text = "FormAdvice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsejos;
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Label btnGenerarConsejo;
        private System.Windows.Forms.Button btnAgregarConsejo;
    }    
}