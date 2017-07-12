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

namespace UberFrba.Registro_Usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text == "")
                    throw new Exception("Debe ingresar un nombre de usuaro");
                if (textBoxPassword.Text == "")
                    throw new Exception("Debe ingresar un password");
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = conexion.IniciarStoreProcedure("sp_alta_usuario");
                store_procedure.Parameters.Add(new SqlParameter("@usuario", textBoxUsername.Text));
                store_procedure.Parameters.Add(new SqlParameter("@password", textBoxPassword.Text));
                DataTable respuesta_consulta = conexion.EjecutarConsultar(store_procedure);
                MessageBox.Show(String.Format("El usuario {0} se ha dado de alta", textBoxUsername.Text), "Alta de usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, " Registro de usuario erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
