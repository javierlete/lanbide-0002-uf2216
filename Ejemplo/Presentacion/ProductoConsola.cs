using System.Linq;
using System;
using System.Collections.Generic;
using Ejemplo.Entidades;

namespace Ejemplo.Presentacion
{
    public static class ProductoConsola
    {
        private enum Opcion { Salir, Listado, Agregar, Modificar, Borrar };
        private static readonly Dictionary<long, Producto> productos = new Dictionary<long, Producto>() {
                { 1L, new Producto(1L, "Ratón", 12.34m, DateTime.Now) },
                { 2L, new Producto(2L, "Monitor", 123.34m, DateTime.Now) },
                { 3L, new Producto(3L, "Portátil", 1234.34m, DateTime.Now) },
                { 4L, new Producto(4L, "Webcam", 123.34m, DateTime.Now) },
            };
        public static void Main()
        {

            Opcion opcion;

            do
            {
                MostrarMenu();

                opcion = PedirOpcion();

                ProcesarOpcion(opcion);
            } while (opcion != Opcion.Salir);
        }

        private static void MostrarMenu()
        {
            foreach (var opcion in Enum.GetNames(typeof(Opcion)))
            {
                System.Console.WriteLine($"{(int)Enum.Parse(typeof(Opcion), opcion)}. {opcion}");
            }
        }

        private static Opcion PedirOpcion()
        {
            System.Console.Write("Por favor selecciona una opción: ");
            var opcion = Console.ReadLine();

            return (Opcion)int.Parse(opcion);
        }

        private static void ProcesarOpcion(Opcion opcion)
        {
            switch (opcion)
            {
                case Opcion.Salir:
                    System.Console.WriteLine("Hasta pronto");
                    break;
                case Opcion.Listado:
                    Listado();
                    break;
                case Opcion.Agregar:
                    Agregar();
                    break;
                case Opcion.Modificar:
                    Modificar();
                    break;
                case Opcion.Borrar:
                    Borrar();
                    break;
                default:
                    System.Console.WriteLine("Opción no reconocida");
                    break;
            }
        }

        private static void Listado()
        {
            foreach (var producto in productos.Values)
            {
                System.Console.WriteLine(producto);
            }
        }

        private static void Agregar()
        {
            var producto = new Producto
            {// TODO: Revisar qué pasa si la colección no tiene elementos inicialmente
                Id = productos.Keys.Last() + 1L,
                Nombre = PedirDato("Nombre"),
                Precio = decimal.Parse(PedirDato("Precio")),
                FechaCaducidad = DateTime.Parse(PedirDato("Fecha de caducidad"))
            };

            productos.Add(producto.Id.Value, producto);
        }

        private static string PedirDato(string dato)
        {
            System.Console.Write(dato + ": ");
            return Console.ReadLine();
        }

        private static void Modificar()
        {
            var producto = new Producto
            {
                // TODO: Revisar qué pasa si la colección no tiene elementos inicialmente
                Id = long.Parse(PedirDato("Id")),
                Nombre = PedirDato("Nombre"),
                Precio = decimal.Parse(PedirDato("Precio")),
                FechaCaducidad = DateTime.Parse(PedirDato("Fecha de caducidad"))
            };

            productos[producto.Id.Value] = producto;
        }

        private static void Borrar()
        {
            productos.Remove(long.Parse(PedirDato("Id")));
        }
    }
}