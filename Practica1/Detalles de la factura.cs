using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class DetalleFactura
    {
        public int Cantidad { get; set; }
        public Producto Producto { get; set; }
        public DetalleFactura (Producto Producto, int Cantidad)
        {
            this.Producto = Producto;
            this.Cantidad = Cantidad;
        }
        public double SubTotal()
        {
            return (Convert.ToDouble(Cantidad) * Producto.Precio);
        }
    }
}


