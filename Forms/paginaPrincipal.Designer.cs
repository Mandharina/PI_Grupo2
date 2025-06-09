namespace PI_Grupo2
{
    partial class frmPaginaPrincipal
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
            btnRegistrarCliente = new Button();
            btnPagar = new Button();
            btnListarCuotas = new Button();
            btnSalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = Color.FromArgb(192, 255, 192);
            btnRegistrarCliente.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarCliente.Location = new Point(146, 118);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(270, 100);
            btnRegistrarCliente.TabIndex = 0;
            btnRegistrarCliente.Text = "REGISTRAR CLIENTE";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(255, 224, 192);
            btnPagar.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.Location = new Point(476, 118);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(270, 100);
            btnPagar.TabIndex = 1;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // btnListarCuotas
            // 
            btnListarCuotas.BackColor = Color.FromArgb(255, 255, 192);
            btnListarCuotas.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnListarCuotas.ForeColor = SystemColors.ControlText;
            btnListarCuotas.Location = new Point(146, 245);
            btnListarCuotas.Name = "btnListarCuotas";
            btnListarCuotas.Size = new Size(270, 100);
            btnListarCuotas.TabIndex = 2;
            btnListarCuotas.Text = "LISTAR CUOTAS";
            btnListarCuotas.UseVisualStyleBackColor = false;
            btnListarCuotas.Click += btnListarCuotas_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Tomato;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(788, 393);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 45);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(295, 44);
            label1.Name = "label1";
            label1.Size = new Size(364, 50);
            label1.TabIndex = 4;
            label1.Text = "Menu Principal";
            // 
            // frmPaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(900, 450);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnListarCuotas);
            Controls.Add(btnPagar);
            Controls.Add(btnRegistrarCliente);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmPaginaPrincipal";
            Text = "Página Principal";
            Load += frmPaginaPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarCliente;
        private Button btnPagar;
        private Button btnListarCuotas;
        private Button btnSalir;
        private Label label1;
    }
}