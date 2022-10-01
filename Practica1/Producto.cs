using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Producto
    {
        public string Descripcion { get; set; }
        public int Id { get; set; }
        public double Precio { get; set; }
        public Producto(string Descripcion, int Id, double Precio)
        {
            this.Descripcion = Descripcion;
            this.Id = Id;
            this.Precio = Precio;
        }
    }
}
