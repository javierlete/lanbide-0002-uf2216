namespace POO.Entidades {
    class EmpleadoPorHoras: Empleado {
        public decimal SueldoPorHora { get; set; }
        public int NumeroHorasMes { get; set; }

        public override decimal SueldoMensual => SueldoPorHora * NumeroHorasMes;

        public EmpleadoPorHoras(long id, string nombre, string dni, decimal sueldoPorHora, int numeroHorasMes) : base(id, nombre, dni) {
            SueldoPorHora = sueldoPorHora;
            NumeroHorasMes = numeroHorasMes;
        }

        public override string ToString()
        {
            return base.ToString() + $" {SueldoPorHora} x {NumeroHorasMes} = {SueldoMensual}";
        }
    }
}