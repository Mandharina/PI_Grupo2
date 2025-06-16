using System.Windows.Forms;
using PI_Grupo2.Entidades;

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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvActividades = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            costo = new DataGridViewTextBoxColumn();
            dia = new DataGridViewTextBoxColumn();
            horario = new DataGridViewTextBoxColumn();
            cupos = new DataGridViewTextBoxColumn();
            btnPagar = new DataGridViewButtonColumn();
            lblActividades = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // dgvActividades
            // 
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.AllowUserToDeleteRows = false;
            dgvActividades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvActividades.BackgroundColor = Color.White;
            dgvActividades.BorderStyle = BorderStyle.Fixed3D;
            dgvActividades.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvActividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Columns.AddRange(new DataGridViewColumn[] { nombre, descripcion, costo, dia, horario, cupos, btnPagar });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvActividades.DefaultCellStyle = dataGridViewCellStyle4;
            dgvActividades.EnableHeadersVisualStyles = false;
            dgvActividades.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dgvActividades.GridColor = Color.FromArgb(255, 128, 0);
            dgvActividades.Location = new Point(26, 104);
            dgvActividades.Margin = new Padding(3, 2, 3, 2);
            dgvActividades.MultiSelect = false;
            dgvActividades.Name = "dgvActividades";
            dgvActividades.ReadOnly = true;
            dgvActividades.RowHeadersWidth = 51;
            dgvActividades.RowTemplate.Height = 29;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActividades.Size = new Size(1083, 244);
            dgvActividades.TabIndex = 0;
            dgvActividades.CellClick += dgvActividades_CellClick;
            // 
            // nombre
            // 
            nombre.DividerWidth = 2;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 250;
            // 
            // descripcion
            // 
            descripcion.DividerWidth = 2;
            descripcion.HeaderText = "Descripción";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 400;
            // 
            // costo
            // 
            costo.DividerWidth = 2;
            costo.HeaderText = "Costo";
            costo.MinimumWidth = 6;
            costo.Name = "costo";
            costo.ReadOnly = true;
            costo.Width = 80;
            // 
            // dia
            // 
            dia.DividerWidth = 2;
            dia.HeaderText = "Día";
            dia.MinimumWidth = 6;
            dia.Name = "dia";
            dia.ReadOnly = true;
            dia.Width = 80;
            // 
            // horario
            // 
            horario.DividerWidth = 2;
            horario.HeaderText = "Horario";
            horario.MinimumWidth = 6;
            horario.Name = "horario";
            horario.ReadOnly = true;
            horario.Width = 80;
            // 
            // cupos
            // 
            cupos.DividerWidth = 2;
            cupos.HeaderText = "Cupos";
            cupos.MinimumWidth = 6;
            cupos.Name = "cupos";
            cupos.ReadOnly = true;
            cupos.Width = 80;
            // 
            // btnPagar
            // 
            btnPagar.HeaderText = "Acción";
            btnPagar.Name = "btnPagar";
            btnPagar.ReadOnly = true;
            btnPagar.Text = "Pagar";
            btnPagar.UseColumnTextForButtonValue = true;
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblActividades.Location = new Point(26, 34);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(444, 40);
            lblActividades.TabIndex = 2;
            lblActividades.Text = "Actividades Disponibles";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Salmon;
            btnVolver.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(1009, 364);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 45);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmPagarActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1136, 431);
            Controls.Add(btnVolver);
            Controls.Add(lblActividades);
            Controls.Add(dgvActividades);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPagarActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago de Actividades";
            Load += frmPagarActividad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label lblActividades;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn costo;
        private DataGridViewTextBoxColumn dia;
        private DataGridViewTextBoxColumn horario;
        private DataGridViewTextBoxColumn cupos;
        private DataGridViewButtonColumn btnPagar;
        private Button btnVolver;
    }
}