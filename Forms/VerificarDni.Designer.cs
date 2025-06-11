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
            lblTitulo.Location = new Point(43, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(338, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Validación de DNI";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(43, 99);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(150, 19);
            lblDni.TabIndex = 1;
            lblDni.Text = "Ingrese DNI del cliente:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(199, 97);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(219, 23);
            txtDni.TabIndex = 2;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(255, 192, 128);
            btnVerificar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerificar.Location = new Point(410, 158);
            btnVerificar.Margin = new Padding(3, 2, 3, 2);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(253, 48);
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
            btnVolver.Location = new Point(43, 161);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 45);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmVerificarDni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(700, 246);
            Controls.Add(btnVolver);
            Controls.Add(btnVerificar);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmVerificarDni";
            Text = "Verificación de Cliente";
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
