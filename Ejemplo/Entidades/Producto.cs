using System;

namespace Ejemplo.Entidades
{
    public class Producto
    {
        #region Autopropiedades
        public long? Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime? FechaCaducidad { get; set; }
        #endregion

        #region Constructores
        public Producto(long? id, string nombre, decimal precio, DateTime? fechaCaducidad) {
            Id = id; Nombre = nombre; Precio = precio; FechaCaducidad = fechaCaducidad;
        }

        public Producto() {}
        #endregion

        #region overrides
        public override string ToString()
        {
            return $"{Id},{Nombre},{Precio},{FechaCaducidad}";
        }
        #endregion
    }
}