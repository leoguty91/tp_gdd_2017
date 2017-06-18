using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.ABM_Turno
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
            // TODO: esta línea de código carga datos en la tabla 'gD1C2017DataSet.Turno' Puede moverla o quitarla según sea necesario.
            this.turnoTableAdapter.Fill(this.gD1C2017DataSet.Turno);

        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string rowFilter = "";
                DataView dv = new DataView(this.gD1C2017DataSet.Turno);
                if (!String.IsNullOrWhiteSpace(textBoxDescripcion.Text))
                    rowFilter = String.Format("[{0}] LIKE '%{1}%'", "turn_descripcion", textBoxDescripcion.Text);
                if (!String.IsNullOrWhiteSpace(rowFilter))
                    dv.RowFilter = rowFilter;
                dataGridView1.DataSource = dv;
                dataGridView1.Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, " Filtrado de turno error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int getTurnoID()
        {
            int selected_row_index = this.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selected_row = dataGridView1.Rows[selected_row_index];
            return Convert.ToInt32(selected_row.Cells[0].Value);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new ABM_Turno.FormTurno(getTurnoID());
            Hide();
        }

        private void buttonAltaTurno_Click(object sender, EventArgs e)
        {
            new ABM_Turno.FormTurno();
            Hide();
        }
    }
}
