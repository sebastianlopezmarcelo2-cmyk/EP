namespace proyecto_de_fundamentos_de_programación
{
    public class Alumno
    {
        public string Codigo { get; set; } = "";     
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public int Edad { get; set; }
        public string Aula { get; set; } = "";
        public string Apoderado { get; set; } = "";
        public string Telefono { get; set; } = "";

        
        public string aLinea()
        {
            return string.Join("|", Codigo, Nombre, Apellido, Edad, Aula, Apoderado, Telefono);
        }

        
        public static Alumno? desdeLinea(string linea, int numeroLinea)
        {
            string[] partes = linea.Split('|');

            int desplazamiento;     
            string codigo;

            if (partes.Length == 7)
            {
                desplazamiento = 1;
                codigo = partes[0];
            }
            else if (partes.Length == 6)
            {
                desplazamiento = 0;
                codigo = AlumnosRepositorio.generarCodigo(numeroLinea);
            }
            else
            {
                return null;
            }

            if (!int.TryParse(partes[2 + desplazamiento], out int edad))
            {
                return null;
            }

            string aula = partes[3 + desplazamiento];
            if (aula == "3 años")       
            {
                aula = "3 años A";
            }

            return new Alumno
            {
                Codigo = codigo,
                Nombre = partes[0 + desplazamiento],
                Apellido = partes[1 + desplazamiento],
                Edad = edad,
                Aula = aula,
                Apoderado = partes[4 + desplazamiento],
                Telefono = partes[5 + desplazamiento]
            };
        }
    }
}
