namespace PI_Grupo2.Forms
{
    partial class frmPagarCuota
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
            TituloPagarCuota = new Label();
            lblImporte = new Label();
            txtImporte = new TextBox();
            btnPagarCuota = new Button();
            btnCancelar = new Button();
            gbxFormaPago = new GroupBox();
            rbtnTarjeta = new RadioButton();
            rbtnEfectivo = new RadioButton();
            gbxCuotas = new GroupBox();
            rbtn6 = new RadioButton();
            rbtn3 = new RadioButton();
            rbtn1 = new RadioButton();
            btnImprimirComprobante = new Button();
            gbxFormaPago.SuspendLayout();
            gbxCuotas.SuspendLayout();
            SuspendLayout();
            // 
            // TituloPagarCuota
            // 
            TituloPagarCuota.AutoSize = true;
            TituloPagarCuota.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TituloPagarCuota.Location = new Point(56, 40);
            TituloPagarCuota.Name = "TituloPagarCuota";
            TituloPagarCuota.Size = new Size(335, 50);
            TituloPagarCuota.TabIndex = 0;
            TituloPagarCuota.Text = "Pago de Cuota";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblImporte.Location = new Point(56, 141);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(71, 23);
            lblImporte.TabIndex = 4;
            lblImporte.Text = "Importe";
            // 
            // txtImporte
            // 
            txtImporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtImporte.Location = new Point(254, 137);
            txtImporte.Margin = new Padding(3, 4, 3, 4);
            txtImporte.MaxLength = 20;
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(247, 29);
            txtImporte.TabIndex = 7;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = Color.FromArgb(255, 192, 128);
            btnPagarCuota.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagarCuota.Location = new Point(351, 411);
            btnPagarCuota.Margin = new Padding(3, 4, 3, 4);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(151, 68);
            btnPagarCuota.TabIndex = 8;
            btnPagarCuota.Text = "PAGAR";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Salmon;
            btnCancelar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(56, 411);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(151, 68);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbxFormaPago
            // 
            gbxFormaPago.Controls.Add(rbtnTarjeta);
            gbxFormaPago.Controls.Add(rbtnEfectivo);
            gbxFormaPago.Location = new Point(56, 192);
            gbxFormaPago.Margin = new Padding(3, 4, 3, 4);
            gbxFormaPago.Name = "gbxFormaPago";
            gbxFormaPago.Padding = new Padding(3, 4, 3, 4);
            gbxFormaPago.Size = new Size(446, 76);
            gbxFormaPago.TabIndex = 11;
            gbxFormaPago.TabStop = false;
            gbxFormaPago.Tag = "";
            gbxFormaPago.Text = "Forma de Pago";
            // 
            // rbtnTarjeta
            // 
            rbtnTarjeta.AutoSize = true;
            rbtnTarjeta.Location = new Point(262, 35);
            rbtnTarjeta.Margin = new Padding(3, 4, 3, 4);
            rbtnTarjeta.Name = "rbtnTarjeta";
            rbtnTarjeta.Size = new Size(74, 24);
            rbtnTarjeta.TabIndex = 1;
            rbtnTarjeta.TabStop = true;
            rbtnTarjeta.Text = "Tarjeta";
            rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtnEfectivo
            // 
            rbtnEfectivo.AutoSize = true;
            rbtnEfectivo.Location = new Point(54, 36);
            rbtnEfectivo.Margin = new Padding(3, 4, 3, 4);
            rbtnEfectivo.Name = "rbtnEfectivo";
            rbtnEfectivo.Size = new Size(83, 24);
            rbtnEfectivo.TabIndex = 0;
            rbtnEfectivo.TabStop = true;
            rbtnEfectivo.Text = "Efectivo";
            rbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // gbxCuotas
            // 
            gbxCuotas.Controls.Add(rbtn6);
            gbxCuotas.Controls.Add(rbtn3);
            gbxCuotas.Controls.Add(rbtn1);
            gbxCuotas.Location = new Point(59, 293);
            gbxCuotas.Margin = new Padding(3, 4, 3, 4);
            gbxCuotas.Name = "gbxCuotas";
            gbxCuotas.Padding = new Padding(3, 4, 3, 4);
            gbxCuotas.Size = new Size(442, 79);
            gbxCuotas.TabIndex = 12;
            gbxCuotas.TabStop = false;
            gbxCuotas.Text = "Cuotas";
            gbxCuotas.Visible = false;
            // 
            // rbtn6
            // 
            rbtn6.AutoSize = true;
            rbtn6.Location = new Point(330, 29);
            rbtn6.Margin = new Padding(3, 4, 3, 4);
            rbtn6.Name = "rbtn6";
            rbtn6.Size = new Size(85, 24);
            rbtn6.TabIndex = 2;
            rbtn6.TabStop = true;
            rbtn6.Text = "6 cuotas";
            rbtn6.UseVisualStyleBackColor = true;
            // 
            // rbtn3
            // 
            rbtn3.AutoSize = true;
            rbtn3.Location = new Point(178, 29);
            rbtn3.Margin = new Padding(3, 4, 3, 4);
            rbtn3.Name = "rbtn3";
            rbtn3.Size = new Size(85, 24);
            rbtn3.TabIndex = 1;
            rbtn3.TabStop = true;
            rbtn3.Text = "3 cuotas";
            rbtn3.UseVisualStyleBackColor = true;
            // 
            // rbtn1
            // 
            rbtn1.AutoSize = true;
            rbtn1.Location = new Point(30, 29);
            rbtn1.Margin = new Padding(3, 4, 3, 4);
            rbtn1.Name = "rbtn1";
            rbtn1.Size = new Size(79, 24);
            rbtn1.TabIndex = 0;
            rbtn1.TabStop = true;
            rbtn1.Text = "1 cuota";
            rbtn1.UseVisualStyleBackColor = true;
            // 
            // btnImprimirComprobante
            // 
            btnImprimirComprobante.BackColor = Color.FromArgb(128, 255, 128);
            btnImprimirComprobante.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimirComprobante.Location = new Point(350, 509);
            btnImprimirComprobante.Margin = new Padding(3, 4, 3, 4);
            btnImprimirComprobante.Name = "btnImprimirComprobante";
            btnImprimirComprobante.Size = new Size(151, 68);
            btnImprimirComprobante.TabIndex = 13;
            btnImprimirComprobante.Text = "IMPRIMIR COMPROBANTE";
            btnImprimirComprobante.UseVisualStyleBackColor = false;
            btnImprimirComprobante.Click += btnImprimirComprobante_Click;
            // 
            // frmPagarCuota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(684, 618);
            Controls.Add(btnImprimirComprobante);
            Controls.Add(gbxCuotas);
            Controls.Add(gbxFormaPago);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagarCuota);
            Controls.Add(txtImporte);
            Controls.Add(lblImporte);
            Controls.Add(TituloPagarCuota);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPagarCuota";
            Text = "PAGO DE CUOTA";
            gbxFormaPago.ResumeLayout(false);
            gbxFormaPago.PerformLayout();
            gbxCuotas.ResumeLayout(false);
            gbxCuotas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloPagarCuota;
        private Label lblImporte;
        private TextBox txtImporte;
        private Button btnPagarCuota;
        private Button btnCancelar;
        private GroupBox gbxFormaPago;
        private RadioButton rbtnEfectivo;
        private RadioButton rbtnTarjeta;
        private GroupBox gbxCuotas;
        private RadioButton rbtn6;
        private RadioButton rbtn3;
        private RadioButton rbtn1;
        private Button btnImprimirComprobante;
    }
}