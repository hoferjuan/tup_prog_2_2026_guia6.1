using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class RangoDniIncorrectoException : Exception
    {
        public RangoDniIncorrectoException()
        : base("El DNI debe ser mayor a un millón.")
        {
        }

        public RangoDniIncorrectoException(string mensaje)
            : base(mensaje)
        {
        }

        public RangoDniIncorrectoException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }
    }
}
