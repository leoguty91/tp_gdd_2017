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
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Automovil error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargaMarca()
        {

        }
    }
}
