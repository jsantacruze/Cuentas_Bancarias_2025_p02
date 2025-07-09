using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas_Bancarias.Dominio.Ubicaciones
{
    public class UbicacioGeografica
    {
        public float latitud { get; set; }
        public float longitud { get; set; }

        public UbicacioGeografica()
        {
        }

        public UbicacioGeografica(float latitud, float longitud)
        {
            this.latitud = latitud;
            this.longitud = longitud;
        }
    }
}
