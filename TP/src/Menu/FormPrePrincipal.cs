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
                mapearRolesACombo(usuario.roles);
                Show();
            }
            else
            {
                new FormPrincipal(usuario);
            }
        }

        private void mapearRolesACombo(List<Rol> roles)
        {
            comboRoles.Items.Add("Seleccione el rol");
            foreach(Rol rol in roles)
            {
                comboRoles.Items.Add(rol.nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
