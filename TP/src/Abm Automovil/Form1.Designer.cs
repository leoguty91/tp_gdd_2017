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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gD1C2017DataSet = new UberFrba.GD1C2017DataSet();
            this.gD1C2017DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automovilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automovilTableAdapter = new UberFrba.GD1C2017DataSetTableAdapters.AutomovilTableAdapter();
            this.autoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automodeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autopatenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autochoferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autohabilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automovilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automovil";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoidDataGridViewTextBoxColumn,
            this.automarcaDataGridViewTextBoxColumn,
            this.automodeloDataGridViewTextBoxColumn,
            this.autopatenteDataGridViewTextBoxColumn,
            this.autoturnoDataGridViewTextBoxColumn,
            this.autochoferDataGridViewTextBoxColumn,
            this.autohabilitadoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.automovilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // gD1C2017DataSet
            // 
            this.gD1C2017DataSet.DataSetName = "GD1C2017DataSet";
            this.gD1C2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD1C2017DataSetBindingSource
            // 
            this.gD1C2017DataSetBindingSource.DataSource = this.gD1C2017DataSet;
            this.gD1C2017DataSetBindingSource.Position = 0;
            // 
            // automovilBindingSource
            // 
            this.automovilBindingSource.DataMember = "Automovil";
            this.automovilBindingSource.DataSource = this.gD1C2017DataSet;
            // 
            // automovilTableAdapter
            // 
            this.automovilTableAdapter.ClearBeforeFill = true;
            // 
            // autoidDataGridViewTextBoxColumn
            // 
            this.autoidDataGridViewTextBoxColumn.DataPropertyName = "auto_id";
            this.autoidDataGridViewTextBoxColumn.HeaderText = "auto_id";
            this.autoidDataGridViewTextBoxColumn.Name = "autoidDataGridViewTextBoxColumn";
            this.autoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // automarcaDataGridViewTextBoxColumn
            // 
            this.automarcaDataGridViewTextBoxColumn.DataPropertyName = "auto_marca";
            this.automarcaDataGridViewTextBoxColumn.HeaderText = "auto_marca";
            this.automarcaDataGridViewTextBoxColumn.Name = "automarcaDataGridViewTextBoxColumn";
            // 
            // automodeloDataGridViewTextBoxColumn
            // 
            this.automodeloDataGridViewTextBoxColumn.DataPropertyName = "auto_modelo";
            this.automodeloDataGridViewTextBoxColumn.HeaderText = "auto_modelo";
            this.automodeloDataGridViewTextBoxColumn.Name = "automodeloDataGridViewTextBoxColumn";
            // 
            // autopatenteDataGridViewTextBoxColumn
            // 
            this.autopatenteDataGridViewTextBoxColumn.DataPropertyName = "auto_patente";
            this.autopatenteDataGridViewTextBoxColumn.HeaderText = "auto_patente";
            this.autopatenteDataGridViewTextBoxColumn.Name = "autopatenteDataGridViewTextBoxColumn";
            // 
            // autoturnoDataGridViewTextBoxColumn
            // 
            this.autoturnoDataGridViewTextBoxColumn.DataPropertyName = "auto_turno";
            this.autoturnoDataGridViewTextBoxColumn.HeaderText = "auto_turno";
            this.autoturnoDataGridViewTextBoxColumn.Name = "autoturnoDataGridViewTextBoxColumn";
            // 
            // autochoferDataGridViewTextBoxColumn
            // 
            this.autochoferDataGridViewTextBoxColumn.DataPropertyName = "auto_chofer";
            this.autochoferDataGridViewTextBoxColumn.HeaderText = "auto_chofer";
            this.autochoferDataGridViewTextBoxColumn.Name = "autochoferDataGridViewTextBoxColumn";
            // 
            // autohabilitadoDataGridViewCheckBoxColumn
            // 
            this.autohabilitadoDataGridViewCheckBoxColumn.DataPropertyName = "auto_habilitado";
            this.autohabilitadoDataGridViewCheckBoxColumn.HeaderText = "auto_habilitado";
            this.autohabilitadoDataGridViewCheckBoxColumn.Name = "autohabilitadoDataGridViewCheckBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Automovil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 355);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ABM de Automoviles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automovilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gD1C2017DataSetBindingSource;
        private GD1C2017DataSet gD1C2017DataSet;
        private System.Windows.Forms.BindingSource automovilBindingSource;
        private GD1C2017DataSetTableAdapters.AutomovilTableAdapter automovilTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn automarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn automodeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autopatenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autochoferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autohabilitadoDataGridViewCheckBoxColumn;
    }
}