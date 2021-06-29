using POO.Entidades;
using con=System.Console;

namespace POO.Presentacion
{
    class OficinaPrueba {
        static void Main() {
            var oficina = new Oficina("Bilbao");

            oficina.Agregar(new Persona(nombre: "Pepito"));
            oficina.Agregar(new Persona(1, "Juanito"));
            oficina.Agregar(new Persona(nombre: "Pepe"));
            oficina.Agregar(new Persona(5, "Javier Lete"));
            //oficina.Agregar(null);

            foreach (var persona in oficina.Personas)
            {
                con.WriteLine(persona.Texto);
            }
        }
    }
}