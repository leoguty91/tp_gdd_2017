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
using UberFrba.UI;

namespace UberFrba.Rendicion_Viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargaDatos();
            Show();
        }
        private void cargaDatos()
        {
            try
            {
                ComboBoxManager cbm = new ComboBoxManager();
                comboBoxChofer = cbm.Chofer(comboBoxChofer);
                comboBoxTurno = cbm.Turno(comboBoxTurno);
                dateTimePickerFecha.Value = FechaSistema.getDateTime();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error en rendicion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFiltrado_Click(object sender, EventArgs e)
        {
            try
            {
                Chofer chofer_mapper = new Chofer();
                Turno turno_mapper = new Turno();
                Chofer chofer = chofer_mapper.Mapear((comboBoxChofer.SelectedItem as dynamic).Value);
                Turno turno = turno_mapper.Mapear((comboBoxTurno.SelectedItem as dynamic).Value);

                this.vw_rendicionTableAdapter.Fill(this.gD1C2017DataSet.vw_rendicion);
                DataView dv = new DataView(this.gD1C2017DataSet.vw_rendicion);
                DateTime fecha_inicio = new DateTime(dateTimePickerFecha.Value.Year, dateTimePickerFecha.Value.Month, dateTimePickerFecha.Value.Day, 0, 0, 0);
                DateTime fecha_fin = fecha_inicio.AddDays(1);
                string rowFilter = String.Format("[{0}] >= '{1}' AND [{0}] <= '{2}'", "viaj_fecha_inicio", fecha_inicio, fecha_fin);
                rowFilter += String.Format(" AND [{0}] = '{1}'", "viaj_chofer", chofer.id);
                rowFilter += String.Format(" AND [{0}] = '{1}'", "viaj_turno", turno.id);

                if (!String.IsNullOrWhiteSpace(rowFilter))
                    dv.RowFilter = rowFilter;
                dataGridView1.DataSource = dv;
                dataGridView1.Refresh();
                decimal rendicion_total = 0;
                foreach (DataRowView row_view in dv)
                {
                    DataRow row = row_view.Row;
                    rendicion_total += Convert.ToDecimal(row[11]);
                }
                rendicion_total = rendicion_total * Convert.ToDecimal(textBoxPorcentaje.Text);
                textBoxImporteTotal.Text = rendicion_total.ToString("0.##");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error en filtrado de rendicion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2017DataSet.vw_rendicion' Puede moverla o quitarla según sea necesario.
            this.vw_rendicionTableAdapter.Fill(this.gD1C2017DataSet.vw_rendicion);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(textBoxImporteTotal.Text) == 0)
                {
                    throw new Exception("El importe no puede ser cero");
                }
                Rendicion rendicion = new Rendicion();
                Chofer chofer_mapper = new Chofer();
                Turno turno_mapper = new Turno();
                Viaje viaje_mapper = new Viaje();
                Chofer chofer = chofer_mapper.Mapear((comboBoxChofer.SelectedItem as dynamic).Value);
                Turno turno = turno_mapper.Mapear((comboBoxTurno.SelectedItem as dynamic).Value);
                rendicion.fecha = dateTimePickerFecha.Value;
                rendicion.chofer = chofer;
                rendicion.turno = turno;
                rendicion.importe = Convert.ToDecimal(textBoxImporteTotal.Text);
                rendicion.viajes = new List<Viaje>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int viaje_id = Convert.ToInt32(row.Cells[0].Value);
                    Viaje viaje = viaje_mapper.Mapear(viaje_id);
                    rendicion.viajes.Add(viaje);
                }
                string respuesta = rendicion.Guardar();
                MessageBox.Show(respuesta, "Guardado de rendicion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error en guardado de rendicion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
