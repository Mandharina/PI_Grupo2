namespace PI_Grupo2
{
    partial class frmPaginaInicio
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
            SuspendLayout();
            // 
            // lblMensajeBienvenida
            // 
            lblMensajeBienvenida.AutoSize = true;
            lblMensajeBienvenida.Location = new Point(327, 61);
            lblMensajeBienvenida.Name = "lblMensajeBienvenida";
            lblMensajeBienvenida.Size = new Size(89, 20);
            lblMensajeBienvenida.TabIndex = 0;
            lblMensajeBienvenida.Text = "Bienvenidos";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(274, 339);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(191, 64);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(133, 165);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(113, 220);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(249, 162);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(261, 27);
            txtUsuario.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(249, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(261, 27);
            txtPassword.TabIndex = 5;
            // 
            // frmPaginaInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblMensajeBienvenida);
            Name = "frmPaginaInicio";
            Text = "PÁGINA DE INICIO";
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
    }
}
