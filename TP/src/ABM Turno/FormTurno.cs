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

        }
    }
}
