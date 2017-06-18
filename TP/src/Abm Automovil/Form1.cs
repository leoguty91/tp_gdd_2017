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
using UberFrba.UI;

namespace UberFrba.Abm_Automovil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargaCombos();
            Show();
        }

        private void cargaCombos()
        {
            try
            {
                ComboBoxManager cmb = new ComboBoxManager();
                comboBoxMarca = cmb.Marca(comboBoxMarca);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Carga de automoviles error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2017DataSet1.vw_automovil_listado' Puede moverla o quitarla según sea necesario.
            this.vw_automovil_listadoTableAdapter.Fill(this.gD1C2017DataSet1.vw_automovil_listado);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new Abm_Automovil.FormAutomovil(getAutoID());
            Hide();
        }
        private int getAutoID()
        {
            int selected_row_index = this.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selected_row = dataGridView1.Rows[selected_row_index];
            return Convert.ToInt32(selected_row.Cells[0].Value);
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            new Abm_Automovil.FormAutomovil();
            Hide();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string rowFilter = "";
                this.vw_automovil_listadoTableAdapter.Fill(this.gD1C2017DataSet1.vw_automovil_listado);
                DataView dv = new DataView(this.gD1C2017DataSet1.vw_automovil_listado);
                if (comboBoxMarca.SelectedIndex != 0)
                {
                    string marca_nombre = (comboBoxMarca.SelectedItem as dynamic).Text;
                    rowFilter = String.Format("[{0}] = '{1}'", "marc_nombre", marca_nombre);
                }
                if (!String.IsNullOrWhiteSpace(textBoxModelo.Text))
                {
                    if (!String.IsNullOrWhiteSpace(rowFilter))
                        rowFilter += " AND ";
                    rowFilter += String.Format("[{0}] LIKE '%{1}%'", "auto_modelo", textBoxModelo.Text);
                }
                if (!String.IsNullOrWhiteSpace(textBoxPatente.Text))
                {
                    if (!String.IsNullOrWhiteSpace(rowFilter))
                        rowFilter += " AND ";
                    rowFilter += String.Format("[{0}] LIKE '%{1}%'", "auto_patente", textBoxPatente.Text);
                }
                if (!String.IsNullOrWhiteSpace(textBoxChofer.Text))
                {
                    if (!String.IsNullOrWhiteSpace(rowFilter))
                        rowFilter += " AND ";
                    rowFilter += String.Format("[{0}] LIKE '%{1}%'", "chof_nombre_apellido", textBoxChofer.Text);
                }
                if (!String.IsNullOrWhiteSpace(rowFilter))
                    dv.RowFilter = rowFilter;
                dataGridView1.DataSource = dv;
                dataGridView1.Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Filtrado de automoviles error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
