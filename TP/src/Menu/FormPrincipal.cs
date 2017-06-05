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
    }
}
