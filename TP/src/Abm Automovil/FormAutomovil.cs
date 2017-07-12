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

namespace UberFrba.Abm_Automovil
{
    public partial class FormAutomovil : Form
    {
        private Automovil automovil;

        public FormAutomovil(int auto_id = Entidad.NUEVO)
        {
            InitializeComponent();
            cargaAutomovil(auto_id);
            Show();
        }
        private void cargaAutomovil(int auto_id = Entidad.NUEVO)
        {
            try
            {
                ComboBoxManager cbm = new ComboBoxManager();
                if (auto_id == Entidad.NUEVO)
                {
                    automovil = new Automovil();
                    comboBoxMarca = cbm.Marca(comboBoxMarca);
                    comboBoxTurno = cbm.Turno(comboBoxTurno);
                    comboBoxChofer = cbm.Chofer(comboBoxChofer);
                }
                else
                {
                    Automovil automovil_mapper = new Automovil();
                    this.automovil = automovil_mapper.Mapear(auto_id);
                    checkBoxHabilitado.Checked = automovil.habilitado;
                    textBoxModelo.Text = automovil.modelo;
                    textBoxPatente.Text = automovil.patente;
                    comboBoxMarca = cbm.Marca(comboBoxMarca, automovil.marca.nombre);
                    comboBoxTurno = cbm.Turno(comboBoxTurno, automovil.turno.descripcion);
                    comboBoxChofer = cbm.Chofer(comboBoxChofer, automovil.chofer.nombre + ' ' + automovil.chofer.apellido);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Automovil error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxMarca.SelectedItem as dynamic).Value == 0)
                    throw new Exception("Debe seleccionar una marca");
                if ((comboBoxTurno.SelectedItem as dynamic).Value == 0)
                    throw new Exception("Debe seleccionar un turno");
                if ((comboBoxChofer.SelectedItem as dynamic).Value == 0)
                    throw new Exception("Debe seleccionar un chofer");
                if (textBoxModelo.Text == "")
                    throw new Exception("Debe ingresar un modelo de automovil");
                if (textBoxPatente.Text == "")
                    throw new Exception("Debe ingresar una patente");
                Marca marca_mapper = new Marca();
                Turno turno_mapper = new Turno();
                Chofer chofer_mapper = new Chofer();
                int marca_id = (int)(comboBoxMarca.SelectedItem as dynamic).Value;
                int turno_id = (int)(comboBoxTurno.SelectedItem as dynamic).Value;
                int chofer_id = (int)(comboBoxChofer.SelectedItem as dynamic).Value;
                automovil.marca = marca_mapper.Mapear(marca_id);
                automovil.modelo = textBoxModelo.Text;
                automovil.patente = textBoxPatente.Text;
                automovil.turno = turno_mapper.Mapear(turno_id);
                automovil.chofer = chofer_mapper.Mapear(chofer_id);
                automovil.habilitado = checkBoxHabilitado.Checked;
                string respuesta = automovil.Guardar();
                MessageBox.Show(respuesta, "Guardado de automovil", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Guardado de automovil error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
