namespace PI_Grupo2
{
    partial class frmVerificarDni
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblDni = new Label();
            txtDni = new TextBox();
            btnVerificar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(49, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(427, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Validación de DNI";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(49, 132);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(188, 23);
            lblDni.TabIndex = 1;
            lblDni.Text = "Ingrese DNI del cliente:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(227, 129);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(250, 27);
            txtDni.TabIndex = 2;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(255, 192, 128);
            btnVerificar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerificar.Location = new Point(469, 211);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(289, 64);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "VERIFICAR EXISTENCIA";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Salmon;
            btnVolver.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ActiveCaptionText;
            btnVolver.Location = new Point(49, 215);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(114, 60);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmVerificarDni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 328);
            Controls.Add(btnVolver);
            Controls.Add(btnVerificar);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(lblTitulo);
            Name = "frmVerificarDni";
            Text = "Verificación de Cliente";
            Load += frmVerificarDni_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDni;
        private TextBox txtDni;
        private Button btnVerificar;
        private Button btnVolver;
    }
}
