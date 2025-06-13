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
            pnlCarnet.Location = new Point(20, 20);
            pnlCarnet.Name = "pnlCarnet";
            pnlCarnet.Size = new Size(346, 190);
            pnlCarnet.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(192, 156);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(79, 13);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha de alta: ";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(26, 136);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 16);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(25, 109);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 16);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblNroCarnet
            // 
            lblNroCarnet.AutoSize = true;
            lblNroCarnet.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroCarnet.Location = new Point(25, 56);
            lblNroCarnet.Name = "lblNroCarnet";
            lblNroCarnet.Size = new Size(78, 16);
            lblNroCarnet.TabIndex = 3;
            lblNroCarnet.Text = "NRO: ####";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(21, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 19);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "CARNET DE SOCIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_club;
            pictureBox1.InitialImage = Properties.Resources.logo_club;
            pictureBox1.Location = new Point(192, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(443, 111);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 242);
            Controls.Add(btnImprimir);
            Controls.Add(pnlCarnet);
            Name = "frmCarnet";
            Text = "frmCarnet";
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