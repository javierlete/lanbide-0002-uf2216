using System;

namespace POO.Presentacion
{
    public static class Enumeraciones
    {

        public enum Color { Rojo, Verde, Azul }
        public static void Main()
        {
            Color color = Color.Rojo;

            Console.WriteLine(color);

            string texto = color.ToString();

            Console.WriteLine(texto);

            if (Enum.TryParse(Console.ReadLine(), out color))
            {
                Console.WriteLine(color);
            }
            else
            {
                Console.WriteLine("Error");
            }

            color = (Color)2;

            Console.WriteLine(color);
        }
    }
}