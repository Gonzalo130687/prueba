
using logicaDeNegocio.Entidades;
using logicaDeNegocio.InterfacesRepositorio;

namespace LogicaAccesoDatos.Lista
{
    public class RepositorioUsuario: IRepositorioUsuario
    {
        private static List<Usuario> _usuarios = new List<Usuario>();

       
        public void Add(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public IEnumerable<Usuario> GetByName(string value)
        {
            throw new NotImplementedException();
        }
    }
}
