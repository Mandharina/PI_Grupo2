namespace PI_Grupo2
{
    partial class registrarCliente
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblFechaNac = new Label();
            lblGenero = new Label();
            lblTelefono = new Label();
            chkSocio = new CheckBox();
            chkApto = new CheckBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            dtpFechaNac = new DateTimePicker();
            txtTelefono = new TextBox();
            cboGenero = new ComboBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(49, 54);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(416, 54);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(49, 113);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 20);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(416, 113);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(152, 20);
            lblFechaNac.TabIndex = 3;
            lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(49, 176);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(57, 20);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Género";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(416, 176);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            lblTelefono.Click += label6_Click;
            // 
            // chkSocio
            // 
            chkSocio.AutoSize = true;
            chkSocio.CheckAlign = ContentAlignment.MiddleRight;
            chkSocio.Location = new Point(416, 245);
            chkSocio.Name = "chkSocio";
            chkSocio.Size = new Size(171, 24);
            chkSocio.TabIndex = 8;
            chkSocio.Text = "Registrar como socio";
            chkSocio.UseVisualStyleBackColor = true;
            // 
            // chkApto
            // 
            chkApto.AutoSize = true;
            chkApto.CheckAlign = ContentAlignment.MiddleRight;
            chkApto.Location = new Point(40, 245);
            chkApto.Name = "chkApto";
            chkApto.Size = new Size(161, 24);
            chkApto.TabIndex = 9;
            chkApto.Text = "Presenta apto físico";
            chkApto.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(273, 27);
            txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(488, 47);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(278, 27);
            txtApellido.TabIndex = 11;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(122, 106);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(273, 27);
            txtDni.TabIndex = 12;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(574, 108);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(136, 27);
            dtpFechaNac.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(493, 169);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(273, 27);
            txtTelefono.TabIndex = 15;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(122, 168);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(273, 28);
            cboGenero.TabIndex = 16;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(255, 192, 128);
            btnRegistrar.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(276, 334);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(189, 68);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // registrarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(cboGenero);
            Controls.Add(txtTelefono);
            Controls.Add(dtpFechaNac);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(chkApto);
            Controls.Add(chkSocio);
            Controls.Add(lblTelefono);
            Controls.Add(lblGenero);
            Controls.Add(lblFechaNac);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "registrarCliente";
            Text = "registrarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblFechaNac;
        private Label lblGenero;
        private Label lblTelefono;
        private CheckBox chkSocio;
        private CheckBox chkApto;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private DateTimePicker dtpFechaNac;
        private TextBox txtTelefono;
        private ComboBox cboGenero;
        private Button btnRegistrar;
    }
}