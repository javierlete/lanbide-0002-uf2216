using System.Text.RegularExpressions;

namespace POO.Presentacion {
    public static class ExpresionesRegulares {
        public static void Main() {
            const string ruta = @"C:\nuevos\trabajos";

            System.Console.WriteLine(ruta);

            const string DNI = @"^[\dXYZ]\d{7}[A-Z]$";
            var regexDni = new Regex(DNI);

            System.Console.WriteLine(regexDni.IsMatch("12345678Z"));
            System.Console.WriteLine(regexDni.IsMatch("aasddf12345678Z"));

            var regexNombre = new Regex(@"^\p{L}{2,}$");

            System.Console.WriteLine(regexNombre.IsMatch("Françès"));
        }
    }
}