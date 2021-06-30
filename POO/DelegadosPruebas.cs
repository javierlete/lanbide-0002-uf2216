using System.Collections.Generic;

namespace POO.Presentacion
{
    public static class DelegadosPruebas
    {
        private delegate int operacion(int op1, int op2);
        public static void Main()
        {
            operacion op = Sumar;

            System.Console.WriteLine(op(1, 2));

            op = Restar;

            System.Console.WriteLine(op(1, 2));

            operacion[] operaciones = new operacion[4];

            operaciones[0] = Sumar;
            operaciones[1] = Restar;
#pragma warning disable RCS1048
            operaciones[2] = delegate (int a, int b) { return a * b; };
#pragma warning restore RCS1048
            operaciones[3] = (int a, int b) => a / b;

            foreach (var oper in operaciones)
            {
                MostrarResultado(1, 2, oper);
            }

            var numeros = new List<int>() {
                1, 3, 6, 3, 5, 7
            };

#pragma warning disable RCS1048
            numeros.Sort(delegate (int a, int b)
                {
                    return a > b ? -1 : (a < b ? 1 : -1);
                });
#pragma warning restore RCS1048
            foreach (var numero in numeros)
            {
                System.Console.Write(numero);
            }

            numeros.Sort((int a, int b) => a > b ? -1 : (a < b ? 1 : -1));

            foreach (var numero in numeros)
            {
                System.Console.Write(numero);
            }
        }

        private static void MostrarResultado(int a, int b, operacion op)
        {
            System.Console.WriteLine(op(a, b));
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            return a - b;
        }
    }
}