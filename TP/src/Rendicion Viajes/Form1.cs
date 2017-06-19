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

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2017DataSet.vw_rendicion' Puede moverla o quitarla según sea necesario.
            this.vw_rendicionTableAdapter.Fill(this.gD1C2017DataSet.vw_rendicion);
        }
    }
}
