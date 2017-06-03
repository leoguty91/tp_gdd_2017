using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Helpers;

namespace UberFrba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    Login login = new Login();
                    login.ObtenerUsuario(usua_usuario.Text, usua_password.Text);
                }
                catch (Exception) { }
            }
        }
    }
}
