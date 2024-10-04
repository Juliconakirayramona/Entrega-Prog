using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IServiciosRepositorio
    {
        List<Servicios> Listar();
        Servicios Guardar(Servicios entidad);
        Servicios Modificar(Servicios entidad);
        Servicios Borrar(Servicios entidad);
    }
}
