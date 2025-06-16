namespace PI_Grupo2.Forms
{
    partial class frmComprobanteActividad
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
            panel1 = new Panel();
            lblMetodo = new Label();
            lblImporte = new Label();
            lblCliente = new Label();
            lblNroCliente = new Label();
            lblActividad = new Label();
            pnlCabecera = new Panel();
            label1 = new Label();
            lblClub = new Label();
            pbLogo = new PictureBox();
            lblTitulo = new Label();
            panel2 = new Panel();
            lblComprobante = new Label();
            lblPago = new Label();
            btnImprimir = new Button();
            panel1.SuspendLayout();
            pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblMetodo);
            panel1.Controls.Add(lblImporte);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(lblNroCliente);
            panel1.Controls.Add(lblActividad);
            panel1.Location = new Point(30, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 112);
            panel1.TabIndex = 0;
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMetodo.Location = new Point(313, 75);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(161, 17);
            lblMetodo.TabIndex = 9;
            lblMetodo.Text = "Método de pago: Efectivo";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblImporte.Location = new Point(313, 46);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(57, 17);
            lblImporte.TabIndex = 8;
            lblImporte.Text = "Importe:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(16, 75);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(54, 17);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente: ";
            // 
            // lblNroCliente
            // 
            lblNroCliente.AutoSize = true;
            lblNroCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroCliente.Location = new Point(16, 46);
            lblNroCliente.Name = "lblNroCliente";
            lblNroCliente.Size = new Size(100, 17);
            lblNroCliente.TabIndex = 1;
            lblNroCliente.Text = "Nro de Cliente: ";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblActividad.Location = new Point(16, 16);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(68, 17);
            lblActividad.TabIndex = 0;
            lblActividad.Text = "Actividad: ";
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.WhiteSmoke;
            pnlCabecera.Controls.Add(label1);
            pnlCabecera.Controls.Add(lblClub);
            pnlCabecera.Controls.Add(pbLogo);
            pnlCabecera.Controls.Add(lblTitulo);
            pnlCabecera.Location = new Point(30, 22);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(530, 109);
            pnlCabecera.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(313, 53);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 3;
            label1.Text = "CUIT 30-10005425-0";
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClub.Location = new Point(132, 53);
            lblClub.Name = "lblClub";
            lblClub.Size = new Size(138, 21);
            lblClub.TabIndex = 2;
            lblClub.Text = "Club Deportivo C#";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo_club;
            pbLogo.Location = new Point(22, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(90, 86);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(132, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Comprobante de Pago";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(lblComprobante);
            panel2.Controls.Add(lblPago);
            panel2.Location = new Point(30, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 43);
            panel2.TabIndex = 13;
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComprobante.Location = new Point(16, 13);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(136, 17);
            lblComprobante.TabIndex = 8;
            lblComprobante.Text = "Nro de comprobante:";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPago.Location = new Point(312, 13);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(98, 17);
            lblPago.TabIndex = 3;
            lblPago.Text = "Fecha de pago:";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(255, 192, 128);
            btnImprimir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(200, 315);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(167, 48);
            btnImprimir.TabIndex = 14;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmComprobanteActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 389);
            Controls.Add(btnImprimir);
            Controls.Add(panel2);
            Controls.Add(pnlCabecera);
            Controls.Add(panel1);
            Name = "frmComprobanteActividad";
            Text = "frmComprobanteActividad";
            Load += frmComprobanteActividad_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlCabecera;
        private Label label1;
        private Label lblClub;
        private PictureBox pbLogo;
        private Label lblTitulo;
        private Panel panel2;
        private Label lblComprobante;
        private Label lblPago;
        private Label lblNroCliente;
        private Label lblActividad;
        private Button btnImprimir;
        private Label lblCliente;
        private Label lblMetodo;
        private Label lblImporte;
    }
}