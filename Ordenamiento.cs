namespace proyecto_de_fundamentos_de_programación
{

    public static class Ordenamiento
    {
        public const string PorCodigo = "Código";
        public const string PorApellido = "Apellido";
        public const string PorEdad = "Edad";

        public static readonly string[] Criterios = { PorCodigo, PorApellido, PorEdad };

        // Ordena una copia del arreglo usando el algoritmo de selección
        public static Alumno[] ordenar(Alumno[] original, string criterio)
        {
            Alumno[] copia = (Alumno[])original.Clone();

            for (int i = 0; i < copia.Length - 1; i++)
            {
                int posicionMenor = i;

                for (int j = i + 1; j < copia.Length; j++)
                {
                    if (comparar(copia[j], copia[posicionMenor], criterio) < 0)
                    {
                        posicionMenor = j;
                    }
                }

                if (posicionMenor != i)
                {
                    Alumno temporal = copia[i];
                    copia[i] = copia[posicionMenor];
                    copia[posicionMenor] = temporal;
                }
            }
            return copia;
        }

        private static int comparar(Alumno x, Alumno y, string criterio)
        {
            int resultado;

            switch (criterio)
            {
                case PorApellido:
                    resultado = string.Compare(Busqueda.normalizar(x.Apellido + " " + x.Nombre),
                                               Busqueda.normalizar(y.Apellido + " " + y.Nombre),
                                               StringComparison.Ordinal);
                    break;
                case PorEdad:
                    resultado = x.Edad.CompareTo(y.Edad);
                    break;
                default:    
                    resultado = string.Compare(x.Codigo, y.Codigo, StringComparison.Ordinal);
                    break;
            }

            if (resultado == 0)     
            {
                resultado = string.Compare(x.Codigo, y.Codigo, StringComparison.Ordinal);
            }
            return resultado;
        }
    }
}
