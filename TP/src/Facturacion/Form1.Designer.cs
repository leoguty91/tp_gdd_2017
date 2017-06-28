namespace UberFrba.Facturacion
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
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.textBoxImporteTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vwrendicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2017DataSet = new UberFrba.GD1C2017DataSet();
            this.vw_rendicionTableAdapter = new UberFrba.GD1C2017DataSetTableAdapters.vw_rendicionTableAdapter();
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
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCliente);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.buttonMostrar);
            this.groupBox1.Controls.Add(this.textBoxImporteTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturacion al cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(22, 112);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(214, 21);
            this.comboBoxCliente.TabIndex = 8;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(137, 226);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(98, 28);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(22, 226);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(95, 28);
            this.buttonMostrar.TabIndex = 6;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // textBoxImporteTotal
            // 
            this.textBoxImporteTotal.Enabled = false;
            this.textBoxImporteTotal.Location = new System.Drawing.Point(22, 176);
            this.textBoxImporteTotal.Name = "textBoxImporteTotal";
            this.textBoxImporteTotal.Size = new System.Drawing.Size(213, 20);
            this.textBoxImporteTotal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Importe Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(22, 48);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(215, 20);
            this.dateTimePickerFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(304, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 279);
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
            this.dataGridView1.DataSource = this.vwrendicionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(956, 222);
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
            this.turnpreciobaseDataGridViewTextBoxColumn.HeaderText = "Precio Base";
            this.turnpreciobaseDataGridViewTextBoxColumn.Name = "turnpreciobaseDataGridViewTextBoxColumn";
            this.turnpreciobaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turnvalorkilometroDataGridViewTextBoxColumn
            // 
            this.turnvalorkilometroDataGridViewTextBoxColumn.DataPropertyName = "turn_valor_kilometro";
            this.turnvalorkilometroDataGridViewTextBoxColumn.HeaderText = "Valor Km";
            this.turnvalorkilometroDataGridViewTextBoxColumn.Name = "turnvalorkilometroDataGridViewTextBoxColumn";
            this.turnvalorkilometroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viajcantidadkilometrosDataGridViewTextBoxColumn
            // 
            this.viajcantidadkilometrosDataGridViewTextBoxColumn.DataPropertyName = "viaj_cantidad_kilometros";
            this.viajcantidadkilometrosDataGridViewTextBoxColumn.HeaderText = "Cantidad Km";
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
            this.viajtotalDataGridViewTextBoxColumn.HeaderText = "Monto del viaje";
            this.viajtotalDataGridViewTextBoxColumn.Name = "viajtotalDataGridViewTextBoxColumn";
            this.viajtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Facturacion";
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.TextBox textBoxImporteTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
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
    }
}