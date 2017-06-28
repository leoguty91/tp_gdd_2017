namespace UberFrba.Rendicion_Viajes
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
            this.vwrendicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2017DataSet = new UberFrba.GD1C2017DataSet();
            this.vw_rendicionTableAdapter = new UberFrba.GD1C2017DataSetTableAdapters.vw_rendicionTableAdapter();
            this.vwrendicionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.clie_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienombreapellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viajtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrendicionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrendicionBindingSource1)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(170, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendición a chofer";
            // 
            // buttonFiltrado
            // 
            this.buttonFiltrado.Location = new System.Drawing.Point(23, 262);
            this.buttonFiltrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFiltrado.Name = "buttonFiltrado";
            this.buttonFiltrado.Size = new System.Drawing.Size(62, 21);
            this.buttonFiltrado.TabIndex = 11;
            this.buttonFiltrado.Text = "Mostrar";
            this.buttonFiltrado.UseVisualStyleBackColor = true;
            this.buttonFiltrado.Click += new System.EventHandler(this.buttonFiltrado_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(89, 262);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(61, 21);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxImporteTotal
            // 
            this.textBoxImporteTotal.Enabled = false;
            this.textBoxImporteTotal.Location = new System.Drawing.Point(23, 232);
            this.textBoxImporteTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxImporteTotal.Name = "textBoxImporteTotal";
            this.textBoxImporteTotal.Size = new System.Drawing.Size(127, 20);
            this.textBoxImporteTotal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Importe total de la rendición";
            // 
            // textBoxPorcentaje
            // 
            this.textBoxPorcentaje.Location = new System.Drawing.Point(23, 184);
            this.textBoxPorcentaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPorcentaje.Name = "textBoxPorcentaje";
            this.textBoxPorcentaje.Size = new System.Drawing.Size(127, 20);
            this.textBoxPorcentaje.TabIndex = 7;
            this.textBoxPorcentaje.Text = "0,1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Porcentaje de la rendición";
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Location = new System.Drawing.Point(23, 136);
            this.comboBoxTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(127, 21);
            this.comboBoxTurno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turno";
            // 
            // comboBoxChofer
            // 
            this.comboBoxChofer.FormattingEnabled = true;
            this.comboBoxChofer.Location = new System.Drawing.Point(23, 92);
            this.comboBoxChofer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxChofer.Name = "comboBoxChofer";
            this.comboBoxChofer.Size = new System.Drawing.Size(127, 21);
            this.comboBoxChofer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chofer";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "";
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(23, 45);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(182, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(765, 294);
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
            this.clie_id,
            this.clienombreapellidoDataGridViewTextBoxColumn,
            this.viajtotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwrendicionBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(723, 252);
            this.dataGridView1.TabIndex = 0;
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
            // vwrendicionBindingSource1
            // 
            this.vwrendicionBindingSource1.DataMember = "vw_rendicion";
            this.vwrendicionBindingSource1.DataSource = this.gD1C2017DataSet;
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
            // clie_id
            // 
            this.clie_id.DataPropertyName = "clie_id";
            this.clie_id.HeaderText = "clie_id";
            this.clie_id.Name = "clie_id";
            this.clie_id.ReadOnly = true;
            this.clie_id.Visible = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 310);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Rendicion de Viajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrendicionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwrendicionBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clie_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienombreapellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viajtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwrendicionBindingSource1;
    }
}