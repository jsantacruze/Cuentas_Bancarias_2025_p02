﻿using System;
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
            var result = this.data.Where(p => p.Apellido.ToUpper()
            .Contains(filtro.ToUpper()) || p.Nombre.ToUpper().Contains(filtro.ToUpper())).ToList();
            return result;
        }

        public int getNextId()
        {
            if (this.data.Count == 0)
                return 1;
            else
            {
                var maxId = this.data.Max(p => p.Id);
                return maxId + 1;
            }
        }
    }
}
