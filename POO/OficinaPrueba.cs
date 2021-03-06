using POO.Entidades;
using con=System.Console;

namespace POO.Presentacion
{
    public static class OficinaPrueba {
        public static void Main() {
            var oficina = new Oficina("Bilbao");

            oficina.Agregar(new Persona(nombre: "Pepito"));
            oficina.Agregar(new Persona(1, "Juanito"));
            oficina.Agregar(new Persona(nombre: "Pepe"));
            oficina.Agregar(new Persona(5, "Javier Lete"));
            //oficina.Agregar(null);

            System.Console.WriteLine(oficina[2]);
            System.Console.WriteLine(oficina["uan"]);

            foreach (var persona in oficina.Personas)
            {
                con.WriteLine(persona.Texto);
            }
        }
    }
}