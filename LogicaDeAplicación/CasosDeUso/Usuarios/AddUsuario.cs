

using CasosDeUsoCompartida.DTOs.Usuarios;
using CasosDeUsoCompartida.Interfaces.Usuario;
using logicaDeNegocio.InterfacesRepositorio;
namespace LogicaDeAplicación.CasosDeUso.Usuario
{

    public class AddUsuario : IAdd<UsuarioDTO>
    {
        private IRepositorioUsuario _repo;

        public AddUsuario(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public void Execute(UsuarioDTO usuario)
        {
            logicaDeNegocio.Entidades.Usuario unU = new logicaDeNegocio.Entidades.Usuario(
             usuario.Id, usuario.Email, usuario.Contrasena);

            _repo.Add(unU);
        }

        
    }
}
