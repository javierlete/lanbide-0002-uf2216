using System;
using POO.Entidades;

namespace POO.Presentacion
{
    public static class Parametros
    {
        public static void Main()
        {
            int x = 1, y = 2;

            Intercambiar(ref x, ref y);

            System.Console.WriteLine($"{x},{y}");

            const double a = 1.0, b = -2.0, c = -3.0;
            EcuacionCuadratica(a, b, c, out double x1, out double x2);

            System.Console.WriteLine($"{a}x2 + {b}x + {c} = {x1},{x2}");

            var sp = new SPunto() { X = 1, Y = 2 };

            Intercambiar(sp);

            System.Console.WriteLine($"{sp.X},{sp.Y}");

            var cp = new CPunto() { X = 1, Y = 2 };

            Intercambiar(cp);

            System.Console.WriteLine($"{cp.X},{cp.Y}");
        }

        private static void Intercambiar(SPunto punto)
        {
            int z = punto.X;
            punto.X = punto.Y;
            punto.Y = z;
        }

        private static void Intercambiar(CPunto punto)
        {
            int z = punto.X;
            punto.X = punto.Y;
            punto.Y = z;

            // punto = new CPunto() { X = 6, Y = 7 };
        }

        private static void Intercambiar(ref int a, ref int b)
        {
            int z = a;
            a = b;
            b = z;
        }
        // x = ax2 + bx + c;
        private static void EcuacionCuadratica(in double a, in double b, in double c, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            x2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
        }
    }
}