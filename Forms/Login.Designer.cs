namespace PI_Grupo2
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMensajeBienvenida = new Label();
            btnIngresar = new Button();
            lblUsuario = new Label();
            lblPassword = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblMensajeBienvenida
            // 
            lblMensajeBienvenida.AutoSize = true;
            lblMensajeBienvenida.BackColor = Color.Transparent;
            lblMensajeBienvenida.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensajeBienvenida.ForeColor = Color.Black;
            lblMensajeBienvenida.Location = new Point(93, 38);
            lblMensajeBienvenida.Name = "lblMensajeBienvenida";
            lblMensajeBienvenida.Size = new Size(233, 40);
            lblMensajeBienvenida.TabIndex = 0;
            lblMensajeBienvenida.Text = "Bienvenidos";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(255, 192, 128);
            btnIngresar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(139, 222);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(167, 48);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(38, 112);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(60, 17);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(21, 160);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 17);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(112, 109);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(229, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.Text = "Ingresá tu usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(112, 157);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 23);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "Ingresá tu contraseña";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo_club;
            picLogo.Location = new Point(404, 38);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(285, 238);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(700, 338);
            Controls.Add(picLogo);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblMensajeBienvenida);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "PÁGINA DE INICIO";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensajeBienvenida;
        private Button btnIngresar;
        private Label lblUsuario;
        private Label lblPassword;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private PictureBox picLogo;
    }
}
