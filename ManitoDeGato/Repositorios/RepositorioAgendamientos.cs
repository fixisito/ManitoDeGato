using ManitoDeGato.Modelos;

namespace ManitoDeGato.Repositorios
{
    public class RepositorioAgendamientos : IRepositorio<Agendamiento>
    {
        private static readonly List<Agendamiento> _lista      = new();
        private static          int                _contadorId = 1;

        public void Agregar(Agendamiento entidad)
        {
            entidad.Id = _contadorId++;
            _lista.Add(entidad);
        }

        public void Eliminar(int id)
        {
            var elemento = _lista.FirstOrDefault(a => a.Id == id);
            if (elemento != null) _lista.Remove(elemento);
        }

        public void Modificar(Agendamiento entidad)
        {
            int indice = _lista.FindIndex(a => a.Id == entidad.Id);
            if (indice >= 0) _lista[indice] = entidad;
        }

        public List<Agendamiento> ObtenerTodos() => new(_lista);

        public Agendamiento? ObtenerPorId(int id) => _lista.FirstOrDefault(a => a.Id == id);
    }
}
