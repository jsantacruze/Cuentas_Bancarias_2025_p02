using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Data.Base;

namespace Cuentas_Bancarias.Data.Personas
{
    public class EmpeladoDAO : BaseDAO<Dominio.Personas.Empleado>
    {
        public EmpeladoDAO() : base("empleados.json") 
        {
        }
    }
}
