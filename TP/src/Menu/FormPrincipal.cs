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
        public FormPrincipal(int rol)
        {
            InitializeComponent();
            ArmarMenuParaRol(rol);
            Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        private void ArmarMenuParaRol(int rol_id)
        {
            try
            {
                Rol rol_mapper = new Rol();
                Rol rol = rol_mapper.Mapear(rol_id);
                if (rol.funcionalidades.Count > 0)
                    menuToolStripMenuItem.Visible = true;
                foreach (Funcionalidad funcionad in rol.funcionalidades)
                {
                    switch (funcionad.nombre)
                    {
                        case "ABM de Rol":
                            aBMDeRolToolStripMenuItem1.Visible = true;
                            break;
                        case "Login y Seguridad":
                            loginYSeguridadToolStripMenuItem.Visible = true;
                            break;
                        case "Registro de Usuario":
                            registroDeUsuarioToolStripMenuItem.Visible = true;
                            break;
                        case "ABM de Cliente":
                            aBMDeClienteToolStripMenuItem.Visible = true;
                            break;
                        case "ABM de Automovil":
                            aBMDeAutomovilToolStripMenuItem.Visible = true;
                            break;
                        case "ABM de Turno":
                            aBMDeTurnoToolStripMenuItem.Visible = true;
                            break;
                        case "ABM de Chofer":
                            aBMDeChoferToolStripMenuItem.Visible = true;
                            break;
                        case "Registro de Viajes":
                            registroDeViajesToolStripMenuItem.Visible = true;
                            break;
                        case "Rendicion de cuenta del chofer":
                            rendicionDeCuentaDelChoferToolStripMenuItem.Visible = true;
                            break;
                        case "Facturacion a Cliente":
                            facturacionAClienteToolStripMenuItem.Visible = true;
                            break;
                        case "Listado Estadistico":
                            listadoEstadisticoToolStripMenuItem.Visible = true;
                            break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, " Menu error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void loginYSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login_Seguridad.Form1();
        }

        private void registroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Registro_Usuario.Form1();
        }

        private void aBMDeTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABM_Turno.Form1();
        }
    }
}
