﻿namespace UberFrba.Rendicion_Viajes
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFiltrado = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxImporteTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPorcentaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxChofer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viajidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viajchoferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chofnombreapellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viajturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turndescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnpreciobaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnvalorkilometroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viajcantidadkilometrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viajfechainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viajfechafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienombreapellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viajtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwrendicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2017DataSet = new UberFrba.GD1C2017DataSet();
            this.vw_rendicionTableAdapter = new UberFrba.GD1C2017DataSetTableAdapters.vw_rendicionTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrendicionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFiltrado);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.textBoxImporteTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPorcentaje);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxTurno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxChofer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendición a chofer";
            // 
            // buttonFiltrado
            // 
            this.buttonFiltrado.Location = new System.Drawing.Point(34, 403);
            this.buttonFiltrado.Name = "buttonFiltrado";
            this.buttonFiltrado.Size = new System.Drawing.Size(93, 32);
            this.buttonFiltrado.TabIndex = 11;
            this.buttonFiltrado.Text = "Mostrar";
            this.buttonFiltrado.UseVisualStyleBackColor = true;
            this.buttonFiltrado.Click += new System.EventHandler(this.buttonFiltrado_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(134, 403);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(92, 32);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxImporteTotal
            // 
            this.textBoxImporteTotal.Enabled = false;
            this.textBoxImporteTotal.Location = new System.Drawing.Point(34, 357);
            this.textBoxImporteTotal.Name = "textBoxImporteTotal";
            this.textBoxImporteTotal.Size = new System.Drawing.Size(188, 26);
            this.textBoxImporteTotal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Importe total de la rendición";
            // 
            // textBoxPorcentaje
            // 
            this.textBoxPorcentaje.Location = new System.Drawing.Point(34, 283);
            this.textBoxPorcentaje.Name = "textBoxPorcentaje";
            this.textBoxPorcentaje.Size = new System.Drawing.Size(188, 26);
            this.textBoxPorcentaje.TabIndex = 7;
            this.textBoxPorcentaje.Text = "0,1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Porcentaje de la rendición";
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Location = new System.Drawing.Point(34, 209);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(188, 28);
            this.comboBoxTurno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turno";
            // 
            // comboBoxChofer
            // 
            this.comboBoxChofer.FormattingEnabled = true;
            this.comboBoxChofer.Location = new System.Drawing.Point(34, 142);
            this.comboBoxChofer.Name = "comboBoxChofer";
            this.comboBoxChofer.Size = new System.Drawing.Size(188, 28);
            this.comboBoxChofer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chofer";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "";
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(34, 69);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(188, 26);
            this.dateTimePickerFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(273, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1147, 452);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viajidDataGridViewTextBoxColumn,
            this.viajchoferDataGridViewTextBoxColumn,
            this.chofnombreapellidoDataGridViewTextBoxColumn,
            this.viajturnoDataGridViewTextBoxColumn,
            this.turndescripcionDataGridViewTextBoxColumn,
            this.turnpreciobaseDataGridViewTextBoxColumn,
            this.turnvalorkilometroDataGridViewTextBoxColumn,
            this.viajcantidadkilometrosDataGridViewTextBoxColumn,
            this.viajfechainicioDataGridViewTextBoxColumn,
            this.viajfechafinDataGridViewTextBoxColumn,
            this.clienombreapellidoDataGridViewTextBoxColumn,
            this.viajtotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwrendicionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // viajidDataGridViewTextBoxColumn
            // 
            this.viajidDataGridViewTextBoxColumn.DataPropertyName = "viaj_id";
            this.viajidDataGridViewTextBoxColumn.HeaderText = "viaj_id";
            this.viajidDataGridViewTextBoxColumn.Name = "viajidDataGridViewTextBoxColumn";
            this.viajidDataGridViewTextBoxColumn.ReadOnly = true;
            this.viajidDataGridViewTextBoxColumn.Visible = false;
            // 
            // viajchoferDataGridViewTextBoxColumn
            // 
            this.viajchoferDataGridViewTextBoxColumn.DataPropertyName = "viaj_chofer";
            this.viajchoferDataGridViewTextBoxColumn.HeaderText = "viaj_chofer";
            this.viajchoferDataGridViewTextBoxColumn.Name = "viajchoferDataGridViewTextBoxColumn";
            this.viajchoferDataGridViewTextBoxColumn.ReadOnly = true;
            this.viajchoferDataGridViewTextBoxColumn.Visible = false;
            // 
            // chofnombreapellidoDataGridViewTextBoxColumn
            // 
            this.chofnombreapellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chofnombreapellidoDataGridViewTextBoxColumn.DataPropertyName = "chof_nombre_apellido";
            this.chofnombreapellidoDataGridViewTextBoxColumn.HeaderText = "Chofer";
            this.chofnombreapellidoDataGridViewTextBoxColumn.Name = "chofnombreapellidoDataGridViewTextBoxColumn";
            this.chofnombreapellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viajturnoDataGridViewTextBoxColumn
            // 
            this.viajturnoDataGridViewTextBoxColumn.DataPropertyName = "viaj_turno";
            this.viajturnoDataGridViewTextBoxColumn.HeaderText = "viaj_turno";
            this.viajturnoDataGridViewTextBoxColumn.Name = "viajturnoDataGridViewTextBoxColumn";
            this.viajturnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.viajturnoDataGridViewTextBoxColumn.Visible = false;
            // 
            // turndescripcionDataGridViewTextBoxColumn
            // 
            this.turndescripcionDataGridViewTextBoxColumn.DataPropertyName = "turn_descripcion";
            this.turndescripcionDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turndescripcionDataGridViewTextBoxColumn.Name = "turndescripcionDataGridViewTextBoxColumn";
            this.turndescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turnpreciobaseDataGridViewTextBoxColumn
            // 
            this.turnpreciobaseDataGridViewTextBoxColumn.DataPropertyName = "turn_precio_base";
            this.turnpreciobaseDataGridViewTextBoxColumn.HeaderText = "Precio base";
            this.turnpreciobaseDataGridViewTextBoxColumn.Name = "turnpreciobaseDataGridViewTextBoxColumn";
            this.turnpreciobaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turnvalorkilometroDataGridViewTextBoxColumn
            // 
            this.turnvalorkilometroDataGridViewTextBoxColumn.DataPropertyName = "turn_valor_kilometro";
            this.turnvalorkilometroDataGridViewTextBoxColumn.HeaderText = "Valor KM";
            this.turnvalorkilometroDataGridViewTextBoxColumn.Name = "turnvalorkilometroDataGridViewTextBoxColumn";
            this.turnvalorkilometroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viajcantidadkilometrosDataGridViewTextBoxColumn
            // 
            this.viajcantidadkilometrosDataGridViewTextBoxColumn.DataPropertyName = "viaj_cantidad_kilometros";
            this.viajcantidadkilometrosDataGridViewTextBoxColumn.HeaderText = "Cantidad KM";
            this.viajcantidadkilometrosDataGridViewTextBoxColumn.Name = "viajcantidadkilometrosDataGridViewTextBoxColumn";
            this.viajcantidadkilometrosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viajfechainicioDataGridViewTextBoxColumn
            // 
            this.viajfechainicioDataGridViewTextBoxColumn.DataPropertyName = "viaj_fecha_inicio";
            this.viajfechainicioDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio";
            this.viajfechainicioDataGridViewTextBoxColumn.Name = "viajfechainicioDataGridViewTextBoxColumn";
            this.viajfechainicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viajfechafinDataGridViewTextBoxColumn
            // 
            this.viajfechafinDataGridViewTextBoxColumn.DataPropertyName = "viaj_fecha_fin";
            this.viajfechafinDataGridViewTextBoxColumn.HeaderText = "Fecha Fin";
            this.viajfechafinDataGridViewTextBoxColumn.Name = "viajfechafinDataGridViewTextBoxColumn";
            this.viajfechafinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienombreapellidoDataGridViewTextBoxColumn
            // 
            this.clienombreapellidoDataGridViewTextBoxColumn.DataPropertyName = "clie_nombre_apellido";
            this.clienombreapellidoDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienombreapellidoDataGridViewTextBoxColumn.Name = "clienombreapellidoDataGridViewTextBoxColumn";
            this.clienombreapellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viajtotalDataGridViewTextBoxColumn
            // 
            this.viajtotalDataGridViewTextBoxColumn.DataPropertyName = "viaj_total";
            this.viajtotalDataGridViewTextBoxColumn.HeaderText = "Monto Viaje";
            this.viajtotalDataGridViewTextBoxColumn.Name = "viajtotalDataGridViewTextBoxColumn";
            this.viajtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vwrendicionBindingSource
            // 
            this.vwrendicionBindingSource.DataMember = "vw_rendicion";
            this.vwrendicionBindingSource.DataSource = this.gD1C2017DataSet;
            // 
            // gD1C2017DataSet
            // 
            this.gD1C2017DataSet.DataSetName = "GD1C2017DataSet";
            this.gD1C2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_rendicionTableAdapter
            // 
            this.vw_rendicionTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Rendicion de Viajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrendicionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxImporteTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPorcentaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxChofer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFiltrado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2017DataSet gD1C2017DataSet;
        private System.Windows.Forms.BindingSource vwrendicionBindingSource;
        private GD1C2017DataSetTableAdapters.vw_rendicionTableAdapter vw_rendicionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn viajidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viajchoferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofnombreapellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viajturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turndescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnpreciobaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnvalorkilometroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viajcantidadkilometrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viajfechainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viajfechafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienombreapellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viajtotalDataGridViewTextBoxColumn;
    }
}