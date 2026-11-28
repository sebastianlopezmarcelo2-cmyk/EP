namespace proyecto_de_fundamentos_de_programación
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pantalla.soloLista(cmbAulaRegistro);
            cmbAulaRegistro.Items.Clear();
            cmbAulaRegistro.Items.AddRange(Aulas.nombres);
            cmbAulaRegistro.SelectedIndex = -1;

            txtNombre.MaxLength = 40;
            txtApellido.MaxLength = 40;
            txtApoderado.MaxLength = 40;
            txtEdad.MaxLength = 1;
            txtTelefono.MaxLength = 9;
        }

        void LimpiarPantalla()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtApoderado.Clear();
            txtTelefono.Clear();
            cmbAulaRegistro.SelectedIndex = -1;
            txtNombre.Focus();
        }

        Alumno LeerAlumnoDePantalla(string codigo, int edad)
        {
            return new Alumno
            {
                Codigo = codigo,
                Nombre = Validaciones.nombrePropio(txtNombre.Text),
                Apellido = Validaciones.nombrePropio(txtApellido.Text),
                Edad = edad,
                Aula = cmbAulaRegistro.SelectedItem!.ToString()!,
                Apoderado = Validaciones.nombrePropio(txtApoderado.Text),
                Telefono = txtTelefono.Text.Trim()
            };
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string error = Validaciones.validarRegistro(txtNombre.Text, txtApellido.Text, txtEdad.Text,
                                                        cmbAulaRegistro.SelectedItem?.ToString(),
                                                        txtApoderado.Text, txtTelefono.Text, out int edad);
            if (error != "")
            {
                MessageBox.Show(error, "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Alumno[] registrados = AlumnosRepositorio.cargar();
                Alumno nuevo = LeerAlumnoDePantalla(AlumnosRepositorio.siguienteCodigo(registrados), edad);

                if (!Aulas.hayCupo(registrados, nuevo.Aula))
                {
                    MessageBox.Show($"El aula de {nuevo.Aula} ya tiene {Aulas.CupoMaximo} niños. No hay vacantes.",
                                    "Sin cupo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Busqueda.existeAlumno(registrados, nuevo.Nombre, nuevo.Apellido))
                {
                    MessageBox.Show($"{nuevo.Nombre} {nuevo.Apellido} ya está registrado.",
                                    "Alumno repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AlumnosRepositorio.guardar(nuevo);

                int ocupados = Aulas.ocupados(registrados, nuevo.Aula) + 1;
                MessageBox.Show($"¡Niño registrado con éxito!\n\nCódigo de matrícula: {nuevo.Codigo}\n" +
                                $"Aula {nuevo.Aula}: {ocupados} de {Aulas.CupoMaximo} vacantes ocupadas.",
                                "Guardar");
                LimpiarPantalla();
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show("No se pudo guardar en el archivo: " + ex.Message,
                                "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de salir?",
                                                     "Mensaje de confirmación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void verAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla.abrirVentana(this, new FormVer());
        }

        private void buscarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Pantalla.abrirVentana(this, new FormBuscar());
        }

        private void organizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla.abrirVentana(this, new FormOrganizar());
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "GUÍA RÁPIDA DE USO\n" +
            "Sistema de Matrículas - Kínder Los Milagritos\n\n" +
            "1. REGISTRO DE ESTUDIANTES:\n" +
            "Complete todos los datos del alumno y del apoderado. Tenga en cuenta que la edad debe estar entre 3 y 5 años, coincidir con el aula seleccionada y el número telefónico debe contar con 9 dígitos que inicien en 9. Al guardar, el sistema asignará un código único automático (por ejemplo, MAT-0001).\n\n" +
            "2. VER ALUMNOS:\n" +
            "Permite visualizar el listado completo de todos los estudiantes que han sido registrados y guardados en el sistema.\n\n" +
            "3. BUSCAR:\n" +
            "Permite localizar rápidamente a un alumno escribiendo su código de matrícula, nombre o apellido. Al hacer clic sobre un resultado de la tabla, se mostrarán sus datos completos en el panel derecho.\n\n" +
            "4. ORGANIZAR:\n" +
            "Permite filtrar a los estudiantes por aula (controlando que no se supere el límite de 15 vacantes por salón), así como ordenarlos de forma ascendente según su código, apellido o edad.",
            "Ayuda - Sistema de Matrículas Kínder Los Milagritos",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
    }
}
