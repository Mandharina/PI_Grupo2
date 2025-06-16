namespace PI_Grupo2.Forms
{
    partial class frmListarCuotas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtgvListarCuotas = new DataGridView();
            socio = new DataGridViewTextBoxColumn();
            importe = new DataGridViewTextBoxColumn();
            vencimiento = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvListarCuotas).BeginInit();
            SuspendLayout();
            // 
            // dtgvListarCuotas
            // 
            dtgvListarCuotas.AllowUserToAddRows = false;
            dtgvListarCuotas.AllowUserToDeleteRows = false;
            dtgvListarCuotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvListarCuotas.BackgroundColor = Color.White;
            dtgvListarCuotas.BorderStyle = BorderStyle.Fixed3D;
            dtgvListarCuotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvListarCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvListarCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListarCuotas.Columns.AddRange(new DataGridViewColumn[] { socio, importe, vencimiento, estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvListarCuotas.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvListarCuotas.EnableHeadersVisualStyles = false;
            dtgvListarCuotas.GridColor = Color.FromArgb(255, 128, 0);
            dtgvListarCuotas.Location = new Point(74, 97);
            dtgvListarCuotas.Margin = new Padding(3, 2, 3, 2);
            dtgvListarCuotas.Name = "dtgvListarCuotas";
            dtgvListarCuotas.ReadOnly = true;
            dtgvListarCuotas.RowHeadersWidth = 51;
            dtgvListarCuotas.RowTemplate.Height = 29;
            dtgvListarCuotas.Size = new Size(751, 201);
            dtgvListarCuotas.TabIndex = 0;
            // 
            // socio
            // 
            socio.DividerWidth = 2;
            socio.HeaderText = "Socio";
            socio.MinimumWidth = 6;
            socio.Name = "socio";
            socio.ReadOnly = true;
            socio.Width = 125;
            // 
            // importe
            // 
            importe.DividerWidth = 2;
            importe.HeaderText = "Importe";
            importe.MinimumWidth = 6;
            importe.Name = "importe";
            importe.ReadOnly = true;
            importe.Width = 130;
            // 
            // vencimiento
            // 
            vencimiento.DividerWidth = 2;
            vencimiento.HeaderText = "Vencimiento";
            vencimiento.MinimumWidth = 6;
            vencimiento.Name = "vencimiento";
            vencimiento.ReadOnly = true;
            vencimiento.Width = 160;
            // 
            // estado
            // 
            estado.DividerWidth = 2;
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 36);
            label1.Name = "label1";
            label1.Size = new Size(437, 40);
            label1.TabIndex = 1;
            label1.Text = "Próximos Vencimientos";
            // 
            // frmListarCuotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(906, 367);
            Controls.Add(label1);
            Controls.Add(dtgvListarCuotas);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmListarCuotas";
            Text = "listarCuotas";
            Load += listarCuotasfrm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvListarCuotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvListarCuotas;
        private Label label1;
        private DataGridViewTextBoxColumn socio;
        private DataGridViewTextBoxColumn importe;
        private DataGridViewTextBoxColumn vencimiento;
        private DataGridViewTextBoxColumn estado;
    }
}