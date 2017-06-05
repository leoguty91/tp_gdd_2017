namespace UberFrba.Abm_Rol
{
    partial class ABMRol
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rolidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolhabilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2017DataSet = new UberFrba.GD1C2017DataSet();
            this.rolTableAdapter = new UberFrba.GD1C2017DataSetTableAdapters.RolTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rol";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Rol";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolidDataGridViewTextBoxColumn,
            this.rolnombreDataGridViewTextBoxColumn,
            this.rolhabilitadoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.rolBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(213, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // rolidDataGridViewTextBoxColumn
            // 
            this.rolidDataGridViewTextBoxColumn.DataPropertyName = "rol_id";
            this.rolidDataGridViewTextBoxColumn.HeaderText = "rol_id";
            this.rolidDataGridViewTextBoxColumn.Name = "rolidDataGridViewTextBoxColumn";
            this.rolidDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolidDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolnombreDataGridViewTextBoxColumn
            // 
            this.rolnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rolnombreDataGridViewTextBoxColumn.DataPropertyName = "rol_nombre";
            this.rolnombreDataGridViewTextBoxColumn.HeaderText = "Selecciones Rol a Modificar";
            this.rolnombreDataGridViewTextBoxColumn.Name = "rolnombreDataGridViewTextBoxColumn";
            this.rolnombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolhabilitadoDataGridViewCheckBoxColumn
            // 
            this.rolhabilitadoDataGridViewCheckBoxColumn.DataPropertyName = "rol_habilitado";
            this.rolhabilitadoDataGridViewCheckBoxColumn.HeaderText = "rol_habilitado";
            this.rolhabilitadoDataGridViewCheckBoxColumn.Name = "rolhabilitadoDataGridViewCheckBoxColumn";
            this.rolhabilitadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.rolhabilitadoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.gD1C2017DataSet;
            // 
            // gD1C2017DataSet
            // 
            this.gD1C2017DataSet.DataSetName = "GD1C2017DataSet";
            this.gD1C2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 365);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABMRol";
            this.Text = "ABM Roles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2017DataSet gD1C2017DataSet;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private GD1C2017DataSetTableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rolhabilitadoDataGridViewCheckBoxColumn;
    }
}