using ManitoDeGato.Modelos;

namespace ManitoDeGato.Repositorios
{
    public class RepositorioProductos : IRepositorio<Producto>
    {
        private static readonly List<Producto> _lista      = new();
        private static          int            _contadorId = 1;

        public void Agregar(Producto entidad)
        {
            entidad.Id = _contadorId++;
            _lista.Add(entidad);
        }

        public void Eliminar(int id)
        {
            var elemento = _lista.FirstOrDefault(p => p.Id == id);
            if (elemento != null) _lista.Remove(elemento);
        }

        public void Modificar(Producto entidad)
        {
            int indice = _lista.FindIndex(p => p.Id == entidad.Id);
            if (indice >= 0) _lista[indice] = entidad;
        }

        public List<Producto> ObtenerTodos() => new(_lista);

        public Producto? ObtenerPorId(int id) => _lista.FirstOrDefault(p => p.Id == id);
    }
}
