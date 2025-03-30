using logicaDeNegocio.Entidades;

namespace logicaDeNegocio.InterfacesRepositorio
{
    public interface IRepositorioUsuario : IRepositorio<Usuario>
    {
        IEnumerable<Usuario> GetByName(string value);
    }
}
