namespace PI_Grupo2.Forms
{
    partial class frmComprobante
    {
        private System.ComponentModel.IContainer components = null;

        // Liberar recursos usados
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSocio = new Label();
            lblCarnet = new Label();
            lblPago = new Label();
            lblVencimiento = new Label();
            lblImporte = new Label();
            lblMetodo = new Label();
            lblCuotas = new Label();
            lblComprobante = new Label();
            btnImprimir = new Button();
            pnlCabecera = new Panel();
            label1 = new Label();
            lblClub = new Label();
            pbLogo = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSocio.Location = new Point(17, 12);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(43, 17);
            lblSocio.TabIndex = 1;
            lblSocio.Text = "Socio:";
            // 
            // lblCarnet
            // 
            lblCarnet.AutoSize = true;
            lblCarnet.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarnet.Location = new Point(18, 38);
            lblCarnet.Name = "lblCarnet";
            lblCarnet.Size = new Size(76, 17);
            lblCarnet.TabIndex = 2;
            lblCarnet.Text = "Nro Carnet:";
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
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVencimiento.Location = new Point(18, 68);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(136, 17);
            lblVencimiento.TabIndex = 4;
            lblVencimiento.Text = "Fecha de vencimiento:";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblImporte.Location = new Point(313, 12);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(57, 17);
            lblImporte.TabIndex = 5;
            lblImporte.Text = "Importe:";
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMetodo.Location = new Point(313, 38);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(112, 17);
            lblMetodo.TabIndex = 6;
            lblMetodo.Text = "Método de pago:";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuotas.Location = new Point(313, 68);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(124, 17);
            lblCuotas.TabIndex = 7;
            lblCuotas.Text = "Cantidad de cuotas:";
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComprobante.Location = new Point(16, 13);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(128, 17);
            lblComprobante.TabIndex = 8;
            lblComprobante.Text = "N° de comprobante:";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(255, 192, 128);
            btnImprimir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(198, 285);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(167, 48);
            btnImprimir.TabIndex = 9;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.WhiteSmoke;
            pnlCabecera.Controls.Add(label1);
            pnlCabecera.Controls.Add(lblClub);
            pnlCabecera.Controls.Add(pbLogo);
            pnlCabecera.Controls.Add(lblTitulo);
            pnlCabecera.Location = new Point(20, 12);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(530, 109);
            pnlCabecera.TabIndex = 10;
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
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblSocio);
            panel1.Controls.Add(lblCarnet);
            panel1.Controls.Add(lblCuotas);
            panel1.Controls.Add(lblVencimiento);
            panel1.Controls.Add(lblMetodo);
            panel1.Controls.Add(lblImporte);
            panel1.Location = new Point(20, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 101);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(lblComprobante);
            panel2.Controls.Add(lblPago);
            panel2.Location = new Point(21, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 43);
            panel2.TabIndex = 12;
            // 
            // frmComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 345);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlCabecera);
            Controls.Add(btnImprimir);
            Name = "frmComprobante";
            Text = "COMPROBANTE DE PAGO";
            Load += frmComprobante_Load;
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSocio;
        private Label lblCarnet;
        private Label lblPago;
        private Label lblVencimiento;
        private Label lblImporte;
        private Label lblMetodo;
        private Label lblCuotas;
        private Label lblComprobante;
        private Button btnImprimir;
        private Panel pnlCabecera;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pbLogo;
        private Label label1;
        private Label lblClub;
    }
}
