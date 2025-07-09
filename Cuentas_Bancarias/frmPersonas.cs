using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cuentas_Bancarias.Data.Personas;
using Cuentas_Bancarias.Dominio.Personas;

namespace Cuentas_Bancarias
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clientes = ClienteDAO.Instancia.getAll();
            clienteBindingSource.DataSource = clientes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cliente = new Cliente(3, "Maria Isabel", "Perez", "misabel@hotmail.com", "0725555", "099255525",
                new Dominio.Ubicaciones.Direccion()
                {
                    id = 3,
                    calle_principal = "panamericana",
                    calle_secundaria = "tarqui",
                    codigo_postal = "030201",
                    referencia = ""
                },
                DateTime.Parse("01/01/1998"), null, 800);
            clienteDAO.Add(cliente);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(rbtnPorID.Checked)
            {
                var clientes = ClienteDAO.Instancia.getByID(int.Parse(this.txtFiltro.Text));
                clienteBindingSource.DataSource = clientes;
            }
            else
            {
                var clientes = ClienteDAO.Instancia.getByApellidosNombres(this.txtFiltro.Text);
                clienteBindingSource.DataSource = clientes;
            }

        }
    }
}
