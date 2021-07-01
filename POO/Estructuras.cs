using POO.Entidades;

namespace POO.Entidades
{
    public class CPunto
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public struct SPunto
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}

namespace POO.Presentacion
{
    public static class Estructuras
    {
        #pragma warning disable RCS1169,RCS1213,IDE0044,IDE0051
        private static CPunto cp3;
        #pragma warning restore RCS1169,RCS1213,IDE0044,IDE0051
        private static SPunto sp3;
        public static void Main()
        {
            var cp = new CPunto
            {
                X = 1,
                Y = 2
            };

            var cp2 = cp; // Copia la referencia al mismo objeto

            cp.X = 5;

            System.Console.WriteLine(cp2.X);

            #pragma warning disable IDE0059
            cp = null;
            #pragma warning restore IDE0059

            // System.Console.WriteLine(cp3.X); // No se ha inicializado el objeto: NullReferenceException

            var sp = new SPunto
            {
                X = 1,
                Y = 2
            };

            var sp2 = sp; // Copia EL OBJETO COMPLETO

            sp.X = 5;

            System.Console.WriteLine(sp2.X);

            System.Console.WriteLine(sp3.X);

            // sp = null; // No se puede asignar null a una estructura SALVO que usemos en la declaración de la variable ?

            SPunto? sp4 = null;

            System.Console.WriteLine(sp4);
            System.Console.WriteLine((5).Equals(5));
        }
    }
}