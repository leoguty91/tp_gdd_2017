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
            if (SingletonUsuario.Instance.roles.Count() == 1)
            {
                SingletonUsuario.Instance.rol_actual = SingletonUsuario.Instance.roles.First();
                new FormPrincipal();
            }
            else
            {
                mapearRolesACombo();
                Show();
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }
        private void mapearRolesACombo()
        {
            comboRoles.DisplayMember = "Text";
            comboRoles.ValueMember = "Value";
            comboRoles.Items.Add(new { Text = "Seleccione el rol", Value = 0 });
            foreach (Rol rol in SingletonUsuario.Instance.roles)
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
                Rol rol_mapper = new Rol();
                int rol_id = (comboRoles.SelectedItem as dynamic).Value;
                SingletonUsuario.Instance.rol_actual = rol_mapper.Mapear(rol_id);
                new FormPrincipal();
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, " Rol erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
