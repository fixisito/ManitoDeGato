namespace ManitoDeGato.Repositorios
{
    public interface IRepositorio<T>
    {
        void   Agregar(T entidad);
        void   Eliminar(int id);
        void   Modificar(T entidad);
        List<T> ObtenerTodos();
        T?     ObtenerPorId(int id);
    }
}
