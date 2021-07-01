using System;
using POO.Entidades;

namespace POO.Presentacion
{
    public static class PersonaPrueba
    {
        public static void Main()
        {
            Persona persona = new Persona(5, "    Javier Lete   ");

            // persona.Id = 5;
            // persona.Nombre = "     Javier Lete  ";

            Console.WriteLine(persona);
            Console.WriteLine(persona.Id);
            Console.WriteLine(persona.Nombre);

            var persona2 = new Persona()
            {
                Id = 6,
                Nombre = "    Pepe Pérez  "
            };

            Console.WriteLine(persona2.ATexto());

            var persona3 = new Persona();

            Console.WriteLine(persona3.ATexto());

            var persona4 = new Persona(4);

            Console.WriteLine(persona4.ATexto());

            var persona5 = new Persona(nombre: "Sólo nombre");

            Console.WriteLine(persona5.ATexto());

            persona5.Id++;
            //persona5.setId(persona5.getId() + 1);

            Console.WriteLine(persona5.Texto);

            var persona6 = new Persona(persona5)
            {
                Id = 24
            };

            Console.WriteLine(persona5);
            Console.WriteLine(persona6);

            var p1 = new Persona();

            p1["id"] = 10L;
            p1["nombre"] = "Indexado";

            System.Console.WriteLine(p1);
            System.Console.WriteLine(p1["id"]);
            System.Console.WriteLine(p1["nombre"]);
        }
    }
}