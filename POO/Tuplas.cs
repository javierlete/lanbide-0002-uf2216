using System.Collections.Generic;
using System;

namespace POO.Presentacion
{
    public static class Tuplas
    {
        public static void Main()
        {
            var t = (Clave: "casa", Valor: "home");

            Console.WriteLine(t);

            var dic = new Dictionary<string, string>
            {
                { t.Clave, t.Valor }
            };

            Console.WriteLine(dic);
        }
    }
}