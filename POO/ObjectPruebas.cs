using System;
using POO.Entidades;

// POO.Presentacion.ObjectPruebas.Main()
namespace POO.Presentacion
{
    public static class ObjectPruebas
    {
        public static void Main()
        {
            object o = new object();
            object o2 = new object();

            Console.WriteLine(o.Equals(o));
            Console.WriteLine(o.Equals(o2));

            Console.WriteLine(o.GetHashCode());
            Console.WriteLine(o2.GetHashCode());

            Console.WriteLine(o.GetType());

            Console.WriteLine(o.ToString());

            var p = new Persona();

            Console.WriteLine(p.ToString());

            Console.WriteLine(p);

            Console.WriteLine("La persona tiene los siguientes datos: " + p);

            var p2 = new Persona();

            Console.WriteLine(p2);

            Console.WriteLine(p == p2);

            Console.WriteLine(p.Equals(p2));

            Console.WriteLine(p.GetHashCode());

            Console.WriteLine(p2.GetHashCode());

            // Persona.Contador = 50;

            Console.WriteLine(Persona.Contador);

            Console.WriteLine(Persona.CompararAlfabeticamente(p, p2));

            p.Nombre = "A";
            Console.WriteLine(Persona.CompararAlfabeticamente(p, p2));

            p.Nombre = "Z";
            Console.WriteLine(Persona.CompararAlfabeticamente(p, p2));
        }
    }
}