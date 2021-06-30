using System.Collections.Generic;

namespace POO.Entidades {
    public class Oficina {
        private readonly List<Persona> personas = new List<Persona>();

        public string Nombre { get; set; }

        public Oficina(string nombre) {
            Nombre = nombre;
        }

        public void Agregar(Persona persona) {
            if(persona == null) {
                throw new EntidadesException("No se aceptan nulos");
            }
            #pragma warning disable RCS1155
            if(persona.Nombre.ToUpper() == "DESCONOCIDO") {
                throw new EntidadesException("No se admiten desconocidos");
            }
            #pragma warning restore RCS1155
            personas.Add(persona);
        }

        public IEnumerable<Persona> Personas {
            get { return personas; }
        }
    }
}