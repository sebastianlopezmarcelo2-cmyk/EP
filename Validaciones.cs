using System.Globalization;

namespace proyecto_de_fundamentos_de_programación
{
    public static class Validaciones
    {
        public static string validarTexto(string valor, string campo)
        {
            string texto = valor.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return $"Ingrese {campo}.";
            }
            if (texto.Length < 2 || texto.Length > 40)
            {
                return $"{campo} debe tener entre 2 y 40 letras.";
            }
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return $"{campo} solo puede tener letras y espacios.";
                }
            }
            return "";
        }

 
        public static string validarEdad(string texto, out int edad)
        {
            if (!int.TryParse(texto.Trim(), out edad))
            {
                edad = 0;
                return "La edad debe ser un número.";
            }
            if (edad < 3 || edad > 5)
            {
                return "La edad debe estar entre 3 y 5 años.";
            }
            return "";
        }

  
        public static string validarTelefono(string valor)
        {
            string texto = valor.Trim();

            if (texto.Length != 9)
            {
                return "El teléfono debe tener 9 dígitos.";
            }
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                {
                    return "El teléfono solo puede tener números.";
                }
            }
            if (texto[0] != '9')
            {
                return "El teléfono celular debe empezar con 9.";
            }
            return "";
        }

  
        public static string validarAula(string? aula, int edad)
        {
            if (string.IsNullOrEmpty(aula) || Aulas.obtenerPosicion(aula) == -1)
            {
                return "Seleccione el aula.";
            }
            if (Aulas.edadDelAula(aula) != edad)
            {
                return $"Un niño de {edad} años no puede ir al aula de {aula}.";
            }
            return "";
        }

        // Valida formato, rango de edad y coherencia con el aula
        public static string validarRegistro(string nombre, string apellido, string edadTexto,
                                             string? aula, string apoderado, string telefono,
                                             out int edad)
        {
            edad = 0;

            string error = validarTexto(nombre, "el nombre del niño");
            if (error != "") return error;

            error = validarTexto(apellido, "el apellido del niño");
            if (error != "") return error;

            error = validarEdad(edadTexto, out edad);
            if (error != "") return error;

            error = validarAula(aula, edad);
            if (error != "") return error;

            error = validarTexto(apoderado, "el nombre del apoderado");
            if (error != "") return error;

            return validarTelefono(telefono);
        }

        public static string nombrePropio(string valor)
        {
            string[] palabras = valor.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string resultado = string.Join(" ", palabras);
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(resultado.ToLowerInvariant());
        }
    }
}
