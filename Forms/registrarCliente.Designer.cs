
namespace PI_Grupo2
{
    partial class frmRegistrarCliente
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
            chkApto = new CheckBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            dtpFechaNac = new DateTimePicker();
            txtTelefono = new TextBox();
            cboGenero = new ComboBox();
            btnRegistrarSocio = new Button();
            btnVolver = new Button();
            lblDomicilio = new Label();
            txtDomicilio = new TextBox();
            label1 = new Label();
            btnRegistrarNoSocio = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(45, 139);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 17);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(368, 139);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(59, 17);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(45, 184);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(33, 17);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNac.Location = new Point(368, 185);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(133, 17);
            lblFechaNac.TabIndex = 3;
            lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenero.Location = new Point(45, 281);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(51, 17);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Género";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(368, 282);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(61, 17);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // chkApto
            // 
            chkApto.AutoSize = true;
            chkApto.CheckAlign = ContentAlignment.MiddleRight;
            chkApto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkApto.Location = new Point(45, 92);
            chkApto.Margin = new Padding(3, 2, 3, 2);
            chkApto.Name = "chkApto";
            chkApto.Size = new Size(142, 21);
            chkApto.TabIndex = 9;
            chkApto.Text = "Presenta apto físico";
            chkApto.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 136);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(239, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(431, 136);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.MaxLength = 20;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 23);
            txtApellido.TabIndex = 11;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(111, 181);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.MaxLength = 10;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(239, 23);
            txtDni.TabIndex = 12;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(506, 182);
            dtpFechaNac.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNac.MaxDate = new DateTime(2017, 1, 1, 0, 0, 0, 0);
            dtpFechaNac.MinDate = new DateTime(1949, 12, 1, 0, 0, 0, 0);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(178, 23);
            dtpFechaNac.TabIndex = 14;
            dtpFechaNac.Value = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(431, 279);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.MaxLength = 12;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(253, 23);
            txtTelefono.TabIndex = 15;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Items.AddRange(new object[] { "Femenino", "Masculino", "Otro" });
            cboGenero.Location = new Point(111, 278);
            cboGenero.Margin = new Padding(3, 2, 3, 2);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(239, 23);
            cboGenero.TabIndex = 16;
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.BackColor = Color.FromArgb(255, 192, 128);
            btnRegistrarSocio.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarSocio.ForeColor = Color.Black;
            btnRegistrarSocio.Location = new Point(553, 392);
            btnRegistrarSocio.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(131, 51);
            btnRegistrarSocio.TabIndex = 17;
            btnRegistrarSocio.Text = "REGISTRAR SOCIO";
            btnRegistrarSocio.UseVisualStyleBackColor = false;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Salmon;
            btnVolver.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(45, 398);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 45);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDomicilio.Location = new Point(45, 231);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(65, 17);
            lblDomicilio.TabIndex = 19;
            lblDomicilio.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(112, 228);
            txtDomicilio.Margin = new Padding(3, 2, 3, 2);
            txtDomicilio.MaxLength = 50;
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(572, 23);
            txtDomicilio.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 27);
            label1.Name = "label1";
            label1.Size = new Size(479, 40);
            label1.TabIndex = 22;
            label1.Text = "Registro de Nuevo Cliente";
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = Color.FromArgb(255, 192, 128);
            btnRegistrarNoSocio.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarNoSocio.Location = new Point(380, 392);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(132, 51);
            btnRegistrarNoSocio.TabIndex = 23;
            btnRegistrarNoSocio.Text = "REGISTRAR NO SOCIO";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // frmRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(741, 489);
            Controls.Add(btnRegistrarNoSocio);
            Controls.Add(label1);
            Controls.Add(txtDomicilio);
            Controls.Add(lblDomicilio);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(cboGenero);
            Controls.Add(txtTelefono);
            Controls.Add(dtpFechaNac);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(chkApto);
            Controls.Add(lblTelefono);
            Controls.Add(lblGenero);
            Controls.Add(lblFechaNac);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegistrarCliente";
            RightToLeft = RightToLeft.No;
            Text = "REGISTRO DE CLIENTE";
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
        private CheckBox chkApto;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private DateTimePicker dtpFechaNac;
        private TextBox txtTelefono;
        private ComboBox cboGenero;
        private Button btnRegistrarSocio;
        private Button btnVolver;
        private Label lblDomicilio;
        private TextBox txtDomicilio;
        private Label label1;
        private Button btnRegistrarNoSocio;
    }
}