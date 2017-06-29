using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Listado_Estadistico
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
            dateTimePickerFecha.CustomFormat = "yyyy";
            dateTimePickerFecha.ShowUpDown = true;
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
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error en listados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
