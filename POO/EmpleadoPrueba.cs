using System;
using POO.Entidades;

namespace POO.Presentacion
{
    class EmpleadoPrueba
    {
        static void Main()
        {
            var empleado = new Empleado(2, "Javier", "12345678Z");

            Console.WriteLine(empleado.Texto);

            empleado.Nombre = "Pepe";
            empleado.Dni = "12345678G";

            Console.WriteLine(empleado.ATexto());
            Console.WriteLine(empleado.Dni);

            var empleado2 = new Empleado(new Persona(), "87654321A");

            Console.WriteLine(empleado2.ATexto());
            Console.WriteLine(empleado2.Dni);

        }
    }
}
