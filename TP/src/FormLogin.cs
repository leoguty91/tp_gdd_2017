﻿using System;
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

namespace UberFrba
{
    public partial class FormLogin : Form
    {
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        public FormLogin()
        {
            InitializeComponent();
            Show();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                HacerLogin();
            }
        }

        private void usua_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (ValidateChildren())
                {
                    HacerLogin();
                }
            }
        }

        private void HacerLogin()
        {
            try
            {
                LoginHelper login = new LoginHelper();
                login.ObtenerUsuario(usua_usuario.Text, usua_password.Text);
                new UberFrba.Menu.FormPrePrincipal();
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, " Login erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
