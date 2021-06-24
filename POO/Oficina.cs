using System.Collections.Generic;

namespace POO.Entidades {
    class Oficina {
        private List<Persona> personas = new List<Persona>();

        public string Nombre { get; set; }

        public Oficina(string nombre) {
            Nombre = nombre;
        }

        public void Agregar(Persona persona) {
            if(persona == null) {
                throw new System.Exception("No se aceptan nulos");
            }
            if(persona.Nombre.ToUpper() == "DESCONOCIDO") {
                throw new System.Exception("No se admiten desconocidos");
            }
            personas.Add(persona);
        }

        public IEnumerable<Persona> Personas {
            get { return personas; }
        }
    }
}