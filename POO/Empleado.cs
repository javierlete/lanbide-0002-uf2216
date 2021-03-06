namespace POO.Entidades
{
    public abstract class Empleado : Persona
    {
        protected Empleado(long id, string nombre, string dni) : base(id, nombre)
        {
            Dni = dni;
        }

        // public Empleado(Persona persona, string dni): base(persona) { 
        //     Dni = dni;
        // }

        protected Empleado(Persona persona, string dni) : this(persona.Id, persona.Nombre, dni) { }

        protected Empleado(Empleado empleado) : this(empleado.Id, empleado.Nombre, empleado.Dni) { }

        // public Empleado() : base() {}
        public string Dni { get; set; }

        public abstract decimal SueldoMensual { get; }

        // public abstract decimal GetSueldoMensual();

        // public new string ATexto()
        public override string ATexto()
        {
            return base.ATexto() + "," + Dni;
        }

        public override string ToString()
        {
            return base.ToString() + $" {Dni}";
        }
    }
}
