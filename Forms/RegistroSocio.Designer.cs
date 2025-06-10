namespace PI_Grupo2.Forms
{
    partial class frmRegistroSocio
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
            btnPagar = new Button();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnEmitir = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(255, 192, 128);
            btnPagar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.Location = new Point(254, 182);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(132, 51);
            btnPagar.TabIndex = 0;
            btnPagar.Text = "PAGAR CUOTA";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(31, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(323, 40);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de Socio";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.Location = new Point(31, 86);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(513, 21);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Para finalizar con el alta del socio es necesario que abone la primer cuota";
            // 
            // btnEmitir
            // 
            btnEmitir.BackColor = Color.FromArgb(255, 192, 128);
            btnEmitir.Enabled = false;
            btnEmitir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmitir.Location = new Point(412, 182);
            btnEmitir.Name = "btnEmitir";
            btnEmitir.Size = new Size(132, 51);
            btnEmitir.TabIndex = 3;
            btnEmitir.Text = "EMITIR CARNET";
            btnEmitir.UseVisualStyleBackColor = false;
            btnEmitir.Click += btnEmitir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Salmon;
            btnCancelar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(31, 182);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 51);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmRegistroSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(578, 267);
            Controls.Add(btnCancelar);
            Controls.Add(btnEmitir);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(btnPagar);
            Name = "frmRegistroSocio";
            Text = "Registro de socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPagar;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnEmitir;
        private Button btnCancelar;
    }
}