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
    public partial class FormPrePrincipal : Form
    {
        public FormPrePrincipal(Usuario usuario)
        {
            InitializeComponent();
            if (usuario.roles.Count() > 1)
            {
                Show();
            }
            else
            {
                new FormPrincipal(usuario);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
