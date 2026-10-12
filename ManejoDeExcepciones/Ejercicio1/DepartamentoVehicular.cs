using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class DepartamentoVehicular
    {
        private List<RegistroVehiculo> registros;
        private int serie;
        public int CantidadDeRegistros { get { return registros.Count; } }

        public DepartamentoVehicular()
        {
            registros = new List<RegistroVehiculo>();
            serie = 0;
        }
        public RegistroVehiculo RegistroVehiculo(Persona propietario, string patente)
        {
            RegistroVehiculo registro = new RegistroVehiculo(patente, propietario, serie + 1);
            serie++;
            registros.Add(registro);
            return registro;
        }
        public RegistroVehiculo VerRegistro(int idx)
        {
            return registros[idx];
        }

    }
}
