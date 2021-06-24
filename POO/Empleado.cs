namespace POO.Entidades
{
    class Empleado: Persona
    {
        public Empleado(long id, string nombre, string dni): base(id, nombre) {
            Dni = dni;
        }

        // public Empleado(Persona persona, string dni): base(persona) { 
        //     Dni = dni;
        // }
        
        public Empleado(Persona persona, string dni): this(persona.Id, persona.Nombre, dni) {}

        // public Empleado() : base() {}
        public string Dni { get; set; }
    }
}
