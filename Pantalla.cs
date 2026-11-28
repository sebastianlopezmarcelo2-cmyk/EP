namespace proyecto_de_fundamentos_de_programación
{

    public static class Pantalla
    {
        public static void mostrarEnTabla(DataGridView tabla, Alumno[] alumnos)
        {
            tabla.Columns.Clear();
            tabla.AutoGenerateColumns = true;
            tabla.DataSource = AlumnosRepositorio.aTabla(alumnos);

            tabla.ReadOnly = true;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void abrirVentana(Form actual, Form nueva)
        {
            nueva.FormClosed += (sender, e) => actual.Show();
            nueva.Show();
            actual.Hide();
        }

        public static void soloLista(ComboBox combo)
        {
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
