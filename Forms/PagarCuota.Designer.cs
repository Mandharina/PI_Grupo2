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
            gbxFormaPago.SuspendLayout();
            gbxCuotas.SuspendLayout();
            SuspendLayout();
            // 
            // TituloPagarCuota
            // 
            TituloPagarCuota.AutoSize = true;
            TituloPagarCuota.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TituloPagarCuota.Location = new Point(130, 26);
            TituloPagarCuota.Name = "TituloPagarCuota";
            TituloPagarCuota.Size = new Size(268, 40);
            TituloPagarCuota.TabIndex = 0;
            TituloPagarCuota.Text = "Pago de Cuota";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblImporte.Location = new Point(70, 106);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(54, 17);
            lblImporte.TabIndex = 4;
            lblImporte.Text = "Importe";
            // 
            // txtImporte
            // 
            txtImporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtImporte.Location = new Point(243, 103);
            txtImporte.MaxLength = 20;
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(217, 25);
            txtImporte.TabIndex = 7;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = Color.FromArgb(255, 192, 128);
            btnPagarCuota.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagarCuota.Location = new Point(328, 308);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(132, 51);
            btnPagarCuota.TabIndex = 8;
            btnPagarCuota.Text = "PAGAR CUOTA";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Salmon;
            btnCancelar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(70, 308);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 51);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbxFormaPago
            // 
            gbxFormaPago.Controls.Add(rbtnTarjeta);
            gbxFormaPago.Controls.Add(rbtnEfectivo);
            gbxFormaPago.Location = new Point(70, 144);
            gbxFormaPago.Name = "gbxFormaPago";
            gbxFormaPago.Size = new Size(390, 57);
            gbxFormaPago.TabIndex = 11;
            gbxFormaPago.TabStop = false;
            gbxFormaPago.Tag = "";
            gbxFormaPago.Text = "Forma de Pago";
            // 
            // rbtnTarjeta
            // 
            rbtnTarjeta.AutoSize = true;
            rbtnTarjeta.Location = new Point(229, 26);
            rbtnTarjeta.Name = "rbtnTarjeta";
            rbtnTarjeta.Size = new Size(59, 19);
            rbtnTarjeta.TabIndex = 1;
            rbtnTarjeta.TabStop = true;
            rbtnTarjeta.Text = "Tarjeta";
            rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtnEfectivo
            // 
            rbtnEfectivo.AutoSize = true;
            rbtnEfectivo.Location = new Point(47, 27);
            rbtnEfectivo.Name = "rbtnEfectivo";
            rbtnEfectivo.Size = new Size(67, 19);
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
            gbxCuotas.Location = new Point(73, 220);
            gbxCuotas.Name = "gbxCuotas";
            gbxCuotas.Size = new Size(387, 59);
            gbxCuotas.TabIndex = 12;
            gbxCuotas.TabStop = false;
            gbxCuotas.Text = "Cuotas";
            gbxCuotas.Visible = false;
            // 
            // rbtn6
            // 
            rbtn6.AutoSize = true;
            rbtn6.Location = new Point(289, 22);
            rbtn6.Name = "rbtn6";
            rbtn6.Size = new Size(69, 19);
            rbtn6.TabIndex = 2;
            rbtn6.TabStop = true;
            rbtn6.Text = "6 cuotas";
            rbtn6.UseVisualStyleBackColor = true;
            // 
            // rbtn3
            // 
            rbtn3.AutoSize = true;
            rbtn3.Location = new Point(156, 22);
            rbtn3.Name = "rbtn3";
            rbtn3.Size = new Size(69, 19);
            rbtn3.TabIndex = 1;
            rbtn3.TabStop = true;
            rbtn3.Text = "3 cuotas";
            rbtn3.UseVisualStyleBackColor = true;
            // 
            // rbtn1
            // 
            rbtn1.AutoSize = true;
            rbtn1.Location = new Point(26, 22);
            rbtn1.Name = "rbtn1";
            rbtn1.Size = new Size(64, 19);
            rbtn1.TabIndex = 0;
            rbtn1.TabStop = true;
            rbtn1.Text = "1 cuota";
            rbtn1.UseVisualStyleBackColor = true;
            // 
            // frmPagarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(535, 395);
            Controls.Add(gbxCuotas);
            Controls.Add(gbxFormaPago);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagarCuota);
            Controls.Add(txtImporte);
            Controls.Add(lblImporte);
            Controls.Add(TituloPagarCuota);
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
    }
}