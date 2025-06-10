namespace PI_Grupo2.Forms
{
    partial class frmPagos
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
            btnPagarCuota = new Button();
            btnPagarActividad = new Button();
            lblPagos = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = Color.FromArgb(255, 192, 128);
            btnPagarCuota.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagarCuota.Location = new Point(42, 115);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(253, 86);
            btnPagarCuota.TabIndex = 0;
            btnPagarCuota.Text = "PAGAR CUOTA";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnPagarActividad
            // 
            btnPagarActividad.BackColor = Color.FromArgb(255, 192, 128);
            btnPagarActividad.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagarActividad.Location = new Point(344, 115);
            btnPagarActividad.Name = "btnPagarActividad";
            btnPagarActividad.Size = new Size(253, 86);
            btnPagarActividad.TabIndex = 1;
            btnPagarActividad.Text = "PAGAR ACTIVIDAD";
            btnPagarActividad.UseVisualStyleBackColor = false;
            // 
            // lblPagos
            // 
            lblPagos.AutoSize = true;
            lblPagos.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagos.Location = new Point(42, 29);
            lblPagos.Name = "lblPagos";
            lblPagos.Size = new Size(413, 40);
            lblPagos.TabIndex = 2;
            lblPagos.Text = "REGISTRO DE PAGOS";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Salmon;
            btnVolver.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(42, 249);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 45);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // frmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(641, 329);
            Controls.Add(btnVolver);
            Controls.Add(lblPagos);
            Controls.Add(btnPagarActividad);
            Controls.Add(btnPagarCuota);
            Name = "frmPagos";
            Text = "Pagos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPagarCuota;
        private Button btnPagarActividad;
        private Label lblPagos;
        private Button btnVolver;
    }
}