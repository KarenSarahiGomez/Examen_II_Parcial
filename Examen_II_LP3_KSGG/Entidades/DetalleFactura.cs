namespace Entidades
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public string Tiposoporte { get; set; }
        public string Descripcionsolicitud { get; set; }
        public string Descripcionrespuesta { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

        public DetalleFactura()
        {
        }

        public DetalleFactura(int id, int idFactura, string tiposoporte, string descripcionsolicitud,
            string descripcionrespuesta, decimal precio, decimal total)
        {
            Id = id;
            IdFactura = idFactura;
            Tiposoporte = tiposoporte;
            Descripcionsolicitud = descripcionsolicitud;
            Descripcionrespuesta = descripcionrespuesta;
            Precio = precio;
            Total = total;
        }
    }
}
