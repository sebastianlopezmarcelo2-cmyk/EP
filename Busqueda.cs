namespace proyecto_de_fundamentos_de_programación
{
    public static class Busqueda
    {

        public static int buscarPorCodigo(Alumno[] alumnos, string codigo)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (string.Equals(alumnos[i].Codigo, codigo.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        public static Alumno[] buscarPorTexto(Alumno[] alumnos, string texto)
        {
            string buscado = normalizar(texto);
            List<Alumno> encontrados = new List<Alumno>();

            foreach (Alumno a in alumnos)
            {
                string nombreCompleto = normalizar(a.Nombre + " " + a.Apellido);

                if (normalizar(a.Codigo) == buscado || nombreCompleto.Contains(buscado))
                {
                    encontrados.Add(a);
                }
            }
            return encontrados.ToArray();
        }


        public static Alumno[] filtrarPorAula(Alumno[] alumnos, string aula)
        {
            List<Alumno> resultado = new List<Alumno>();
            foreach (Alumno a in alumnos)
            {
                if (a.Aula == aula)
                {
                    resultado.Add(a);
                }
            }
            return resultado.ToArray();
        }

        public static bool existeAlumno(Alumno[] alumnos, string nombre, string apellido)
        {
            foreach (Alumno a in alumnos)
            {
                if (normalizar(a.Nombre) == normalizar(nombre) &&
                    normalizar(a.Apellido) == normalizar(apellido))
                {
                    return true;
                }
            }
            return false;
        }

        public static string normalizar(string texto)
        {
            string resultado = "";
            foreach (char c in texto.Trim().ToLowerInvariant())
            {
                switch (c)
                {
                    case 'á': resultado += 'a'; break;
                    case 'é': resultado += 'e'; break;
                    case 'í': resultado += 'i'; break;
                    case 'ó': resultado += 'o'; break;
                    case 'ú': resultado += 'u'; break;
                    case 'ü': resultado += 'u'; break;
                    case 'ñ': resultado += 'n'; break;
                    default: resultado += c; break;
                }
            }
            return resultado;
        }
    }
}
