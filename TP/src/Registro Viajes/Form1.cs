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

namespace UberFrba.Registro_Viajes
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
                string chofer_seleccionado = "";
                if (SingletonUsuario.Instance.rol_actual.nombre == "Chofer")
                {
                    Chofer chofer_mapper = new Chofer();
                    Chofer chofer = chofer_mapper.MapearDeUsuario(SingletonUsuario.Instance.id);
                    chofer_seleccionado = chofer.nombre + ' ' + chofer.apellido;
                }
                comboBoxChofer = cbm.Chofer(comboBoxChofer, chofer_seleccionado);
                comboBoxAutomovil = cbm.Automovil(comboBoxAutomovil);
                comboBoxCliente = cbm.Cliente(comboBoxCliente);
                comboBoxTurno = cbm.Turno(comboBoxTurno);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Rendicion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
