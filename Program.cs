// Ejecutar con
// dotnet watch run

using System;
using System.Collections.Generic;
using con = System.Console;

#pragma warning disable CS0162
namespace UF2216
{
    public static class Program
    {
        /// <summary>
        /// Comentario de documentación
        /// </summary>
        public static void Main()
        {
            // https://docs.microsoft.com/es-es/dotnet/csharp/

            // Comentario de línea
            /*
            Comentario
            Multi
            Línea
            */

            // TIPOS VALOR
            // https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/value-types
            // ENTEROS
            // https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
            // byte (8), short (16), int (32), long (64) (sbyte, ushort, uint, ulong)
            // System.Byte, Int16, Int32, Int64 (SByte, UInt16, UInt32, UInt64)
            // COMA FLOTANTE (IEEE754)
            // https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            // float (32), double (64)
            // System.Single, Double
            // decimal System.Decimal
            // BOOLEANO
            // bool System.Boolean
            // CARACTER
            // char System.Char

            DateTime ahora = DateTime.Now;

            Console.WriteLine("Hola a todos: " + ahora);

            // TIPOS REFERENCIA

            string nombre;

            con.Write("Dime tu nombre: ");
            nombre = con.ReadLine();

            con.WriteLine("Hola {0}, qué tal estás.", nombre);
            // C#6
            con.WriteLine($"Hola {nombre}, qué tal estás.");

            const string s1 = "Texto";
            const string s2 = "Texto";

            con.WriteLine(s1 == s2);

            // OPERADORES
            // https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/operators/

            // SENTENCIAS DE CONTROL
            // https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/statement-keywords

            const bool estaEncendido = false;

            if (estaEncendido)
            {
                con.WriteLine("Encendido");
                con.WriteLine("Qué bien");
            }
            else
            {
                con.WriteLine("Apagado");
            }

            con.WriteLine(estaEncendido);

            const string opcion = "segunda";

            if (opcion == "primera")
            {
                con.WriteLine("Has seleccionado la primera opción");
            }
            else if (opcion == "segunda")
            {
                con.WriteLine("Segunda opción");
            }
            else if (opcion == "tercera")
            {
                con.WriteLine("Tercera opción");
            }
            else
            {
                con.WriteLine("Otra opción");
            }

            switch (opcion)
            {
                case "primera":
                    con.WriteLine("Has seleccionado la primera opción");
                    break;
                case "segunda":
                    con.WriteLine("Segunda opción");
                    break;
                case "tercera":
                    con.WriteLine("Tercera opción");
                    break;
                default:
                    con.WriteLine("Otra opción");
                    break;
            }

            int mes = 4, dias;

            switch (mes)
            {
                case 2: dias = 28; break;
                case 4:
                case 6:
                case 9:
                case 11: dias = 30; break;
                default: dias = 31; break;
            }

            con.WriteLine($"El mes {mes} tiene {dias} días");

            // C# 7.0

            switch(mes) {
                case int m when m < 1 || m > 12:
                    dias = 0;
                    break;
                case int m when new List<int>{4,6,9,11}.Contains(m):
                    dias = 30;
                    break;
                default:
                    dias = 31;
                    break;
            }

            con.WriteLine($"El mes {mes} tiene {dias} días");

            // REPETITIVAS

            int contador = 0;

            // Repetitiva de 0 a n
            while (contador < 10)
            {
                con.WriteLine(++contador);
            }

            contador = 0;

            // Repetitiva de 1 a n
            do
            {
                con.WriteLine(++contador);
            } while (contador < 10);

            for (int c = 1; c <= 10; c++)
            {
                con.WriteLine(c);
            }

            // int c = 1;
            // while(c <= 10) {
            //     con.WriteLine(c);
            //     c++;
            // }

            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                con.WriteLine(arr[i]);
            }

            foreach (int dato in arr)
            {
                con.WriteLine(dato);
            }

            // for (int i = 0; i < arr.Length; i++)
            // {
            //     int dato = arr[i];
            //     con.WriteLine(dato);
            // }

            char[,] tablero = new char[8, 8];

            tablero[0, 0] = 'T';
            tablero[0, 1] = 'C';

            tablero[7, 7] = 't';

            for (int fila = 0; fila < tablero.GetLength(0); fila++)
            {
                for (int columna = 0; columna < tablero.GetLength(1); columna++)
                {
                    con.Write($"{tablero[fila, columna]} ");
                }

                con.WriteLine();
            }

            // C#3
            var textos = new List<string>() {
                "uno", "dos", "tres", "cuatro"
            };

            foreach (string texto in textos)
            {
                con.WriteLine(texto);
            }

            // IEnumerator<string> enumerador = textos.GetEnumerator();
            // string str;
            // while(enumerador.MoveNext()) {
            //     str = enumerador.Current;
            //     con.WriteLine(str);
            // }

            con.WriteLine("Fin ejemplos estructuras de control.");
        }
    }
}
#pragma warning restore CS0162