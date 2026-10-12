using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class FormatoPatenteNoValidaException : Exception
    {
        public FormatoPatenteNoValidaException()
       : base("El formato de la patente no es válido.")
        {
        }

        public FormatoPatenteNoValidaException(string mensaje)
            : base(mensaje)
        {
        }

        public FormatoPatenteNoValidaException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }
    }
}
