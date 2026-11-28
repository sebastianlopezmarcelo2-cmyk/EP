using System.Data;

namespace proyecto_de_fundamentos_de_programación
{
    public static class AlumnosRepositorio
    {
        public static readonly string ruta = Path.Combine(AppContext.BaseDirectory, "alumnosKinder.txt");

        public static string generarCodigo(int numero)
        {
            return "MAT-" + numero.ToString("0000");
        }

        // Lee alumnosKinder.txt y reconstruye el arreglo de alumnos
        public static Alumno[] cargar()
        {
            if (!File.Exists(ruta))
            {
                return new Alumno[0];
            }

            string[] lineas = File.ReadAllLines(ruta);
            List<Alumno> lista = new List<Alumno>();

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue;
                }

                Alumno? alumno = Alumno.desdeLinea(linea, lista.Count + 1);
                if (alumno != null)
                {
                    lista.Add(alumno);
                }
            }
            return lista.ToArray();
        }

        public static void guardar(Alumno alumno)
        {
            File.AppendAllText(ruta, alumno.aLinea() + Environment.NewLine);
        }

        public static string siguienteCodigo(Alumno[] alumnos)
        {
            int mayor = 0;
            foreach (Alumno a in alumnos)
            {
                string[] partes = a.Codigo.Split('-');
                if (partes.Length == 2 && int.TryParse(partes[1], out int numero) && numero > mayor)
                {
                    mayor = numero;
                }
            }
            return generarCodigo(mayor + 1);
        }

        public static DataTable aTabla(Alumno[] alumnos)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Edad");
            tabla.Columns.Add("Aula");
            tabla.Columns.Add("Apoderado");
            tabla.Columns.Add("Telefono");

            foreach (Alumno a in alumnos)
            {
                tabla.Rows.Add(a.Codigo, a.Nombre, a.Apellido, a.Edad, a.Aula, a.Apoderado, a.Telefono);
            }
            return tabla;
        }
    }
}
