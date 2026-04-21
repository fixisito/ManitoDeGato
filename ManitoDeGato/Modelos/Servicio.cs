namespace ManitoDeGato.Modelos
{
    public class Servicio
    {
        public int     Id               { get; set; }
        public string  Nombre          { get; set; } = string.Empty;
        public string  Categoria       { get; set; } = string.Empty;
        public decimal Precio          { get; set; }
        public int     DuracionMinutos { get; set; }
    }
}
