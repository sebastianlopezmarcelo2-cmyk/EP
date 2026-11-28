namespace proyecto_de_fundamentos_de_programación
{
    public partial class FormVer : Form
    {
        public FormVer()
        {
            InitializeComponent();
        }

        private void FormVer_Load(object sender, EventArgs e)
        {
            Pantalla.mostrarEnTabla(dgvTodos, AlumnosRepositorio.cargar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblAlumnos_Click(object sender, EventArgs e)
        {

        }
    }
}
