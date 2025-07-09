using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas_Bancarias.Dominio.Cuentas
{
    public class TipoMovimientoCuenta
    {

        public string id { get; set; }
        //EJ: DEP, RET, NC, ND, ETC
        public string Nombre { get; set; }

        // 1 SUMA -1 RESTA
        public int Factor {  get; set; }

        public TipoMovimientoCuenta()
        {
        }

        public TipoMovimientoCuenta(string id, string nombre, int factor)
        {
            this.id = id;
            Nombre = nombre;
            Factor = factor;
        }
    }
}
