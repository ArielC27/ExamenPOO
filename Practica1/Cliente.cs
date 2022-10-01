using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Cliente
    {
        public int Documento { get; set; }
        public int NumeroCliente { get; set; }
        public string NombreCompleto { get; set; }
        public Factura Facturas { get; set; }

        public Cliente(int documento, int numeroCliente, string nombreCompleto)
        {
            Documento = documento;
            NumeroCliente = numeroCliente;
            NombreCompleto = nombreCompleto;
        }
    }
}
