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
        }
        public FormRol(int rol)
        {
            InitializeComponent();
            editarRol(rol);
        }
        private void nuevoRol()
        {
            try
            {
                this.nuevo_rol = true;
                this.dataGridView1.DataSource = getFuncionalidades();
                Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(String.Format("Se produjo un error al cargar las funcionalidad. {0}", exception.Message), "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarRol(int rol_id)
        {
            try
            {
                this.nuevo_rol = false;
                this.dataGridView1.DataSource = getFuncionalidades(rol_id);
                Rol rol_mapper = new Rol();
                this.rol = rol_mapper.Mapear(rol_id);
                this.textBox1.Text = rol.nombre;
                this.checkBox1.Checked = rol.habilitado;
                Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(String.Format("Se produjo un error al cargar las funcionalidad. {0}", exception.Message), "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormRol_Load(object sender, EventArgs e)
        {
        }

        private DataTable getFuncionalidades()
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_funcionalidades");
                DataTable datos = conexion.EjecutarConsultar(store_procedure);
                return convertirColumnasBool(datos);
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
                DataTable datos = conexion.EjecutarConsultar(store_procedure);
                return convertirColumnasBool(datos);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private DataTable convertirColumnasBool(DataTable tabla_original)
        {
            try
            {
                // Cuando traigo los datos de la base, me llega como 1/0, necesito convertirlos a bool
                DataTable tabla_clonada = tabla_original.Clone();
                tabla_clonada.Columns[0].ReadOnly = true;
                tabla_clonada.Columns[1].DataType = typeof(Boolean);
                foreach (DataRow row in tabla_original.Rows)
                {
                    tabla_clonada.ImportRow(row);
                }
                return tabla_clonada;
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
                    actualizaFuncionalidades(textBox1.Text);
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
        private void actualizaFuncionalidades(string rol_nombre)
        {
            try
            {
                Rol rol_mapper = new Rol();
                Rol rol = rol_mapper.Mapear(rol_nombre);
                Funcionalidad funcionalidad_mapper = new Funcionalidad();
                Conexion conexion = new Conexion();
                SqlCommand store_procedure;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool agrega_funcionalidad = (bool)row.Cells[1].Value;
                    string funcionalidad_nombre = row.Cells[0].Value.ToString();
                    Funcionalidad funcionalidad = funcionalidad_mapper.Mapear(funcionalidad_nombre);
                    if (agrega_funcionalidad)
                    {
                        store_procedure = conexion.IniciarStoreProcedure("sp_alta_funcionalidad_rol");
                    }
                    else
                    {
                        store_procedure = conexion.IniciarStoreProcedure("sp_baja_funcionalidad_rol");
                    }
                    store_procedure.Parameters.Add(new SqlParameter("@funcionalidad", funcionalidad.id));
                    store_procedure.Parameters.Add(new SqlParameter("@rol", rol.id));
                    conexion.EjecutarConsultar(store_procedure);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
