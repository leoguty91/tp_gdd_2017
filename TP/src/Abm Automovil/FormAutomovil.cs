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

namespace UberFrba.Abm_Automovil
{
    public partial class FormAutomovil : Form
    {
        private Automovil automovil;
        public FormAutomovil(int auto_id)
        {
            InitializeComponent();
            cargaAutomovil(auto_id);
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void cargaAutomovil(int auto_id)
        {
            try
            {
                Automovil automovil_mapper = new Automovil();
                this.automovil = automovil_mapper.Mapear(auto_id);
                checkBoxHabilitado.Checked = automovil.habilitado;
                textBoxModelo.Text = automovil.modelo;
                textBoxPatente.Text = automovil.patente;
                mapearMarcasACombo();
                mapearTurnosACombo();
                mapearChoferesACombo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Automovil error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mapearMarcasACombo()
        {
            try
            {
                Marca marca_mapper = new Marca();
                List<Marca> marcas = marca_mapper.ObtenerMarcas();
                comboBoxMarca.DisplayMember = "Text";
                comboBoxMarca.ValueMember = "Value";
                comboBoxMarca.Items.Add(new { Text = "Seleccione la marca", Value = 0 });
                foreach (Marca marca in marcas)
                {
                    comboBoxMarca.Items.Add(new { Text = marca.nombre, Value = marca.id });
                }
                comboBoxMarca.SelectedIndex = comboBoxMarca.FindString(automovil.marca.nombre);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private void mapearTurnosACombo()
        {
            try
            {
                Turno turno_mapper = new Turno();
                List<Turno> turnos = turno_mapper.ObtenerTurnos();
                comboBoxTurno.DisplayMember = "Text";
                comboBoxTurno.ValueMember = "Value";
                comboBoxTurno.Items.Add(new { Text = "Seleccione el turno", Value = 0 });
                foreach (Turno turno in turnos)
                {
                    comboBoxTurno.Items.Add(new { Text = turno.descripcion, Value = turno.id });
                }
                comboBoxTurno.SelectedIndex = comboBoxTurno.FindString(automovil.turno.descripcion);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private void mapearChoferesACombo()
        {
            try
            {
                Chofer turno_mapper = new Chofer();
                List<Chofer> choferes = turno_mapper.ObtenerChoferes();
                comboBoxChofer.DisplayMember = "Text";
                comboBoxChofer.ValueMember = "Value";
                comboBoxChofer.Items.Add(new { Text = "Seleccione el Chofer", Value = 0 });
                foreach (Chofer chofer in choferes)
                {
                    comboBoxChofer.Items.Add(new { Text = chofer.nombre + ' ' + chofer.apellido, Value = chofer.id });
                }
                comboBoxChofer.SelectedIndex = comboBoxChofer.FindString(automovil.chofer.nombre + ' ' + automovil.chofer.apellido);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
