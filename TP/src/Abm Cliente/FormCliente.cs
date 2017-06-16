﻿using System;
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
        public FormCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
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
                Usuario usuario_mapper = new Usuario();
                int usuario_id = (int)(comboBoxUsuarios.SelectedItem as dynamic).Value;
                cliente.usuario = usuario_mapper.Mapear(usuario_id);
                cliente.nombre = textBoxNombre.Text;
                cliente.apellido = textBoxApellido.Text;
                cliente.dni = Convert.ToInt32(textBoxDNI.Text);
                cliente.mail = textBoxMail.Text;
                cliente.telefono = Convert.ToInt32(textBoxTelefono.Text);
                cliente.direccion = textBoxDireccion.Text;
                cliente.codigo_postal = textBoxCodigoPostal.Text;
                cliente.fecha_nacimiento = dateTimePickerFechaNacimiento.Value.Date;
                cliente.habilitado = checkBox1.Checked;
                string respuesta = cliente.Guardar();
                MessageBox.Show(respuesta, "Guardado de cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Guardado de cliente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
