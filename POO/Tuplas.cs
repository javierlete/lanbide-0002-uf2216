using System.Collections.Generic;
using System;
class Tuplas {
    static void Mainn() {
        var t = (Clave: "casa", Valor: "home");

        Console.WriteLine(t);

        var dic = new Dictionary<string, string>();
        
        dic.Add(t.Clave, t.Valor);
    }
}