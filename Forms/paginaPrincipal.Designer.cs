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
            SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = Color.FromArgb(192, 255, 192);
            btnRegistrarCliente.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarCliente.Location = new Point(125, 61);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(212, 98);
            btnRegistrarCliente.TabIndex = 0;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(255, 224, 192);
            btnPagar.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.Location = new Point(512, 61);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(212, 98);
            btnPagar.TabIndex = 1;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // btnListarCuotas
            // 
            btnListarCuotas.BackColor = Color.FromArgb(255, 255, 192);
            btnListarCuotas.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnListarCuotas.ForeColor = SystemColors.ControlText;
            btnListarCuotas.Location = new Point(125, 245);
            btnListarCuotas.Name = "btnListarCuotas";
            btnListarCuotas.Size = new Size(212, 98);
            btnListarCuotas.TabIndex = 2;
            btnListarCuotas.Text = "Listar Cuotas";
            btnListarCuotas.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Location = new Point(810, 400);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 38);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmPaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(900, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnListarCuotas);
            Controls.Add(btnPagar);
            Controls.Add(btnRegistrarCliente);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmPaginaPrincipal";
            Text = "Página Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarCliente;
        private Button btnPagar;
        private Button btnListarCuotas;
        private Button btnSalir;
    }
}