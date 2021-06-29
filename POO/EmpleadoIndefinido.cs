namespace POO.Entidades
{
    class EmpleadoIndefinido : Empleado
    {
        public decimal SueldoAnual { get; set; }
        public int NumeroPagas { get; set; }

        public override decimal SueldoMensual => SueldoAnual / NumeroPagas;

        // public override decimal SueldoMensual {
        //     get { return SueldoAnual / NumeroPagas; }
        // }

        public EmpleadoIndefinido(long id, string nombre, string dni, decimal sueldoAnual, int numeroPagas) : base(id, nombre, dni)
        {
            SueldoAnual = sueldoAnual;
            NumeroPagas = numeroPagas;
        }

        public override string ToString()
        {
            return base.ToString() + $" {SueldoAnual} / {NumeroPagas} = {SueldoMensual}";
        }
    }
}