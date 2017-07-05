namespace UberFrba.Abm_Automovil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxChofer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.textBoxPatente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vw_automovil_listadoTableAdapter = new UberFrba.GD1C2017DataSetTableAdapters.vw_automovil_listadoTableAdapter();
            this.gD1C2017DataSet = new UberFrba.GD1C2017DataSet();
            this.vwautomovillistadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automodeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autopatenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autochoferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chofnombreapellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwautomovillistadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automovil";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.buttonAlta);
            this.groupBox3.Location = new System.Drawing.Point(281, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 281);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Automoviles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoidDataGridViewTextBoxColumn,
            this.marcnombreDataGridViewTextBoxColumn,
            this.automodeloDataGridViewTextBoxColumn,
            this.autopatenteDataGridViewTextBoxColumn,
            this.autochoferDataGridViewTextBoxColumn,
            this.chofnombreapellidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwautomovillistadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(492, 173);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(198, 236);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(163, 26);
            this.buttonAlta.TabIndex = 8;
            this.buttonAlta.Text = "Nuevo Automovil";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxChofer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonFiltrar);
            this.groupBox2.Controls.Add(this.textBoxPatente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxModelo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxMarca);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(33, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 281);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // textBoxChofer
            // 
            this.textBoxChofer.Location = new System.Drawing.Point(28, 198);
            this.textBoxChofer.Name = "textBoxChofer";
            this.textBoxChofer.Size = new System.Drawing.Size(163, 20);
            this.textBoxChofer.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chofer";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(27, 236);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(163, 26);
            this.buttonFiltrar.TabIndex = 1;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // textBoxPatente
            // 
            this.textBoxPatente.Location = new System.Drawing.Point(27, 144);
            this.textBoxPatente.Name = "textBoxPatente";
            this.textBoxPatente.Size = new System.Drawing.Size(163, 20);
            this.textBoxPatente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patente";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(25, 92);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(163, 20);
            this.textBoxModelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(25, 42);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(164, 21);
            this.comboBoxMarca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // vw_automovil_listadoTableAdapter
            // 
            this.vw_automovil_listadoTableAdapter.ClearBeforeFill = true;
            // 
            // gD1C2017DataSet
            // 
            this.gD1C2017DataSet.DataSetName = "GD1C2017DataSet";
            this.gD1C2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwautomovillistadoBindingSource
            // 
            this.vwautomovillistadoBindingSource.DataMember = "vw_automovil_listado";
            this.vwautomovillistadoBindingSource.DataSource = this.gD1C2017DataSet;
            // 
            // autoidDataGridViewTextBoxColumn
            // 
            this.autoidDataGridViewTextBoxColumn.DataPropertyName = "auto_id";
            this.autoidDataGridViewTextBoxColumn.HeaderText = "auto_id";
            this.autoidDataGridViewTextBoxColumn.Name = "autoidDataGridViewTextBoxColumn";
            this.autoidDataGridViewTextBoxColumn.ReadOnly = true;
            this.autoidDataGridViewTextBoxColumn.Visible = false;
            // 
            // marcnombreDataGridViewTextBoxColumn
            // 
            this.marcnombreDataGridViewTextBoxColumn.DataPropertyName = "marc_nombre";
            this.marcnombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.marcnombreDataGridViewTextBoxColumn.Name = "marcnombreDataGridViewTextBoxColumn";
            this.marcnombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // automodeloDataGridViewTextBoxColumn
            // 
            this.automodeloDataGridViewTextBoxColumn.DataPropertyName = "auto_modelo";
            this.automodeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.automodeloDataGridViewTextBoxColumn.Name = "automodeloDataGridViewTextBoxColumn";
            this.automodeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autopatenteDataGridViewTextBoxColumn
            // 
            this.autopatenteDataGridViewTextBoxColumn.DataPropertyName = "auto_patente";
            this.autopatenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            this.autopatenteDataGridViewTextBoxColumn.Name = "autopatenteDataGridViewTextBoxColumn";
            this.autopatenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autochoferDataGridViewTextBoxColumn
            // 
            this.autochoferDataGridViewTextBoxColumn.DataPropertyName = "auto_chofer";
            this.autochoferDataGridViewTextBoxColumn.HeaderText = "auto_chofer";
            this.autochoferDataGridViewTextBoxColumn.Name = "autochoferDataGridViewTextBoxColumn";
            this.autochoferDataGridViewTextBoxColumn.ReadOnly = true;
            this.autochoferDataGridViewTextBoxColumn.Visible = false;
            // 
            // chofnombreapellidoDataGridViewTextBoxColumn
            // 
            this.chofnombreapellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chofnombreapellidoDataGridViewTextBoxColumn.DataPropertyName = "chof_nombre_apellido";
            this.chofnombreapellidoDataGridViewTextBoxColumn.HeaderText = "Chofer";
            this.chofnombreapellidoDataGridViewTextBoxColumn.Name = "chofnombreapellidoDataGridViewTextBoxColumn";
            this.chofnombreapellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 350);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ABM de Automoviles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwautomovillistadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.TextBox textBoxPatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2017DataSetTableAdapters.vw_automovil_listadoTableAdapter vw_automovil_listadoTableAdapter;
        private System.Windows.Forms.TextBox textBoxChofer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource vwautomovillistadoBindingSource;
        private GD1C2017DataSet gD1C2017DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn automodeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autopatenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autochoferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofnombreapellidoDataGridViewTextBoxColumn;
    }
}