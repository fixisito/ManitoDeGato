using ManitoDeGato.Modelos;

namespace ManitoDeGato.Repositorios
{
    public class RepositorioServicios : IRepositorio<Servicio>
    {
        private static readonly List<Servicio> _lista      = new();
        private static          int            _contadorId = 1;

        public void Agregar(Servicio entidad)
        {
            entidad.Id = _contadorId++;
            _lista.Add(entidad);
        }

        public void Eliminar(int id)
        {
            var elemento = _lista.FirstOrDefault(s => s.Id == id);
            if (elemento != null) _lista.Remove(elemento);
        }

        public void Modificar(Servicio entidad)
        {
            int indice = _lista.FindIndex(s => s.Id == entidad.Id);
            if (indice >= 0) _lista[indice] = entidad;
        }

        public List<Servicio> ObtenerTodos() => new(_lista);

        public Servicio? ObtenerPorId(int id) => _lista.FirstOrDefault(s => s.Id == id);
    }
}
