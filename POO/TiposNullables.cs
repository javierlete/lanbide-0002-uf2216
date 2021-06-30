using System;

namespace POO.Presentacion {
    public static class TiposNullables {
        public static void Main() {
            #pragma warning disable RCS1020
            Nullable<int> i = null;
            #pragma warning restore RCS1020

            int? intNullable = 2;
            // bool? b = null;
            DateTime? d = DateTime.Now;

            System.Console.WriteLine(i ?? -2);
            #pragma warning disable RCS1128
            System.Console.WriteLine(intNullable.GetValueOrDefault(-5));
            #pragma warning restore RCS1128

            System.Console.WriteLine(intNullable * 5);

            if(d.HasValue) {
                System.Console.WriteLine(d.Value.Month);
            } else {
                System.Console.WriteLine("No hay mes que mostrar");
            }

            System.Console.WriteLine(d?.Month);
            System.Console.WriteLine(d.HasValue ? d?.Month.ToString() : "No hay mes");
        }
    }
}