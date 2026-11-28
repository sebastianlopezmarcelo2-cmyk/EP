namespace proyecto_de_fundamentos_de_programación
{

    public static class Aulas
    {
        public const int CupoMaximo = 15;

        public static readonly string[] nombres = { "3 años A", "3 años B", "4 años", "5 años" };
        public static readonly int[] edades = { 3, 3, 4, 5 };

        public static int obtenerPosicion(string aula)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] == aula)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int edadDelAula(string aula)
        {
            int posicion = obtenerPosicion(aula);
            if (posicion == -1)
            {
                return 0;
            }
            return edades[posicion];
        }

        public static int ocupados(Alumno[] alumnos, string aula)
        {
            int contador = 0;
            foreach (Alumno a in alumnos)
            {
                if (a.Aula == aula)
                {
                    contador++;
                }
            }
            return contador;
        }

        public static bool hayCupo(Alumno[] alumnos, string aula)
        {
            return ocupados(alumnos, aula) < CupoMaximo;
        }
    }
}
