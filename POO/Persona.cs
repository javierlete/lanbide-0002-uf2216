using System;

namespace POO.Entidades
{
    class Persona
    {
        // private long id;
        public long Id { get; set; }
        private string nombre;

        public Persona(long id = -1, string nombre = "DESCONOCIDO") {
            Id = id; Nombre = nombre;
        }

        public Persona(Persona persona): this(persona.Id, persona.Nombre) {}
        //public Persona(): this(0, "DESCONOCIDO") {}
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if(value == null) {
                    throw new Exception("No se admiten valores nulos para el nombre");
                }
                if(value.Trim().Length == 0) {
                    throw new Exception("No se admiten nombres vacíos");
                }
                nombre = value.Trim();
            }
        }

        // public long Id {
        //     get { return id; }
        //     set { id = value; }
        // }

        public string ATexto() {
            return $"{Id}: {Nombre}";
        }

        public string Texto {
            get { return ATexto(); }
        }
    }
}