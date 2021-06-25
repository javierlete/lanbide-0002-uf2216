using System;
using System.Collections.Generic;
using System.Reflection;
using POO.Entidades;

namespace POO.Presentacion
{
    class PooPruebas
    {
        static void Mainn()
        {
            var p1 = new Persona();
            var p2 = new Persona(p1);

            p1.Nombre = "Modificado";

            Console.WriteLine(p1.Texto);
            Console.WriteLine(p2.Texto);

            var oficina = new Oficina("Bilbao");
            Persona persona;

            for (var c = 1; c <= 10; c++)
            {
                persona = new Persona(c, "Nombre" + c);

                oficina.Agregar(persona);
            }

            foreach (var p in oficina.Personas)
            {
                Console.WriteLine(p.Texto);
            }

            var e1 = new Empleado(7, "Javier Lete", "12345678Z");

            Persona pe1 = e1;

            Console.WriteLine(pe1.Nombre);
            // Console.WriteLine(pe1.Dni);

            Empleado e2 = (Empleado)pe1;

            Console.WriteLine(e2.Dni);

            if (p1 is Empleado)
            {
                Empleado e3 = (Empleado)p1;
                Console.WriteLine(e3.Texto);
            }

            Empleado e4 = p1 as Empleado;

            Console.WriteLine(e4 == null);

            foreach(PropertyInfo prop in e2.GetType().GetProperties() ) {//typeof(Empleado).GetProperties()) {
                Console.WriteLine(prop);
            }

            oficina.Agregar(new Empleado(10, "Pepe", "12341234Z"));

            foreach (Persona p in oficina.Personas)
            {
                Console.WriteLine(p.Texto);
            }
        }
    }
}