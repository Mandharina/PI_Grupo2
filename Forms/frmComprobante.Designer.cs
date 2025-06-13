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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(100, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 25);
            this.lblTitulo.Text = "Comprobante de Pago";

            // lblSocio
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(30, 70);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(50, 15);
            this.lblSocio.Text = "Socio:";

            // lblCarnet
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(30, 100);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(60, 15);
            this.lblCarnet.Text = "Carnet:";

            // lblPago
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(30, 130);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(105, 15);
            this.lblPago.Text = "Fecha de pago:";

            // lblVencimiento
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(30, 160);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(130, 15);
            this.lblVencimiento.Text = "Fecha de vencimiento:";

            // lblImporte
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(30, 190);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(60, 15);
            this.lblImporte.Text = "Importe:";

            // lblMetodo
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(30, 220);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(100, 15);
            this.lblMetodo.Text = "Método de pago:";

            // lblCuotas
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(30, 250);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(110, 15);
            this.lblCuotas.Text = "Cantidad de cuotas:";

            // lblComprobante
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.Location = new System.Drawing.Point(30, 280);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(120, 15);
            this.lblComprobante.Text = "N° de comprobante:";

            // btnImprimir
            this.btnImprimir.Location = new System.Drawing.Point(130, 320);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 30);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);

            // frmComprobante
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.lblComprobante);
            this.Controls.Add(this.btnImprimir);
            this.Name = "frmComprobante";
            this.Text = "Comprobante";
            this.Load += new System.EventHandler(this.frmComprobante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}
