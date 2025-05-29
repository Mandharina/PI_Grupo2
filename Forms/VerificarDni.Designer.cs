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
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(148, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(421, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Verificación de Cliente";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(205, 117);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(85, 19);
            lblDni.TabIndex = 1;
            lblDni.Text = "Ingrese DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(296, 116);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(219, 23);
            txtDni.TabIndex = 2;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(255, 192, 128);
            btnVerificar.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerificar.Location = new Point(257, 170);
            btnVerificar.Margin = new Padding(3, 2, 3, 2);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(219, 34);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // frmVerificarDni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(700, 300);
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
    }
}
