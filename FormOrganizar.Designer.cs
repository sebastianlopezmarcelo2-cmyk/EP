namespace proyecto_de_fundamentos_de_programación
{
    partial class FormOrganizar
    {
        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.
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
            cmbAulas = new ComboBox();
            dgvFiltrado = new DataGridView();
            btnVolver = new Button();
            lblTitulo = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvFiltrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cmbAulas
            // 
            cmbAulas.FormattingEnabled = true;
            cmbAulas.Location = new Point(247, 165);
            cmbAulas.Name = "cmbAulas";
            cmbAulas.Size = new Size(160, 28);
            cmbAulas.TabIndex = 0;
            cmbAulas.SelectedIndexChanged += cmbAulas_SelectedIndexChanged;
            // 
            // dgvFiltrado
            // 
            dgvFiltrado.AllowUserToAddRows = false;
            dgvFiltrado.AllowUserToDeleteRows = false;
            dgvFiltrado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFiltrado.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(106, 27, 154);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 243, 205);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFiltrado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFiltrado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFiltrado.EnableHeadersVisualStyles = false;
            dgvFiltrado.GridColor = Color.FromArgb(245, 185, 30);
            dgvFiltrado.Location = new Point(94, 216);
            dgvFiltrado.Name = "dgvFiltrado";
            dgvFiltrado.ReadOnly = true;
            dgvFiltrado.RowHeadersVisible = false;
            dgvFiltrado.RowHeadersWidth = 51;
            dgvFiltrado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFiltrado.Size = new Size(835, 191);
            dgvFiltrado.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.FlatAppearance.BorderColor = Color.FromArgb(245, 185, 30);
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.FromArgb(33, 33, 33);
            btnVolver.Location = new Point(405, 469);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(213, 54);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver al Menú";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(106, 27, 154);
            lblTitulo.Location = new Point(310, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(402, 41);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "ORGANIZACIÓN DE AULAS";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image_removebg_preview;
            pictureBox2.Location = new Point(845, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // FormOrganizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1023, 565);
            Controls.Add(pictureBox2);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolver);
            Controls.Add(dgvFiltrado);
            Controls.Add(cmbAulas);
            Name = "FormOrganizar";
            Text = "Organización de aulas";
            Load += FormOrganizar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFiltrado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAulas;
        private DataGridView dgvFiltrado;
        private Button btnVolver;
        private Label lblTitulo;
        private PictureBox pictureBox2;
    }
}