using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaDeNegocio.Excepciones.Usuario
{
    internal class EmailException : UsuarioException
    {
        public EmailException()
        {
        }

        public EmailException(string? message) : base(message)
        {
        }
    }
}
