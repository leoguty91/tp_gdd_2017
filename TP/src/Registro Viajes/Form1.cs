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
            try
            {
                InitializeComponent();
                cargaDatos();
                Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Registro de viaje error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargaDatos()
        {
            try
            {
                ComboBoxManager cbm = new ComboBoxManager();
                string chofer_seleccionado = "";
                string automovil_seleccionado = "";
                if (SingletonUsuario.Instance.rol_actual.nombre == "Chofer")
                {
                    chofer_seleccionado = cargaChoferSeleccionado(SingletonUsuario.Instance.id);
                    comboBoxChofer.Enabled = false;
                    automovil_seleccionado = cargaAutomovilSeleccionado(SingletonUsuario.Instance.id);
                }
                comboBoxChofer = cbm.Chofer(comboBoxChofer, chofer_seleccionado);
                comboBoxAutomovil = cbm.Automovil(comboBoxAutomovil, automovil_seleccionado);
                comboBoxCliente = cbm.Cliente(comboBoxCliente);
                comboBoxTurno = cbm.Turno(comboBoxTurno);
                dateTimePickerFechaInicio.Value = FechaSistema.getDateTime();
                dateTimePickerFechaFin.Value = FechaSistema.getDateTime();
                dateTimePickerFechaInicio.CustomFormat = "dd/MM/yyyy - HH:mm";
                dateTimePickerFechaFin.CustomFormat = "dd/MM/yyyy - HH:mm";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private string cargaChoferSeleccionado(int usuario_id)
        {
            try
            {
                Chofer chofer_mapper = new Chofer();
                Chofer chofer = chofer_mapper.MapearDeUsuario(usuario_id);
                if (!chofer.habilitado)
                    throw new Exception("El chofer seleccionado se encuentra inhabilitado");
                return chofer.nombre + ' ' + chofer.apellido;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private string cargaAutomovilSeleccionado(int usuario_id)
        {
            try
            {
                Automovil automovil_mapper = new Automovil();
                Automovil automovil = automovil_mapper.MapearDeUsuario(usuario_id);
                return automovil.marca.nombre + ' ' + automovil.modelo + ' ' + automovil.patente;
            }
            catch (Exception)
            {
                throw new Exception("El chofer seleccionado no tiene un automovil activo");
            }
        }

        private void comboBoxChofer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((comboBoxChofer.SelectedItem as dynamic).Value > 0)
            {
                try
                {
                    ComboBoxManager cbm = new ComboBoxManager();
                    Chofer chofer_mapper = new Chofer();
                    Chofer chofer = chofer_mapper.Mapear((comboBoxChofer.SelectedItem as dynamic).Value);
                    string automovil_seleccionado = cargaAutomovilSeleccionado(chofer.usuario.id);
                    comboBoxAutomovil = cbm.Automovil(comboBoxAutomovil, automovil_seleccionado);
                }
                catch (Exception exception)
                {
                    comboBoxAutomovil.SelectedIndex = 0;
                    MessageBox.Show(exception.Message, "Seleccion de chofer error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int valueParsed;
                if (!Int32.TryParse(textBoxKilometrosRecorridos.Text.Trim(), out valueParsed))
                    throw new Exception("Debe ingresar una cantidad de kilometros del tipo numerico");
                Viaje viaje = new Viaje();
                Chofer chofer_mapper = new Chofer();
                Turno turno_mapper = new Turno();
                Cliente cliente_mapper = new Cliente();
                Automovil automovil_mapper = new Automovil();
                Chofer chofer = chofer_mapper.Mapear((comboBoxChofer.SelectedItem as dynamic).Value);
                Turno turno = turno_mapper.Mapear((comboBoxTurno.SelectedItem as dynamic).Value);
                Cliente cliente = cliente_mapper.Mapear((comboBoxCliente.SelectedItem as dynamic).Value);
                Automovil automovil = automovil_mapper.Mapear((comboBoxAutomovil.SelectedItem as dynamic).Value);
                viaje.chofer = chofer;
                viaje.automovil = automovil;
                viaje.turno = turno;
                viaje.cantidad_kilometros = Convert.ToInt32(textBoxKilometrosRecorridos.Text);
                viaje.fecha_inicio = dateTimePickerFechaInicio.Value;
                viaje.fecha_fin = dateTimePickerFechaFin.Value;
                viaje.cliente = cliente;
                string respuesta = viaje.Guardar();
                MessageBox.Show(respuesta, "Guardado de viaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error en guardado de Registro de viaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
