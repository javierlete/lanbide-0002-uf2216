namespace POO.Presentacion
{
    public static class MetodosDeExtension
    {
        public static void Main()
        {
            const string str = "123456789";

            System.Console.WriteLine(str.Substring(0, 5));

            System.Console.WriteLine(str.Izquierda(5));
        }
        public static string Izquierda(this string str, int numeroCaracteres)
        {
            return str.Substring(0, numeroCaracteres);
        }
    }
}