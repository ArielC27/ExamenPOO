using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class B : Factura
    {
        public B(Cliente Cliente, List<DetalleFactura> DetalleDeFactura) : base(Cliente, DetalleDeFactura)
        {
        }
    }
}
