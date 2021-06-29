using System;
using POO.Entidades;

namespace POO.Presentacion
{
    class EmpleadoPrueba
    {
        static void Mainn()
        {
            var empleado = new EmpleadoIndefinido(2, "Javier", "12345678Z", 23456m, 14);

            Console.WriteLine(empleado.Texto);

            empleado.Nombre = "Pepe";
            empleado.Dni = "12345678G";

            Console.WriteLine(empleado);

            Console.WriteLine(empleado.SueldoMensual);

            //Console.WriteLine(empleado.Dni);

            var empleado2 = new EmpleadoPorHoras(4, "Pepe", "87654321A", 20m, 40);// new Persona(), "87654321A");

            Console.WriteLine(empleado2);
            //Console.WriteLine(empleado2.Dni);

            Oficina o = new Oficina("Bilbao");

            o.Agregar(empleado);
            o.Agregar(empleado2);

            decimal totalSueldosMensuales = 0;

            foreach (var p in o.Personas)
            {
                if(p is Empleado e) {
                    totalSueldosMensuales += e.SueldoMensual;
                }
            }

            System.Console.WriteLine(totalSueldosMensuales);
        }
    }
}
