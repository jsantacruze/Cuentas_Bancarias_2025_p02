using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Cuentas_Bancarias.Data.Base;

namespace Cuentas_Bancarias.Data.Personas
{
    public class PersonaDAO : BaseDAO<Dominio.Personas.Persona>
    {
        private static PersonaDAO _instancia;

        public static PersonaDAO Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new PersonaDAO();
                return _instancia;
            }
        }

        public PersonaDAO() : base("personas.json") 
        {
        }

        public Dominio.Personas.Persona getByID(int id)
        {
            //Dominio.Personas.Persona result = null;
            //for (int i=0; i<this.data.Count;i++)
            //{
            //    if (this.data[i].Id == id)
            //    {
            //        result = this.data[i];
            //        break;
            //    }
            //}
            //return result;

            var result = this.data.Where(p => p.Id == id).FirstOrDefault();
            return result;
        }

        public List<Dominio.Personas.Persona> getByApellidosNombres(string filtro)
        {
            var result = this.data.Where(p => p.Apellido.Contains(filtro) || p.Nombre.Contains(filtro)).ToList();
            return result;
        }
    }
}
