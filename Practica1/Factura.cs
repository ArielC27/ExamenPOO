using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Factura : IFactura
    {
        public Cliente Cliente { get; set; }
        public List<DetalleFactura> DetalleDeFactura { get; set; }

        public Factura(Cliente Cliente, List<DetalleFactura> DetalleDeFactura)
        {
            this.Cliente = Cliente;
            this.DetalleDeFactura = DetalleDeFactura;
        }
        public int CantidadItems()
        {
            int TotalItem = 0;
            foreach (var item in DetalleDeFactura)
            {
                TotalItem += item.Cantidad;
            }
            return TotalItem;
        }
        public double Total()
        {
            double CantidadTotal = 0;
            foreach (var item in DetalleDeFactura)
            {
                CantidadTotal += item.SubTotal();
            }
            return CantidadTotal;
        }
    }
}
