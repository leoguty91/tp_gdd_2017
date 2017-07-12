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

namespace UberFrba.Facturacion
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
                comboBoxCliente = cbm.Cliente(comboBoxCliente);
                dateTimePickerFecha.CustomFormat = "MM/yyyy";
                dateTimePickerFecha.ShowUpDown = true;
                dateTimePickerFecha.Value = FechaSistema.getDateTime();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error en facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente_mapper = new Cliente();
                Cliente cliente = cliente_mapper.Mapear((comboBoxCliente.SelectedItem as dynamic).Value);

                this.vw_rendicionTableAdapter.Fill(this.gD1C2017DataSet.vw_rendicion);
                DataView dv = new DataView(this.gD1C2017DataSet.vw_rendicion);
                DateTime fecha_inicio = new DateTime(dateTimePickerFecha.Value.Year, dateTimePickerFecha.Value.Month, 1, 0, 0, 0);
                DateTime fecha_fin = fecha_inicio.AddMonths(1);
                string rowFilter = String.Format("[{0}] >= '{1}' AND [{0}] <= '{2}'", "viaj_fecha_inicio", fecha_inicio, fecha_fin);
                rowFilter += String.Format(" AND [{0}] = '{1}'", "clie_id", cliente.id);

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
                textBoxImporteTotal.Text = rendicion_total.ToString("0.##");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error en filtrado de facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Factura factura = new Factura();
                Cliente cliente_mapper = new Cliente();
                Viaje viaje_mapper = new Viaje();
                Cliente cliente = cliente_mapper.Mapear((comboBoxCliente.SelectedItem as dynamic).Value);
                factura.fecha_inicio = dateTimePickerFecha.Value;
                factura.cliente = cliente;
                factura.importe = Convert.ToDecimal(textBoxImporteTotal.Text);
                factura.viajes = new List<Viaje>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int viaje_id = Convert.ToInt32(row.Cells[0].Value);
                    Viaje viaje = viaje_mapper.Mapear(viaje_id);
                    factura.viajes.Add(viaje);
                }
                string respuesta = factura.Guardar();
                MessageBox.Show(respuesta, "Guardado de factura", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error en guardado de facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
