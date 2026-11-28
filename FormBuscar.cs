namespace proyecto_de_fundamentos_de_programación
{
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            lblBuscarNombreApellido.Text = "Nombre, apellido o código:";
            AcceptButton = btnBuscar;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            if (texto == "")
            {
                MessageBox.Show("Escriba un nombre, un apellido o un código de matrícula (ej.: MAT-0001).",
                                "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Alumno[] encontrados = Busqueda.buscarPorTexto(AlumnosRepositorio.cargar(), texto);
            Pantalla.mostrarEnTabla(dgvBuscar, encontrados);
            LimpiarDetalle();

            if (encontrados.Length == 0)
            {
                MessageBox.Show("No se encontró ningún alumno con ese dato.", "Sin resultados",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MostrarDetalle(dgvBuscar.Rows[e.RowIndex]);
            }
        }

        void MostrarDetalle(DataGridViewRow fila)
        {
            txtDetalleNombre.Text = TextoDe(fila, "Nombre") + " " + TextoDe(fila, "Apellido");
            txtDetalleEdad.Text = TextoDe(fila, "Edad");
            txtDetalleAula.Text = TextoDe(fila, "Aula");
            txtDetalleApoderado.Text = TextoDe(fila, "Apoderado");
            txtDetalleTelefono.Text = TextoDe(fila, "Telefono");
        }

        void LimpiarDetalle()
        {
            txtDetalleNombre.Clear();
            txtDetalleEdad.Clear();
            txtDetalleAula.Clear();
            txtDetalleApoderado.Clear();
            txtDetalleTelefono.Clear();
        }

        static string TextoDe(DataGridViewRow fila, string columna)
        {
            return fila.Cells[columna].Value?.ToString() ?? "";
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
