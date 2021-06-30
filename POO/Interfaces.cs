using POO.Interfaces;

namespace POO.Presentacion
{
    public static class InterfacesPruebas
    {
        public static void Main()
        {
            IRodable[] rodables = new IRodable[2];

            rodables[0] = new Naranja();
            rodables[1] = new Balon();

            foreach (var rodable in rodables)
            {
                IComestible comestible = rodable as IComestible;

                comestible?.Comer();
                rodable.Rodar();
                comestible?.Comer();
            }
        }
    }
}

namespace POO.Interfaces
{
    public interface IRodable { void Rodar(); }
    public interface IComestible { void Comer(); }
    public class Fruto { }
    public class ObjetoDeporte { }
    public class Balon : ObjetoDeporte, IRodable
    {
        void IRodable.Rodar()
        {
            System.Console.WriteLine("Balón rodando");
        }
    }
    public class Naranja : Fruto, IComestible, IRodable
    {
        private bool comestible = true;
        void IComestible.Comer()
        {
            if (comestible)
            {
                System.Console.WriteLine("Ñam que rica la naranja");
            }
            else
            {
                System.Console.WriteLine("Puaj que asco...");
            }
        }

        void IRodable.Rodar()
        {
            System.Console.WriteLine("Naranja rodando");
            comestible = false;
        }
    }
}
