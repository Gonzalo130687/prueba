using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaDeNegocio.Excepciones.Usuario
{
    internal class UsuarioException:LogicaDeNegocioException
    {
        public UsuarioException() { }
        public UsuarioException(string? message) : base(message)
        {
        }
    }
}
