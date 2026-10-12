using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ejercicio1
{
    internal class RegistroVehiculo : IComparable
    {
        public string Patente { get; private set; }
        public int Serie { get; private set; }
        public Persona Propietario { get; private set; }
        public RegistroVehiculo(string patente, Persona propietario, int serie)
        {
            // Valida antes de asignar nada: si falla, el objeto no se crea
            if (!Regex.IsMatch(patente, "^[A-Za-z]{3}[0-9]{3}$"))
            {
                throw new FormatoPatenteNoValidaException(
                    "La patente debe tener tres letras y tres números (ej: ABC123).");
            }
            this.Patente = patente.ToUpper();
            this.Serie = serie;
            this.Propietario = propietario;
        }
        public int CompareTo(object obj)
        {
            RegistroVehiculo otro = obj as RegistroVehiculo;

            if (otro == null)
            {
                throw new ArgumentException("El objeto no es un RegistroVehiculo.");
            }

            return Patente.CompareTo(otro.Patente);
        }
        public override string ToString()
        {
            return Patente + " - Propietario: " + Propietario.Nombre + "(" + Propietario.DNI + ")";
        }
    }

}
