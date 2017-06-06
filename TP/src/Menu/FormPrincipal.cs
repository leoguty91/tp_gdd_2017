using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Entidades;

namespace UberFrba.Menu
{
    public partial class FormPrincipal : Form
    {
        //private Usuario usuario { get; set; }
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
            new Abm_Rol.Form1();
        }

        private void aBMDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Abm_Cliente.Form1();
        }

        private void aBMDeAutomovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Abm_Automovil.Form1();
        }

        private void aBMDeChoferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Abm_Chofer.Form1();
        }

        private void registroDeViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Registro_Viajes.Form1();
        }

        private void rendicionDeCuentaDelChoferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Rendicion_Viajes.Form1();
        }

        private void facturacionAClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Facturacion.Form1();
        }

        private void listadoEstadisticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Listado_Estadistico.Form1();
        }
    }
}
