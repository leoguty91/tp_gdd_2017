﻿namespace UberFrba.Registro_Viajes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKilometrosRecorridos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAutomovil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxChofer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaFin);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaInicio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxKilometrosRecorridos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxTurno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxAutomovil);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxChofer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(413, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(139, 231);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(120, 22);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(209, 190);
            this.dateTimePickerFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerFechaFin.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha y hora de Fin del viaje";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(209, 146);
            this.dateTimePickerFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerFechaInicio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha y hora de Inicio del viaje";
            // 
            // textBoxKilometrosRecorridos
            // 
            this.textBoxKilometrosRecorridos.Location = new System.Drawing.Point(209, 94);
            this.textBoxKilometrosRecorridos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKilometrosRecorridos.Name = "textBoxKilometrosRecorridos";
            this.textBoxKilometrosRecorridos.Size = new System.Drawing.Size(184, 20);
            this.textBoxKilometrosRecorridos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kilometros recorridos";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(21, 191);
            this.comboBoxCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(173, 21);
            this.comboBoxCliente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente";
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Location = new System.Drawing.Point(21, 144);
            this.comboBoxTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(173, 21);
            this.comboBoxTurno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turno";
            // 
            // comboBoxAutomovil
            // 
            this.comboBoxAutomovil.Enabled = false;
            this.comboBoxAutomovil.FormattingEnabled = true;
            this.comboBoxAutomovil.Location = new System.Drawing.Point(21, 94);
            this.comboBoxAutomovil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAutomovil.Name = "comboBoxAutomovil";
            this.comboBoxAutomovil.Size = new System.Drawing.Size(173, 21);
            this.comboBoxAutomovil.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Automovil";
            // 
            // comboBoxChofer
            // 
            this.comboBoxChofer.FormattingEnabled = true;
            this.comboBoxChofer.Location = new System.Drawing.Point(119, 47);
            this.comboBoxChofer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxChofer.Name = "comboBoxChofer";
            this.comboBoxChofer.Size = new System.Drawing.Size(168, 21);
            this.comboBoxChofer.TabIndex = 1;
            this.comboBoxChofer.SelectionChangeCommitted += new System.EventHandler(this.comboBoxChofer_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chofer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 284);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Registro de Viajes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKilometrosRecorridos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAutomovil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxChofer;
        private System.Windows.Forms.Label label1;
    }
}