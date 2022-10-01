namespace Practica1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Producto oProducto = new Producto("Zapatillas", 1, 50.00);
            Producto oProducto2 = new Producto("MEdias", 2, 50.00);
            Producto oProducto3 = new Producto("Algo", 3, 100.00);

            DetalleFactura oDetalleFactura = new DetalleFactura(oProducto, 1);
            DetalleFactura oDetalleFactura2 = new DetalleFactura(oProducto2, 1);
            DetalleFactura oDetalleFactura3 = new DetalleFactura(oProducto3, 2);

            List<DetalleFactura> Detalles = new List<DetalleFactura>
            {
                oDetalleFactura,oDetalleFactura2,oDetalleFactura3
            };

            Cliente Cliente1 = new Cliente(34397679, 1, "Juan Perez");

            Factura oFactura = new Factura(Cliente1, Detalles);

            Console.WriteLine(oFactura.Total());
            Console.ReadLine();

        }
    }
}