namespace proyecto_de_fundamentos_de_programación
{
    partial class FormBuscar
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitule = new Label();
            lblBuscarNombreApellido = new Label();
            lblDetalle = new Label();
            btnBuscar = new Button();
            btnVolver = new Button();
            dgvBuscar = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Aula = new DataGridViewTextBoxColumn();
            Apoderado = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            txtDetalleNombre = new TextBox();
            txtDetalleAula = new TextBox();
            txtDetalleEdad = new TextBox();
            txtDetalleApoderado = new TextBox();
            txtDetalleTelefono = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitule
            // 
            lblTitule.AutoSize = true;
            lblTitule.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitule.ForeColor = Color.FromArgb(106, 27, 154);
            lblTitule.Location = new Point(447, 24);
            lblTitule.Name = "lblTitule";
            lblTitule.Size = new Size(435, 41);
            lblTitule.TabIndex = 0;
            lblTitule.Text = "BÚSQUEDA DE ESTUDIANTES";
            lblTitule.Click += label1_Click;
            // 
            // lblBuscarNombreApellido
            // 
            lblBuscarNombreApellido.AutoSize = true;
            lblBuscarNombreApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscarNombreApellido.Location = new Point(30, 112);
            lblBuscarNombreApellido.Name = "lblBuscarNombreApellido";
            lblBuscarNombreApellido.Size = new Size(280, 28);
            lblBuscarNombreApellido.TabIndex = 1;
            lblBuscarNombreApellido.Text = "Buscar por Nombre y Apellido:";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetalle.Location = new Point(849, 317);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(359, 31);
            lblDetalle.TabIndex = 2;
            lblDetalle.Text = "Detalle por Alumno Seleccionado:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(245, 185, 30);
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(33, 33, 33);
            btnBuscar.Location = new Point(415, 196);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(157, 59);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btn_buscar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.FlatAppearance.BorderColor = Color.FromArgb(245, 185, 30);
            btnVolver.FlatAppearance.BorderSize = 2;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.FromArgb(33, 33, 33);
            btnVolver.Location = new Point(692, 196);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(221, 59);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver al Menú";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btn_volver_Click;
            // 
            // dgvBuscar
            // 
            dgvBuscar.AllowUserToAddRows = false;
            dgvBuscar.AllowUserToDeleteRows = false;
            dgvBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuscar.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(106, 27, 154);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 243, 205);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscar.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Edad, Aula, Apoderado, Telefono });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 243, 205);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBuscar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBuscar.EnableHeadersVisualStyles = false;
            dgvBuscar.GridColor = Color.FromArgb(245, 185, 30);
            dgvBuscar.Location = new Point(12, 295);
            dgvBuscar.Name = "dgvBuscar";
            dgvBuscar.ReadOnly = true;
            dgvBuscar.RowHeadersWidth = 51;
            dgvBuscar.Size = new Size(804, 405);
            dgvBuscar.TabIndex = 5;
            dgvBuscar.CellClick += dgvBuscar_CellClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 6;
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            // 
            // Aula
            // 
            Aula.HeaderText = "Aula";
            Aula.MinimumWidth = 6;
            Aula.Name = "Aula";
            Aula.ReadOnly = true;
            // 
            // Apoderado
            // 
            Apoderado.HeaderText = "Apoderado";
            Apoderado.MinimumWidth = 6;
            Apoderado.Name = "Apoderado";
            Apoderado.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(338, 109);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(705, 34);
            txtBuscar.TabIndex = 6;
            // 
            // txtDetalleNombre
            // 
            txtDetalleNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetalleNombre.Location = new Point(888, 369);
            txtDetalleNombre.Name = "txtDetalleNombre";
            txtDetalleNombre.Size = new Size(419, 34);
            txtDetalleNombre.TabIndex = 7;
            // 
            // txtDetalleAula
            // 
            txtDetalleAula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetalleAula.Location = new Point(889, 493);
            txtDetalleAula.Name = "txtDetalleAula";
            txtDetalleAula.Size = new Size(419, 34);
            txtDetalleAula.TabIndex = 8;
            // 
            // txtDetalleEdad
            // 
            txtDetalleEdad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetalleEdad.Location = new Point(889, 431);
            txtDetalleEdad.Name = "txtDetalleEdad";
            txtDetalleEdad.Size = new Size(418, 34);
            txtDetalleEdad.TabIndex = 9;
            // 
            // txtDetalleApoderado
            // 
            txtDetalleApoderado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetalleApoderado.Location = new Point(889, 555);
            txtDetalleApoderado.Name = "txtDetalleApoderado";
            txtDetalleApoderado.Size = new Size(419, 34);
            txtDetalleApoderado.TabIndex = 10;
            // 
            // txtDetalleTelefono
            // 
            txtDetalleTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetalleTelefono.Location = new Point(888, 617);
            txtDetalleTelefono.Name = "txtDetalleTelefono";
            txtDetalleTelefono.Size = new Size(419, 34);
            txtDetalleTelefono.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_removebg_preview;
            pictureBox1.Location = new Point(1151, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1329, 733);
            Controls.Add(pictureBox1);
            Controls.Add(txtDetalleTelefono);
            Controls.Add(txtDetalleApoderado);
            Controls.Add(txtDetalleEdad);
            Controls.Add(txtDetalleAula);
            Controls.Add(txtDetalleNombre);
            Controls.Add(txtBuscar);
            Controls.Add(dgvBuscar);
            Controls.Add(btnVolver);
            Controls.Add(btnBuscar);
            Controls.Add(lblDetalle);
            Controls.Add(lblBuscarNombreApellido);
            Controls.Add(lblTitule);
            Name = "FormBuscar";
            Text = "Busqueda de estudiantes";
            Load += FormBuscar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitule;
        private Label lblBuscarNombreApellido;
        private Label lblDetalle;
        private Button btnBuscar;
        private Button btnVolver;
        private DataGridView dgvBuscar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Aula;
        private TextBox txtBuscar;
        private TextBox txtDetalleNombre;
        private TextBox txtDetalleAula;
        private TextBox txtDetalleEdad;
        private DataGridViewTextBoxColumn Apoderado;
        private DataGridViewTextBoxColumn Telefono;
        private TextBox txtDetalleApoderado;
        private TextBox txtDetalleTelefono;
        private PictureBox pictureBox1;
    }
}