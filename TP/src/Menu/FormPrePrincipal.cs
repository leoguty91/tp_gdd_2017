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
using UberFrba.Helpers;

namespace UberFrba.Menu
{
    public partial class FormPrePrincipal : Form
    {
        public FormPrePrincipal()
        {
            InitializeComponent();
            if (SingletonUsuario.Instance.roles.Count() > 1)
            {
                mapearRolesACombo(SingletonUsuario.Instance.roles);
                Show();
            }
            else
            {
                new FormPrincipal(SingletonUsuario.Instance.roles[0].id);
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }
        private void mapearRolesACombo(List<Rol> roles)
        {
            comboRoles.DisplayMember = "Text";
            comboRoles.ValueMember = "Value";
            comboRoles.Items.Add(new { Text = "Seleccione el rol", Value = 0 });
            foreach(Rol rol in roles)
            {
                comboRoles.Items.Add(new { Text = rol.nombre, Value = rol.id });
            }
            comboRoles.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboRoles.SelectedItem as dynamic).Value == 0)
                    throw new Exception("Debe seleccionar un rol");
                new FormPrincipal((comboRoles.SelectedItem as dynamic).Value);
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, " Rol erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
