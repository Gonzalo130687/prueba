using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaDeNegocio.Excepciones
{
    internal class LogicaDeNegocioException : Exception
    {
        public LogicaDeNegocioException()
        {
        }
        public LogicaDeNegocioException(string? message) : base(message)
        {
        }
    }
}
