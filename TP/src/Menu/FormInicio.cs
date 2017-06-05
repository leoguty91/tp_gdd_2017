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
            UberFrba.Form1 login = new UberFrba.Form1();
            login.Show();
        }

    }
}
