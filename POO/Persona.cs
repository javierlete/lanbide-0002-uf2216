using System;

namespace POO.Entidades
{
    class Persona
    {
        public static long Contador { get; private set; } = 0;
        // private static long contador = 0;

        // public static long Contador {
        //     get { return contador; }
        // }
        // private long id;
        public long Id { get; set; }
        private string nombre;

        public Persona(long id = -1, string nombre = "DESCONOCIDO") {
            Contador++;
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
                    throw new EntidadesException("No se admiten valores nulos para el nombre");
                }
                if(value.Trim().Length == 0) {
                    throw new EntidadesException("No se admiten nombres vacíos");
                }
                nombre = value.Trim();
            }
        }

        // public long Id {
        //     get { return id; }
        //     set { id = value; }
        // }

        // public string ATexto() {
        public virtual string ATexto() {
            return $"{Id}: {Nombre}";
        }

        public string Texto {
            get { return ATexto(); }
        }

        public override string ToString()
        {
            return $"{Id}: {Nombre}";
        }

        public override bool Equals(object obj)
        {
            if((object)this == obj) {
                return true;
            }
            
            Persona p = obj as Persona;
            
            if(p is null) {
                return false;
            }

            return Id == p.Id && Nombre == p.Nombre;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Nombre.GetHashCode();
        }

        public static bool operator==(Persona p1, Persona p2) {
            if(p1 is null && p2 is null) { return true; }
            if(p1 is null) { return false; }
            return p1.Equals(p2);
        }

        public static bool operator!=(Persona p1, Persona p2) {
            return !p1.Equals(p2);
        }

        public static int CompararAlfabeticamente(Persona p1, Persona p2) {
            return string.Compare(p1.Nombre, p2.Nombre); //p1.Nombre.CompareTo(p2.Nombre);
        }
    }
}