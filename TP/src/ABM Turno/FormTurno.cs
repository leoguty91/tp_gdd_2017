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

namespace UberFrba.ABM_Turno
{
    public partial class FormTurno : Form
    {
        private Turno turno { get; set; }
        public FormTurno(int turno_id = Entidad.NUEVO)
        {
            InitializeComponent();
            cargaTurno(turno_id);
            Show();
        }
        private void cargaTurno(int turno_id = Entidad.NUEVO)
        {
            try
            {
                if (turno_id == Entidad.NUEVO)
                {
                    turno = new Turno();
                }
                else
                {
                    Turno turno_mapper = new Turno();
                    this.turno = turno_mapper.Mapear(turno_id);
                    checkBoxHabilitado.Checked = turno.habilitado;
                    textBoxHoraInicio.Text = turno.hora_inicio.ToString();
                    textBoxHoraFin.Text = turno.hora_fin.ToString();
                    textBoxDescripcion.Text = turno.descripcion;
                    textBoxValorKM.Text = turno.valor_kilometro.ToString();
                    textBoxPrecioBase.Text = turno.precio_base.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Turno error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int valueParsed;
                if (!Int32.TryParse(textBoxHoraInicio.Text.Trim(), out valueParsed))
                    throw new Exception("Debe ingresar una hora de inicio numerica");
                if (!Int32.TryParse(textBoxHoraFin.Text.Trim(), out valueParsed))
                    throw new Exception("Debe ingresar una hora de fin numerica");
                if (textBoxDescripcion.Text == "")
                    throw new Exception("Debe ingresar una descripcion");
                decimal valueParse;
                if (!Decimal.TryParse(textBoxValorKM.Text.Trim(), out valueParse))
                    throw new Exception("Debe ingresar un valor de kilometraje decimal");
                if (!Decimal.TryParse(textBoxPrecioBase.Text.Trim(), out valueParse))
                    throw new Exception("Debe ingresar un valor de precio base decimal");
                turno.habilitado = checkBoxHabilitado.Checked;
                turno.hora_inicio = Convert.ToInt32(textBoxHoraInicio.Text);
                turno.hora_fin = Convert.ToInt32(textBoxHoraFin.Text);
                turno.descripcion = textBoxDescripcion.Text;
                turno.valor_kilometro = Convert.ToDecimal(textBoxValorKM.Text);
                turno.precio_base = Convert.ToDecimal(textBoxPrecioBase.Text);
                string respuesta = turno.Guardar();
                MessageBox.Show(respuesta, "Guardado de turno", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Guardado de cliente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
