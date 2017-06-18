using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2017DataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.gD1C2017DataSet.Cliente);
        }

        private int getClienteID()
        {
            int selected_row_index = this.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selected_row = dataGridView1.Rows[selected_row_index];
            return Convert.ToInt32(selected_row.Cells[0].Value);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new Abm_Cliente.FormCliente(getClienteID());
            Hide();
        }

        private void buttonAltaCliente_Click(object sender, EventArgs e)
        {
            new Abm_Cliente.FormCliente();
            Hide();
        }

        private void buttonFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                string rowFilter = "";
                DataView dv = new DataView(this.gD1C2017DataSet.Cliente);
                if (!String.IsNullOrWhiteSpace(textBoxNombre.Text))
                    rowFilter = String.Format("[{0}] LIKE '%{1}%'", "clie_nombre", textBoxNombre.Text);
                if (!String.IsNullOrWhiteSpace(textBoxApellido.Text))
                {
                    if (!String.IsNullOrWhiteSpace(rowFilter))
                        rowFilter += " AND ";
                    rowFilter += String.Format("[{0}] LIKE '%{1}%'", "clie_apellido", textBoxApellido.Text);
                }
                if (!String.IsNullOrWhiteSpace(textBoxDNI.Text))
                {
                    if (!String.IsNullOrWhiteSpace(rowFilter))
                        rowFilter += " AND ";
                    rowFilter += String.Format("[{0}] = {1}", "clie_dni", Convert.ToInt32(textBoxDNI.Text));
                }
                if (!String.IsNullOrWhiteSpace(rowFilter))
                    dv.RowFilter = rowFilter; dataGridView1.DataSource = dv;
                dataGridView1.Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, " Filtrado de clientes error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
