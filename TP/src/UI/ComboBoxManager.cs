using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Entidades;

namespace UberFrba.UI
{
    public class ComboBoxManager
    {
        public ComboBox Marca(ComboBox combo, string marca_nombre = "")
        {
            try
            {
                Marca marca_mapper = new Marca();
                List<Marca> marcas = marca_mapper.ObtenerMarcas();
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                combo.Items.Add(new { Text = "Seleccione la marca", Value = 0 });
                foreach (Marca marca in marcas)
                {
                    combo.Items.Add(new { Text = marca.nombre, Value = marca.id });
                }
                combo.SelectedIndex = 0;
                if (!String.IsNullOrWhiteSpace(marca_nombre))
                    combo.SelectedIndex = combo.FindString(marca_nombre);
                return combo;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public ComboBox Turno(ComboBox combo, string turno_descripcion = "")
        {
            try
            {
                Turno turno_mapper = new Turno();
                List<Turno> turnos = turno_mapper.ObtenerTurnos();
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                combo.Items.Add(new { Text = "Seleccione el turno", Value = 0 });
                foreach (Turno turno in turnos)
                {
                    combo.Items.Add(new { Text = turno.descripcion, Value = turno.id });
                }
                combo.SelectedIndex = 0;
                if (!String.IsNullOrWhiteSpace(turno_descripcion))
                    combo.SelectedIndex = combo.FindString(turno_descripcion);
                return combo;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public ComboBox Chofer(ComboBox combo, string chofer_nombre_apellido = "")
        {
            try
            {
                Chofer chofer_mapper = new Chofer();
                List<Chofer> choferes = chofer_mapper.ObtenerChoferes();
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                combo.Items.Add(new { Text = "Seleccione el Chofer", Value = 0 });
                foreach (Chofer chofer in choferes)
                {
                    combo.Items.Add(new { Text = chofer.nombre + ' ' + chofer.apellido, Value = chofer.id });
                }
                combo.SelectedIndex = 0;
                if (!String.IsNullOrWhiteSpace(chofer_nombre_apellido))
                    combo.SelectedIndex = combo.FindString(chofer_nombre_apellido);
                return combo;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public ComboBox Cliente(ComboBox combo, string cliente_nombre_apellido = "")
        {
            try
            {
                Cliente cliente_mapper = new Cliente();
                List<Cliente> clientes = cliente_mapper.ObtenerClientes();
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                combo.Items.Add(new { Text = "Seleccione el Cliente", Value = 0 });
                foreach (Cliente cliente in clientes)
                {
                    combo.Items.Add(new { Text = cliente.nombre + ' ' + cliente.apellido, Value = cliente.id });
                }
                combo.SelectedIndex = 0;
                if (!String.IsNullOrWhiteSpace(cliente_nombre_apellido))
                    combo.SelectedIndex = combo.FindString(cliente_nombre_apellido);
                return combo;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public ComboBox Automovil(ComboBox combo, string auto_marca_modelo_patente = "")
        {
            try
            {
                Automovil cliente_mapper = new Automovil();
                List<Automovil> automoviles = cliente_mapper.ObtenerAutomoviles();
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                combo.Items.Add(new { Text = "Seleccione el Automovil", Value = 0 });
                foreach (Automovil automovil in automoviles)
                {
                    combo.Items.Add(new { Text = automovil.marca.nombre + ' ' + automovil.modelo + ' ' + automovil.patente, Value = automovil.id });
                }
                combo.SelectedIndex = 0;
                if (!String.IsNullOrWhiteSpace(auto_marca_modelo_patente))
                    combo.SelectedIndex = combo.FindString(auto_marca_modelo_patente);
                return combo;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
