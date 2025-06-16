namespace PI_Grupo2.Forms
{
    partial class frmCarnet
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
            pnlCarnet = new Panel();
            lblFecha = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblNroCarnet = new Label();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            btnImprimir = new Button();
            pnlCarnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlCarnet
            // 
            pnlCarnet.BackColor = Color.WhiteSmoke;
            pnlCarnet.BorderStyle = BorderStyle.FixedSingle;
            pnlCarnet.Controls.Add(lblFecha);
            pnlCarnet.Controls.Add(lblApellido);
            pnlCarnet.Controls.Add(lblNombre);
            pnlCarnet.Controls.Add(lblNroCarnet);
            pnlCarnet.Controls.Add(lblTitulo);
            pnlCarnet.Controls.Add(pictureBox1);
            pnlCarnet.Location = new Point(44, 12);
            pnlCarnet.Name = "pnlCarnet";
            pnlCarnet.Size = new Size(441, 219);
            pnlCarnet.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(252, 183);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(79, 13);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha de alta: ";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(25, 161);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 19);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(24, 134);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(66, 19);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblNroCarnet
            // 
            lblNroCarnet.AutoSize = true;
            lblNroCarnet.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroCarnet.Location = new Point(25, 60);
            lblNroCarnet.Name = "lblNroCarnet";
            lblNroCarnet.Size = new Size(108, 19);
            lblNroCarnet.TabIndex = 3;
            lblNroCarnet.Text = "NRO: ####";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(21, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(199, 21);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "CARNET DE SOCIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_club;
            pictureBox1.InitialImage = Properties.Resources.logo_club;
            pictureBox1.Location = new Point(252, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(255, 192, 128);
            btnImprimir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(183, 243);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(167, 48);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 303);
            Controls.Add(btnImprimir);
            Controls.Add(pnlCarnet);
            Name = "frmCarnet";
            Text = "EMISIÓN DE CARNET";
            Load += frmCarnet_Load;
            pnlCarnet.ResumeLayout(false);
            pnlCarnet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCarnet;
        private PictureBox pictureBox1;
        private Label lblNroCarnet;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblFecha;
        private Label lblApellido;
        private Button btnImprimir;
    }
}