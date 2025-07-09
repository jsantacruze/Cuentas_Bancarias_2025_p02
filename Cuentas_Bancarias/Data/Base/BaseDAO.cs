using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cuentas_Bancarias.Data.Base
{
    public abstract class BaseDAO<T>
    {
        public string archivo_nombre { get; set; }
        public List<T> data;
        public BaseDAO()
        {
        }
        protected BaseDAO(string archivo_nombre)
        {
            this.archivo_nombre = archivo_nombre;
            this.data = getAll();
        }

        public List<T> getAll()
        {
            if (!File.Exists(archivo_nombre))
                return new List<T>();

            string json = File.ReadAllText(archivo_nombre);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }


        public void Save()
        {
            string json = JsonSerializer.Serialize(this.data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(archivo_nombre, json);
        }

        public void Add(T elemento)
        {
            this.data.Add(elemento);
            this.Save();
        }

        public void Update(Predicate<T> predicado, T nuevoValor)
        {
            int indice = this.data.FindIndex(predicado);
            if (indice != -1)
            {
                this.data[indice] = nuevoValor;
                Save();
            }
        }

        public void Delete(T elemento)
        {
            this.data.Remove(elemento); 
            this.Save();
        }
    }
}
