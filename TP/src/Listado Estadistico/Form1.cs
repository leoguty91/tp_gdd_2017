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

namespace UberFrba.Listado_Estadistico
{
    public partial class Form1 : Form
    {
        public const int CHOFERES_MAYOR_RECAUDACION = 0;
        public const int CHOFERES_VIAJE_MAS_LARGO = 1;
        public const int CLIENTES_MAYOR_CONSUMO = 2;
        public const int CLIENTES_MISMO_AUTOMOVIL_VIAJES = 3;

        public const int PRIMER_TRIMESTRE = 0;
        public const int SEGUNDO_TRIMESTRE = 1;
        public const int TERCER_TRIMESTRE = 2;
        public const int CUARTO_TRIMESTRE = 3;

        public Form1()
        {
            InitializeComponent();
            cargaDatos();
            Show();
        }
        private void cargaDatos()
        {
            dateTimePickerFecha.CustomFormat = "yyyy";
            dateTimePickerFecha.ShowUpDown = true;
            dateTimePickerFecha.Value = FechaSistema.getDateTime();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxListado.SelectedIndex == -1)
                {
                    throw new Exception("Seleccione un listado");
                }
                if (comboBoxTrimestre.SelectedIndex == -1)
                {
                    throw new Exception("Seleccione un trimestre");
                }
                Conexion conexion = new Conexion();
                SqlCommand store_procedure = new SqlCommand();
                switch (comboBoxListado.SelectedIndex)
                {
                    case CHOFERES_MAYOR_RECAUDACION:
                        store_procedure = conexion.IniciarStoreProcedure("sp_chofer_mayor_recaudacion");
                        break;
                    case CHOFERES_VIAJE_MAS_LARGO:
                        store_procedure = conexion.IniciarStoreProcedure("sp_chofer_viaje_largo");
                        break;
                    case CLIENTES_MAYOR_CONSUMO:
                        store_procedure = conexion.IniciarStoreProcedure("sp_cliente_mayor_consumo");
                        break;
                    case CLIENTES_MISMO_AUTOMOVIL_VIAJES:
                        store_procedure = conexion.IniciarStoreProcedure("sp_cliente_mismo_automovil_viajes");
                        break;
                }
                DateTime fecha_inicio;
                DateTime fecha_fin;
                switch (comboBoxTrimestre.SelectedIndex)
                {
                    case PRIMER_TRIMESTRE:
                        fecha_inicio = new DateTime(dateTimePickerFecha.Value.Year, 1, 1, 0, 0, 0);
                        fecha_fin = new DateTime(dateTimePickerFecha.Value.Year, 3, 31, 0, 0, 0);
                        store_procedure.Parameters.Add(new SqlParameter("@fecha_inicio", fecha_inicio));
                        store_procedure.Parameters.Add(new SqlParameter("@fecha_fin", fecha_fin));
                        break;
                    case SEGUNDO_TRIMESTRE:
                        fecha_inicio = new DateTime(dateTimePickerFecha.Value.Year, 4, 1, 0, 0, 0);
                        fecha_fin = new DateTime(dateTimePickerFecha.Value.Year, 6, 30, 0, 0, 0);
                        store_procedure.Parameters.Add(new SqlParameter("@fecha_inicio", fecha_inicio));
                        store_procedure.Parameters.Add(new SqlParameter("@fecha_fin", fecha_fin));
                        break;
                    case TERCER_TRIMESTRE:
                        fecha_inicio = new DateTime(dateTimePickerFecha.Value.Year, 7, 1, 0, 0, 0);
                        fecha_fin = new DateTime(dateTimePickerFecha.Value.Year, 9, 30, 0, 0, 0);
                        store_procedure.Parameters.Add(new SqlParameter("@fecha_inicio", fecha_inicio));
                        store_procedure.Parameters.Add(new SqlParameter("@fecha_fin", fecha_fin));
                        break;
                    case CUARTO_TRIMESTRE:
                        fecha_inicio = new DateTime(dateTimePickerFecha.Value.Year, 10, 1, 0, 0, 0);
                        fecha_fin = new DateTime(dateTimePickerFecha.Value.Year, 12, 31, 0, 0, 0);
                        store_procedure.Parameters.Add(new SqlParameter("@fecha_inicio", fecha_inicio));
                        store_procedure.Parameters.Add(new SqlParameter("@fecha_fin", fecha_fin));
                        break;
                }
                this.dataGridView1.DataSource = conexion.EjecutarConsultar(store_procedure);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error en listados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
