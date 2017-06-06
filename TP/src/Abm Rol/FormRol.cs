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
using UberFrba.Helpers;

namespace UberFrba.Abm_Rol
{
    public partial class FormRol : Form
    {
        public FormRol(int rol)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = getFuncionalidades(rol);
            Show();
        }

        private void FormRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2017DataSet.Funcionalidad' Puede moverla o quitarla según sea necesario.
        }

        private DataTable getFuncionalidades(int rol)
        {
            Conexion conexion = new Conexion();
            SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_obtener_funcionalidades");
            store_procedure.Parameters.Add(new SqlParameter("@rol", rol));
            return conexion.EjecutarConsultar(store_procedure);
        }
    }
}
