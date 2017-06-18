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

namespace UberFrba.Abm_Chofer
{
    public partial class FormChofer : Form
    {
        private Chofer chofer { get; set; }
        public FormChofer(int chofer_id = Entidad.NUEVO)
        {
            InitializeComponent();
            cargaChofer(chofer_id);
            Show();
        }
        private void cargaChofer(int chofer_id = Entidad.NUEVO)
        {
            try
            {
                if (chofer_id == Entidad.NUEVO)
                {
                    chofer = new Chofer();
                    Usuario usuario_mapper = new Usuario();
                    List<Usuario> usuarios = usuario_mapper.ObtenerUsuarios();
                    comboBoxUsuarios.DisplayMember = "Text";
                    comboBoxUsuarios.ValueMember = "Value";
                    comboBoxUsuarios.Items.Add(new { Text = "Seleccione el usuario", Value = 0 });
                    foreach (Usuario usuario in usuarios)
                    {
                        comboBoxUsuarios.Items.Add(new { Text = usuario.usuario, Value = usuario.id });
                    }
                    comboBoxUsuarios.SelectedIndex = 0;
                }
                else
                {
                    Chofer cliente_mapper = new Chofer();
                    this.chofer = cliente_mapper.Mapear(chofer_id);
                    checkBox1.Checked = chofer.habilitado;
                    textBoxNombre.Text = chofer.nombre;
                    textBoxApellido.Text = chofer.apellido;
                    textBoxMail.Text = chofer.mail;
                    textBoxDNI.Text = Convert.ToString(chofer.dni);
                    textBoxTelefono.Text = Convert.ToString(chofer.telefono);
                    textBoxDireccion.Text = chofer.direccion;
                    textBoxCodigoPostal.Text = chofer.codigo_postal;
                    dateTimePickerFechaNacimiento.Value = chofer.fecha_nacimiento;
                    comboBoxUsuarios.Enabled = false;
                    comboBoxUsuarios.DisplayMember = "Text";
                    comboBoxUsuarios.ValueMember = "Value";
                    comboBoxUsuarios.Items.Add(new { Text = chofer.usuario.usuario, Value = chofer.usuario.id });
                    comboBoxUsuarios.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Chofer error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxUsuarios.SelectedItem as dynamic).Value == 0)
                    throw new Exception("Debe seleccionar un usuario");
                Usuario usuario_mapper = new Usuario();
                int usuario_id = (int)(comboBoxUsuarios.SelectedItem as dynamic).Value;
                chofer.usuario = usuario_mapper.Mapear(usuario_id);
                chofer.nombre = textBoxNombre.Text;
                chofer.apellido = textBoxApellido.Text;
                chofer.dni = Convert.ToInt32(textBoxDNI.Text);
                chofer.mail = textBoxMail.Text;
                chofer.telefono = Convert.ToInt32(textBoxTelefono.Text);
                chofer.direccion = textBoxDireccion.Text;
                chofer.codigo_postal = textBoxCodigoPostal.Text;
                chofer.fecha_nacimiento = dateTimePickerFechaNacimiento.Value.Date;
                chofer.habilitado = checkBox1.Checked;
                string respuesta = chofer.Guardar();
                MessageBox.Show(respuesta, "Guardado de chofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Guardado de chofer error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
