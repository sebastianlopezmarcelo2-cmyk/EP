namespace proyecto_de_fundamentos_de_programación
{
    partial class FormRegistro
    {
        private System.ComponentModel.IContainer components = null;

        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombredelnino = new Label();
            lblEdad = new Label();
            lblAula = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            cmbAulaRegistro = new ComboBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtApoderado = new TextBox();
            lblApoderado = new Label();
            menuStrip1 = new MenuStrip();
            verAlumnosToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            organizarToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            lblTitulo = new Label();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblNombredelnino
            // 
            lblNombredelnino.AutoSize = true;
            lblNombredelnino.Font = new Font("Segoe UI", 12F);
            lblNombredelnino.Location = new Point(36, 215);
            lblNombredelnino.Name = "lblNombredelnino";
            lblNombredelnino.Size = new Size(165, 28);
            lblNombredelnino.TabIndex = 1;
            lblNombredelnino.Text = "Nombre del niño:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 12F);
            lblEdad.Location = new Point(36, 362);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(60, 28);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad:";
            // 
            // lblAula
            // 
            lblAula.AutoSize = true;
            lblAula.Font = new Font("Segoe UI", 12F);
            lblAula.Location = new Point(610, 215);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(55, 28);
            lblAula.TabIndex = 3;
            lblAula.Text = "Aula:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(218, 218);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 34);
            txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 12F);
            txtEdad.Location = new Point(218, 356);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(295, 34);
            txtEdad.TabIndex = 5;
            // 
            // cmbAulaRegistro
            // 
            cmbAulaRegistro.Font = new Font("Segoe UI", 12F);
            cmbAulaRegistro.FormattingEnabled = true;
            cmbAulaRegistro.Items.AddRange(new object[] { "3 años", "4 años", "5 años" });
            cmbAulaRegistro.Location = new Point(752, 215);
            cmbAulaRegistro.Name = "cmbAulaRegistro";
            cmbAulaRegistro.Size = new Size(295, 36);
            cmbAulaRegistro.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(245, 185, 30);
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 15F);
            btnGuardar.ForeColor = Color.FromArgb(33, 33, 33);
            btnGuardar.Location = new Point(486, 452);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 53);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(245, 185, 30);
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 15F);
            btnLimpiar.ForeColor = Color.FromArgb(33, 33, 33);
            btnLimpiar.Location = new Point(153, 452);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(139, 53);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(245, 185, 30);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 15F);
            btnSalir.ForeColor = Color.FromArgb(33, 33, 33);
            btnSalir.Location = new Point(819, 452);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 53);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(218, 283);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(295, 34);
            txtApellido.TabIndex = 11;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F);
            lblApellido.Location = new Point(36, 283);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(166, 28);
            lblApellido.TabIndex = 10;
            lblApellido.Text = "Apellido del niño:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(752, 356);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(295, 34);
            txtTelefono.TabIndex = 13;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(610, 362);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(90, 28);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtApoderado
            // 
            txtApoderado.Font = new Font("Segoe UI", 12F);
            txtApoderado.Location = new Point(752, 283);
            txtApoderado.Name = "txtApoderado";
            txtApoderado.Size = new Size(295, 34);
            txtApoderado.TabIndex = 15;
            // 
            // lblApoderado
            // 
            lblApoderado.AutoSize = true;
            lblApoderado.Font = new Font("Segoe UI", 12F);
            lblApoderado.Location = new Point(610, 283);
            lblApoderado.Name = "lblApoderado";
            lblApoderado.Size = new Size(116, 28);
            lblApoderado.TabIndex = 14;
            lblApoderado.Text = "Apoderado:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(149, 117, 205);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { verAlumnosToolStripMenuItem, buscarToolStripMenuItem, organizarToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1105, 33);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // verAlumnosToolStripMenuItem
            // 
            verAlumnosToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verAlumnosToolStripMenuItem.ForeColor = Color.White;
            verAlumnosToolStripMenuItem.Name = "verAlumnosToolStripMenuItem";
            verAlumnosToolStripMenuItem.Size = new Size(134, 29);
            verAlumnosToolStripMenuItem.Text = "Ver Alumnos";
            verAlumnosToolStripMenuItem.Click += verAlumnosToolStripMenuItem_Click;
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscarToolStripMenuItem.ForeColor = Color.White;
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(83, 29);
            buscarToolStripMenuItem.Text = "Buscar";
            buscarToolStripMenuItem.Click += buscarToolStripMenuItem_Click_1;
            // 
            // organizarToolStripMenuItem
            // 
            organizarToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            organizarToolStripMenuItem.ForeColor = Color.White;
            organizarToolStripMenuItem.Name = "organizarToolStripMenuItem";
            organizarToolStripMenuItem.Size = new Size(110, 29);
            organizarToolStripMenuItem.Text = "Organizar";
            organizarToolStripMenuItem.Click += organizarToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ayudaToolStripMenuItem.ForeColor = Color.White;
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(81, 29);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.Click += ayudaToolStripMenuItem_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(106, 27, 154);
            lblTitulo.Location = new Point(318, 89);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(469, 46);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "REGISTRO DE ESTUDIANTES";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image_removebg_preview;
            pictureBox2.Location = new Point(927, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1105, 550);
            Controls.Add(pictureBox2);
            Controls.Add(lblTitulo);
            Controls.Add(txtApoderado);
            Controls.Add(lblApoderado);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbAulaRegistro);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblAula);
            Controls.Add(lblEdad);
            Controls.Add(lblNombredelnino);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormRegistro";
            Text = "Registro de estudiantes";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombredelnino;
        private Label lblEdad;
        private Label lblAula;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private ComboBox cmbAulaRegistro;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtApoderado;
        private Label lblApoderado;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem verAlumnosToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem organizarToolStripMenuItem;
        private Label lblTitulo;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private PictureBox pictureBox2;
    }
}
