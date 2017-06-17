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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxMarca.SelectedItem as dynamic).Value == 0)
                    throw new Exception("Debe seleccionar una marca");
                if ((comboBoxTurno.SelectedItem as dynamic).Value == 0)
                    throw new Exception("Debe seleccionar un turno");
                if ((comboBoxChofer.SelectedItem as dynamic).Value == 0)
                    throw new Exception("Debe seleccionar un chofer");
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
        private void cargaAutomovil(int auto_id = Entidad.NUEVO)
        {
            try
            {
                if (auto_id == Entidad.NUEVO)
                {
                    automovil = new Automovil();
                    mapearMarcasACombo();
                    mapearTurnosACombo();
                    mapearChoferesACombo();
                }
                else
                {
                    Automovil automovil_mapper = new Automovil();
                    this.automovil = automovil_mapper.Mapear(auto_id);
                    checkBoxHabilitado.Checked = automovil.habilitado;
                    textBoxModelo.Text = automovil.modelo;
                    textBoxPatente.Text = automovil.patente;
                    mapearMarcasACombo(automovil.marca.nombre);
                    mapearTurnosACombo(automovil.turno.descripcion);
                    mapearChoferesACombo(automovil.chofer.nombre + ' ' + automovil.chofer.apellido);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Automovil error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mapearMarcasACombo(string marca_nombre = "")
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
                comboBoxMarca.SelectedIndex = 0;
                if (!String.IsNullOrWhiteSpace(marca_nombre))
                    comboBoxMarca.SelectedIndex = comboBoxMarca.FindString(marca_nombre);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private void mapearTurnosACombo(string turno_descripcion = "")
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
                comboBoxTurno.SelectedIndex = 0;
                if (!String.IsNullOrWhiteSpace(turno_descripcion))
                    comboBoxTurno.SelectedIndex = comboBoxTurno.FindString(turno_descripcion);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private void mapearChoferesACombo(string chofer_nombre_apellido = "")
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
                comboBoxChofer.SelectedIndex = 0;
                if (!String.IsNullOrWhiteSpace(chofer_nombre_apellido))
                    comboBoxChofer.SelectedIndex = comboBoxChofer.FindString(chofer_nombre_apellido);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
