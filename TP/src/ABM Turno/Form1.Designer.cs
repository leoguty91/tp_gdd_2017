namespace UberFrba.ABM_Turno
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAltaTurno = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2017DataSet = new UberFrba.GD1C2017DataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.turnoTableAdapter = new UberFrba.GD1C2017DataSetTableAdapters.TurnoTableAdapter();
            this.turnidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnhorainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnhorafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turndescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnvalorkilometroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnhabilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(656, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turnos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAltaTurno);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(179, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(462, 179);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Turnos";
            // 
            // buttonAltaTurno
            // 
            this.buttonAltaTurno.Location = new System.Drawing.Point(167, 141);
            this.buttonAltaTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAltaTurno.Name = "buttonAltaTurno";
            this.buttonAltaTurno.Size = new System.Drawing.Size(113, 21);
            this.buttonAltaTurno.TabIndex = 3;
            this.buttonAltaTurno.Text = "Nuevo Turno";
            this.buttonAltaTurno.UseVisualStyleBackColor = true;
            this.buttonAltaTurno.Click += new System.EventHandler(this.buttonAltaTurno_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turnidDataGridViewTextBoxColumn,
            this.turnhorainicioDataGridViewTextBoxColumn,
            this.turnhorafinDataGridViewTextBoxColumn,
            this.turndescripcionDataGridViewTextBoxColumn,
            this.turnvalorkilometroDataGridViewTextBoxColumn,
            this.turnhabilitadoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.turnoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(422, 98);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "Turno";
            this.turnoBindingSource.DataSource = this.gD1C2017DataSet;
            // 
            // gD1C2017DataSet
            // 
            this.gD1C2017DataSet.DataSetName = "GD1C2017DataSet";
            this.gD1C2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFiltrar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(16, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(149, 179);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrado";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(18, 107);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(113, 21);
            this.buttonFiltrar.TabIndex = 2;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(17, 59);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(115, 20);
            this.textBoxDescripcion.TabIndex = 0;
            // 
            // turnoTableAdapter
            // 
            this.turnoTableAdapter.ClearBeforeFill = true;
            // 
            // turnidDataGridViewTextBoxColumn
            // 
            this.turnidDataGridViewTextBoxColumn.DataPropertyName = "turn_id";
            this.turnidDataGridViewTextBoxColumn.HeaderText = "turn_id";
            this.turnidDataGridViewTextBoxColumn.Name = "turnidDataGridViewTextBoxColumn";
            this.turnidDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnidDataGridViewTextBoxColumn.Visible = false;
            // 
            // turnhorainicioDataGridViewTextBoxColumn
            // 
            this.turnhorainicioDataGridViewTextBoxColumn.DataPropertyName = "turn_hora_inicio";
            this.turnhorainicioDataGridViewTextBoxColumn.HeaderText = "Inicio";
            this.turnhorainicioDataGridViewTextBoxColumn.Name = "turnhorainicioDataGridViewTextBoxColumn";
            this.turnhorainicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnhorainicioDataGridViewTextBoxColumn.Width = 60;
            // 
            // turnhorafinDataGridViewTextBoxColumn
            // 
            this.turnhorafinDataGridViewTextBoxColumn.DataPropertyName = "turn_hora_fin";
            this.turnhorafinDataGridViewTextBoxColumn.HeaderText = "Fin";
            this.turnhorafinDataGridViewTextBoxColumn.Name = "turnhorafinDataGridViewTextBoxColumn";
            this.turnhorafinDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnhorafinDataGridViewTextBoxColumn.Width = 60;
            // 
            // turndescripcionDataGridViewTextBoxColumn
            // 
            this.turndescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.turndescripcionDataGridViewTextBoxColumn.DataPropertyName = "turn_descripcion";
            this.turndescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.turndescripcionDataGridViewTextBoxColumn.Name = "turndescripcionDataGridViewTextBoxColumn";
            this.turndescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turnvalorkilometroDataGridViewTextBoxColumn
            // 
            this.turnvalorkilometroDataGridViewTextBoxColumn.DataPropertyName = "turn_valor_kilometro";
            this.turnvalorkilometroDataGridViewTextBoxColumn.HeaderText = "Valor km";
            this.turnvalorkilometroDataGridViewTextBoxColumn.Name = "turnvalorkilometroDataGridViewTextBoxColumn";
            this.turnvalorkilometroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turnhabilitadoDataGridViewCheckBoxColumn
            // 
            this.turnhabilitadoDataGridViewCheckBoxColumn.DataPropertyName = "turn_habilitado";
            this.turnhabilitadoDataGridViewCheckBoxColumn.HeaderText = "turn_habilitado";
            this.turnhabilitadoDataGridViewCheckBoxColumn.Name = "turnhabilitadoDataGridViewCheckBoxColumn";
            this.turnhabilitadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.turnhabilitadoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 253);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ABM de Turnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2017DataSet gD1C2017DataSet;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private GD1C2017DataSetTableAdapters.TurnoTableAdapter turnoTableAdapter;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonAltaTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnhorainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnhorafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turndescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnvalorkilometroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn turnhabilitadoDataGridViewCheckBoxColumn;
    }
}