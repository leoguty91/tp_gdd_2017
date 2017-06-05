using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Menu
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void aBMDeRolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Rol.Form1 rol = new Abm_Rol.Form1();
        }

        private void aBMDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abm_Cliente.Form1 cliente = new Abm_Cliente.Form1();
        }

        private void aBMDeAutomovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Automovil.Form1 automovil = new Abm_Automovil.Form1();
        }

        private void aBMDeChoferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Chofer.Form1 chofer = new Abm_Chofer.Form1();
        }

        private void registroDeViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Viajes.Form1 registro = new Registro_Viajes.Form1();
        }

        private void rendicionDeCuentaDelChoferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rendicion_Viajes.Form1 rendicion = new Rendicion_Viajes.Form1();
        }

        private void facturacionAClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion.Form1 facturacion = new Facturacion.Form1();
        }

        private void listadoEstadisticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.Form1 listado = new Listado_Estadistico.Form1();
        }
    }
}
