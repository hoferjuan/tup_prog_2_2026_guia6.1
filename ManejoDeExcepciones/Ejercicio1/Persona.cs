using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Persona
    {
        private string dni;
        public string DNI
        {
            get
            {
                return dni;
            }
            private set
            {
                int numero = int.Parse(value);

                if (numero <= 1000000)
                {
                    throw new RangoDniIncorrectoException(
                        "El DNI debe ser mayor a un millón.");
                }

                dni = value;
            }
        }
        public string Nombre { get; private set; }
        public Persona(string dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }
    }
}
