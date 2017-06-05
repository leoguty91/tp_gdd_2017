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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            Login login = new Login();
            login.Show();
        }

        private void aBMDeRolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abm_Rol.ABMRol rol = new Abm_Rol.ABMRol();
        }
    }
}
