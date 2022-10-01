using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class A : Factura
    {
        public A(Cliente Cliente, List<DetalleFactura> DetalleDeFactura) : base(Cliente, DetalleDeFactura)
        {
        }
    }
}
