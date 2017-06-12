using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Entidades;
using UberFrba.Helpers;

namespace UberFrba.Abm_Cliente
{
    public partial class FormCliente : Form
    {
        private Cliente cliente { get; set; }
        private bool nuevo_cliente;
        public FormCliente()
        {
            InitializeComponent();
            cargaUsuarios();
            Show();
        }
        public FormCliente(int cliente_id)
        {
            InitializeComponent();
            cargaCliente(cliente_id);
            Show();
        }
        private void cargaCliente(int cliente_id)
        {
            try
            {
                nuevo_cliente = false;
                Cliente cliente_mapper = new Cliente();
                this.cliente = cliente_mapper.Mapear(cliente_id);
                checkBox1.Checked = cliente.habilitado;
                textBoxNombre.Text = cliente.nombre;
                textBoxApellido.Text = cliente.apellido;
                textBoxMail.Text = cliente.mail;
                textBoxDNI.Text = Convert.ToString(cliente.dni);
                textBoxTelefono.Text = Convert.ToString(cliente.telefono);
                textBoxDireccion.Text = cliente.direccion;
                textBoxCodigoPostal.Text = cliente.codigo_postal;
                dateTimePickerFechaNacimiento.Value = cliente.fecha_nacimiento;
                comboBoxUsuarios.Enabled = false;
                comboBoxUsuarios.DisplayMember = "Text";
                comboBoxUsuarios.ValueMember = "Value";
                comboBoxUsuarios.Items.Add(new { Text = cliente.usuario.usuario, Value = cliente.usuario.id });
                comboBoxUsuarios.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Cliente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargaUsuarios()
        {
            try
            {
                nuevo_cliente = true;
                List<Usuario> usuarios = usuariosNoClientes();
                comboBoxUsuarios.DisplayMember = "Text";
                comboBoxUsuarios.ValueMember = "Value";
                comboBoxUsuarios.Items.Add(new { Text = "Seleccione el usuario", Value = 0 });
                foreach (Usuario usuario in usuarios)
                {
                    comboBoxUsuarios.Items.Add(new { Text = usuario.usuario, Value = usuario.id });
                }
                comboBoxUsuarios.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Cliente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Usuario> usuariosNoClientes()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_usuarios_no_clientes");
                DataTable datos = conexion.EjecutarConsultar(store_procedure);
                Usuario usuario_mapper = new Usuario();
                foreach (DataRow row in datos.Rows)
                {
                    usuarios.Add(usuario_mapper.Mapear((int)row.ItemArray[0]));
                }
                return usuarios;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxUsuarios.SelectedItem as dynamic).Value == 0)
                    throw new Exception("Debe seleccionar un usuario");
                Conexion conexion = new Conexion();
                SqlCommand store_procedure;
                if (this.nuevo_cliente)
                {
                    store_procedure = conexion.IniciarStoreProcedure("sp_alta_cliente");
                    store_procedure.Parameters.Add(new SqlParameter("@usuario", (int)(comboBoxUsuarios.SelectedItem as dynamic).Value));
                }
                else
                {
                    store_procedure = conexion.IniciarStoreProcedure("sp_modificacion_cliente");
                    store_procedure.Parameters.Add(new SqlParameter("@cliente_id", this.cliente.id));
                }
                store_procedure.Parameters.Add(new SqlParameter("@nombre", textBoxNombre.Text));
                store_procedure.Parameters.Add(new SqlParameter("@apellido", textBoxApellido.Text));
                store_procedure.Parameters.Add(new SqlParameter("@dni", Convert.ToInt32(textBoxDNI.Text)));
                store_procedure.Parameters.Add(new SqlParameter("@mail", textBoxMail.Text));
                store_procedure.Parameters.Add(new SqlParameter("@telefono", Convert.ToInt32(textBoxTelefono.Text)));
                store_procedure.Parameters.Add(new SqlParameter("@direccion", textBoxDireccion.Text));
                store_procedure.Parameters.Add(new SqlParameter("@codigo_postal", textBoxCodigoPostal.Text));
                store_procedure.Parameters.Add(new SqlParameter("@fecha_nacimiento", dateTimePickerFechaNacimiento.Value.Date));
                store_procedure.Parameters.Add(new SqlParameter("@habilitado", checkBox1.Checked));
                conexion.EjecutarConsultar(store_procedure);
                string mensaje_ok;
                if (this.nuevo_cliente)
                {
                    mensaje_ok = String.Format("Se ha creado el cliente {0} {1}", textBoxNombre.Text, textBoxApellido.Text);
                }
                else
                {
                    mensaje_ok = String.Format("Se ha modificado el cliente {0} {1}", textBoxNombre.Text, textBoxApellido.Text);
                }
                MessageBox.Show(mensaje_ok, "Guardado de cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Guardado de cliente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
