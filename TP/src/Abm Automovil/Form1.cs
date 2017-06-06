using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Automovil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2017DataSet.Automovil' Puede moverla o quitarla según sea necesario.
            this.automovilTableAdapter.Fill(this.gD1C2017DataSet.Automovil);

        }
    }
}
