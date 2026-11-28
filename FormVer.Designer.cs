namespace proyecto_de_fundamentos_de_programación
{
    partial class FormVer
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
            dgvTodos = new DataGridView();
            btnVolver = new Button();
            lblAlumnos = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTodos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvTodos
            // 
            dgvTodos.AllowUserToAddRows = false;
            dgvTodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(106, 27, 154);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 243, 205);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodos.EnableHeadersVisualStyles = false;
            dgvTodos.GridColor = Color.FromArgb(245, 185, 30);
            dgvTodos.Location = new Point(62, 170);
            dgvTodos.MultiSelect = false;
            dgvTodos.Name = "dgvTodos";
            dgvTodos.ReadOnly = true;
            dgvTodos.RowHeadersWidth = 51;
            dgvTodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTodos.Size = new Size(890, 369);
            dgvTodos.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.FlatAppearance.BorderColor = Color.FromArgb(245, 185, 30);
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.FromArgb(33, 33, 33);
            btnVolver.Location = new Point(406, 566);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(203, 52);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver al Menú";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblAlumnos
            // 
            lblAlumnos.AutoSize = true;
            lblAlumnos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAlumnos.ForeColor = Color.FromArgb(106, 27, 154);
            lblAlumnos.Location = new Point(293, 53);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(429, 46);
            lblAlumnos.TabIndex = 2;
            lblAlumnos.Text = "ALUMNOS REGISTRADOS";
            lblAlumnos.Click += lblAlumnos_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image_removebg_preview;
            pictureBox2.Location = new Point(836, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // FormVer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1014, 644);
            Controls.Add(pictureBox2);
            Controls.Add(lblAlumnos);
            Controls.Add(btnVolver);
            Controls.Add(dgvTodos);
            Name = "FormVer";
            Text = "Ver alumnos registrados";
            Load += FormVer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTodos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTodos;
        private Button btnVolver;
        private Label lblAlumnos;
        private PictureBox pictureBox2;
    }
}