using ManitoDeGato.Modelos;

namespace ManitoDeGato.Repositorios
{
    public class RepositorioEstilistas : IRepositorio<Estilista>
    {
        private static readonly List<Estilista> _lista      = new();
        private static          int             _contadorId = 1;

        public void Agregar(Estilista entidad)
        {
            entidad.Id = _contadorId++;
            _lista.Add(entidad);
        }

        public void Eliminar(int id)
        {
            var elemento = _lista.FirstOrDefault(e => e.Id == id);
            if (elemento != null) _lista.Remove(elemento);
        }

        public void Modificar(Estilista entidad)
        {
            int indice = _lista.FindIndex(e => e.Id == entidad.Id);
            if (indice >= 0) _lista[indice] = entidad;
        }

        public List<Estilista> ObtenerTodos() => new(_lista);

        public Estilista? ObtenerPorId(int id) => _lista.FirstOrDefault(e => e.Id == id);

        public Estilista? ObtenerPorRut(string rut) =>
            _lista.FirstOrDefault(e => e.Rut.Equals(rut, StringComparison.OrdinalIgnoreCase));

        public bool ExisteRut(string rut) => _lista.Any(e => e.Rut.Equals(rut, StringComparison.OrdinalIgnoreCase));
    }
}
