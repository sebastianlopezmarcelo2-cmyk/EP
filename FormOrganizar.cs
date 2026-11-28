namespace proyecto_de_fundamentos_de_programación
{
    public partial class FormOrganizar : Form
    {
        private ComboBox cmbOrden = new ComboBox();
        private Label lblResumen = new Label();
        private bool cargando = true; 

        public FormOrganizar()
        {
            InitializeComponent();
        }

        private void FormOrganizar_Load(object sender, EventArgs e)
        {
            Pantalla.soloLista(cmbAulas);
            cmbAulas.Items.Add("Todos");
            cmbAulas.Items.AddRange(Aulas.nombres);
            cmbAulas.SelectedIndex = 0;

            Label lblAula = new Label { Text = "Aula:", AutoSize = true, Location = new Point(196, 170) };
            Label lblOrden = new Label { Text = "Ordenar:", AutoSize = true, Location = new Point(578, 170) };

            cmbOrden.Location = new Point(650, 167);
            cmbOrden.Size = new Size(140, 28);
            Pantalla.soloLista(cmbOrden);
            cmbOrden.Items.AddRange(Ordenamiento.Criterios);
            cmbOrden.SelectedIndex = 0;
            cmbOrden.SelectedIndexChanged += cmbAulas_SelectedIndexChanged;

            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(118, 424);

            Controls.Add(lblAula);
            Controls.Add(lblOrden);
            Controls.Add(cmbOrden);
            Controls.Add(lblResumen);

            cargando = false;
            ActualizarLista();
        }


        private void cmbAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cargando)
            {
                ActualizarLista();
            }
        }


        void ActualizarLista()
        {
            Alumno[] todos = AlumnosRepositorio.cargar();
            string aula = cmbAulas.SelectedItem?.ToString() ?? "Todos";
            string criterio = cmbOrden.SelectedItem?.ToString() ?? Ordenamiento.PorCodigo;

            Alumno[] lista = todos;
            if (aula != "Todos")
            {
                lista = Busqueda.filtrarPorAula(todos, aula);
            }
            lista = Ordenamiento.ordenar(lista, criterio);
            Pantalla.mostrarEnTabla(dgvFiltrado, lista);

            if (aula == "Todos")
            {
                lblResumen.Text = $"Total de alumnos: {lista.Length}";
            }
            else
            {
                lblResumen.Text = $"Aula {aula}: {lista.Length} de {Aulas.CupoMaximo} vacantes ocupadas";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
