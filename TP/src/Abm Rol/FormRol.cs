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

namespace UberFrba.Abm_Rol
{
    public partial class FormRol : Form
    {
        private bool nuevo_rol { get; set; }
        private Rol rol { get; set; }
        public FormRol()
        {
            InitializeComponent();
            nuevoRol();
            Show();
        }
        public FormRol(int rol)
        {
            InitializeComponent();
            editarRol(rol);
            Show();
        }
        private void nuevoRol()
        {
            this.nuevo_rol = true;
            this.dataGridView1.DataSource = getFuncionalidades();
        }

        private void editarRol(int rol_id)
        {
            this.nuevo_rol = false;
            this.dataGridView1.DataSource = getFuncionalidades(rol_id);
            Rol rol_mapper = new Rol();
            this.rol = rol_mapper.Mapear(rol_id);
            this.textBox1.Text = rol.nombre;
            this.checkBox1.Checked = rol.habilitado;
        }

        private void FormRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2017DataSet.Funcionalidad' Puede moverla o quitarla según sea necesario.
        }

        private DataTable getFuncionalidades()
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_funcionalidades");
                return conexion.EjecutarConsultar(store_procedure);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private DataTable getFuncionalidades(int rol)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_funcionalidades_rol");
                store_procedure.Parameters.Add(new SqlParameter("@rol", rol));
                return conexion.EjecutarConsultar(store_procedure);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    Conexion conexion = new Conexion();
                    SqlCommand store_procedure;
                    if (this.nuevo_rol)
                    {
                        store_procedure = conexion.IniciarStoreProcedure("sp_alta_rol");
                    }
                    else
                    {
                        store_procedure = conexion.IniciarStoreProcedure("sp_modificacion_rol");
                        store_procedure.Parameters.Add(new SqlParameter("@rol", rol.id));
                    }
                    store_procedure.Parameters.Add(new SqlParameter("@nombre", textBox1.Text));
                    store_procedure.Parameters.Add(new SqlParameter("@habilitado", checkBox1.Checked));
                    conexion.EjecutarConsultar(store_procedure);
                    string mensaje_ok;
                    if (this.nuevo_rol)
                    {
                        mensaje_ok = String.Format("Se ha creado el rol {0}", textBox1.Text);
                    }
                    else
                    {
                        mensaje_ok = String.Format("Se ha modificado el rol {0}", textBox1.Text);
                    }
                    MessageBox.Show(mensaje_ok, "Guardado de rol", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Guardado de rol error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
