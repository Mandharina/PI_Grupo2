namespace PI_Grupo2.Forms
{
    partial class frmPagarActividad
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
            lblSelecActivida = new Label();
            cboActividades = new ComboBox();
            lblImporte = new Label();
            txtImporte = new TextBox();
            btnPagarActividad = new Button();
            btnCancelar = new Button();
            btnImprimirComprobante = new Button();
            SuspendLayout();
            // 
            // lblSelecActivida
            // 
            lblSelecActivida.AutoSize = true;
            lblSelecActivida.Location = new Point(142, 91);
            lblSelecActivida.Name = "lblSelecActivida";
            lblSelecActivida.Size = new Size(164, 20);
            lblSelecActivida.TabIndex = 0;
            lblSelecActivida.Text = "Seleccione la actividad:";
            // 
            // cboActividades
            // 
            cboActividades.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividades.FormattingEnabled = true;
            cboActividades.Location = new Point(312, 83);
            cboActividades.Name = "cboActividades";
            cboActividades.Size = new Size(237, 28);
            cboActividades.TabIndex = 1;
            cboActividades.SelectedIndexChanged += cboActividades_SelectedIndexChanged;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(232, 139);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(62, 20);
            lblImporte.TabIndex = 2;
            lblImporte.Text = "Importe";
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(312, 132);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(152, 27);
            txtImporte.TabIndex = 3;
            // 
            // btnPagarActividad
            // 
            btnPagarActividad.BackColor = Color.FromArgb(255, 192, 128);
            btnPagarActividad.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagarActividad.Location = new Point(440, 268);
            btnPagarActividad.Margin = new Padding(3, 4, 3, 4);
            btnPagarActividad.Name = "btnPagarActividad";
            btnPagarActividad.Size = new Size(151, 68);
            btnPagarActividad.TabIndex = 9;
            btnPagarActividad.Text = "PAGAR";
            btnPagarActividad.UseVisualStyleBackColor = false;
            btnPagarActividad.Click += btnPagarActividad_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Salmon;
            btnCancelar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(85, 268);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(151, 68);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnImprimirComprobante
            // 
            btnImprimirComprobante.BackColor = Color.FromArgb(128, 255, 128);
            btnImprimirComprobante.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimirComprobante.Location = new Point(440, 369);
            btnImprimirComprobante.Margin = new Padding(3, 4, 3, 4);
            btnImprimirComprobante.Name = "btnImprimirComprobante";
            btnImprimirComprobante.Size = new Size(151, 68);
            btnImprimirComprobante.TabIndex = 14;
            btnImprimirComprobante.Text = "IMPRIMIR COMPROBANTE";
            btnImprimirComprobante.UseVisualStyleBackColor = false;
            btnImprimirComprobante.Click += btnImprimirComprobante_Click;
            // 
            // frmPagarActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnImprimirComprobante);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagarActividad);
            Controls.Add(txtImporte);
            Controls.Add(lblImporte);
            Controls.Add(cboActividades);
            Controls.Add(lblSelecActivida);
            Name = "frmPagarActividad";
            Text = "Pagar Actividad";
            Load += frmPagarActividad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelecActivida;
        private ComboBox cboActividades;
        private Label lblImporte;
        private TextBox txtImporte;
        private Button btnPagarActividad;
        private Button btnCancelar;
        private Button btnImprimirComprobante;
    }
}