using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error en facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
