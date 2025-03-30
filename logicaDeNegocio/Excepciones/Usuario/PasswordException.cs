using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaDeNegocio.Excepciones.Usuario
{
    internal class PasswordException:UsuarioException
    {
        public PasswordException() { }

        public PasswordException(string? message) : base(message)
        {
        }
    }
}
