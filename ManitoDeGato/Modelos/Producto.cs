namespace ManitoDeGato.Modelos
{
    public class Producto
    {
        public int     Id             { get; set; }
        public string  Nombre         { get; set; } = string.Empty;
        public string  Categoria      { get; set; } = string.Empty;
        public int     StockActual    { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
