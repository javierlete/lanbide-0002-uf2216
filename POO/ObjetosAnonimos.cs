namespace POO.Presentacion {
    public static class ObjetosAnonimos {
        public static void Main() {
            var obj = new { Id = 1, Nombre = "Javier", Apellidos = "Lete" };
            var obj2 = new { Id = 1, Nombre = "Javier", Apellidos = "Lete" };

            System.Console.WriteLine(obj.Nombre + " " + obj.Apellidos);

            System.Console.WriteLine(obj);

            System.Console.WriteLine(obj.GetType());

            System.Console.WriteLine(obj.Equals(obj2));

            System.Console.WriteLine(obj == obj2);

            System.Console.WriteLine(obj.GetHashCode());

            System.Console.WriteLine(obj2.GetHashCode());

            System.Console.WriteLine(obj is object);
        }
    }
}