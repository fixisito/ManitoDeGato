namespace ManitoDeGato.Modelos
{
    public class Agendamiento
    {
        public int      Id             { get; set; }
        public string   NombreCliente  { get; set; } = string.Empty;
        public string   RutEstilista   { get; set; } = string.Empty;
        public int      IdServicio     { get; set; }
        public DateTime Fecha          { get; set; } = DateTime.Now;
        public string   Estado         { get; set; } = "Pendiente";
    }
}
