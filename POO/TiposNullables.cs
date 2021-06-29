using System;

namespace POO.Presentacion {
    class TiposNullables {
        static void Main() {
            Nullable<int> i = null;
            
            int? intNullable = 2;
            // bool? b = null;
            DateTime? d = DateTime.Now;

            System.Console.WriteLine(i.GetValueOrDefault(-2));
            System.Console.WriteLine(intNullable.GetValueOrDefault(-5));

            System.Console.WriteLine(intNullable * 5);

            if(d.HasValue) {
                System.Console.WriteLine(d.Value.Month);
            } else {
                System.Console.WriteLine("No hay mes que mostrar");
            }

            System.Console.WriteLine(d?.Month);
            System.Console.WriteLine(d.HasValue ? d?.Month : "No hay mes");
        }
    }
}