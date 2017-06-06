namespace UberFrba.Abm_Chofer
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
            this.choferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.choferTableAdapter = new UberFrba.GD1C2017DataSetTableAdapters.ChoferTableAdapter();
            this.chofidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chofnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chofapellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chofdniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chofmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choftelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chofdireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chofcodigopostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choffechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chofhabilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chofusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 398);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chofer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chofidDataGridViewTextBoxColumn,
            this.chofnombreDataGridViewTextBoxColumn,
            this.chofapellidoDataGridViewTextBoxColumn,
            this.chofdniDataGridViewTextBoxColumn,
            this.chofmailDataGridViewTextBoxColumn,
            this.choftelefonoDataGridViewTextBoxColumn,
            this.chofdireccionDataGridViewTextBoxColumn,
            this.chofcodigopostalDataGridViewTextBoxColumn,
            this.choffechanacimientoDataGridViewTextBoxColumn,
            this.chofhabilitadoDataGridViewCheckBoxColumn,
            this.chofusuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.choferBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // gD1C2017DataSet
            // 
            this.gD1C2017DataSet.DataSetName = "GD1C2017DataSet";
            this.gD1C2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // choferBindingSource
            // 
            this.choferBindingSource.DataMember = "Chofer";
            this.choferBindingSource.DataSource = this.gD1C2017DataSet;
            // 
            // choferTableAdapter
            // 
            this.choferTableAdapter.ClearBeforeFill = true;
            // 
            // chofidDataGridViewTextBoxColumn
            // 
            this.chofidDataGridViewTextBoxColumn.DataPropertyName = "chof_id";
            this.chofidDataGridViewTextBoxColumn.HeaderText = "chof_id";
            this.chofidDataGridViewTextBoxColumn.Name = "chofidDataGridViewTextBoxColumn";
            this.chofidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chofnombreDataGridViewTextBoxColumn
            // 
            this.chofnombreDataGridViewTextBoxColumn.DataPropertyName = "chof_nombre";
            this.chofnombreDataGridViewTextBoxColumn.HeaderText = "chof_nombre";
            this.chofnombreDataGridViewTextBoxColumn.Name = "chofnombreDataGridViewTextBoxColumn";
            // 
            // chofapellidoDataGridViewTextBoxColumn
            // 
            this.chofapellidoDataGridViewTextBoxColumn.DataPropertyName = "chof_apellido";
            this.chofapellidoDataGridViewTextBoxColumn.HeaderText = "chof_apellido";
            this.chofapellidoDataGridViewTextBoxColumn.Name = "chofapellidoDataGridViewTextBoxColumn";
            // 
            // chofdniDataGridViewTextBoxColumn
            // 
            this.chofdniDataGridViewTextBoxColumn.DataPropertyName = "chof_dni";
            this.chofdniDataGridViewTextBoxColumn.HeaderText = "chof_dni";
            this.chofdniDataGridViewTextBoxColumn.Name = "chofdniDataGridViewTextBoxColumn";
            // 
            // chofmailDataGridViewTextBoxColumn
            // 
            this.chofmailDataGridViewTextBoxColumn.DataPropertyName = "chof_mail";
            this.chofmailDataGridViewTextBoxColumn.HeaderText = "chof_mail";
            this.chofmailDataGridViewTextBoxColumn.Name = "chofmailDataGridViewTextBoxColumn";
            // 
            // choftelefonoDataGridViewTextBoxColumn
            // 
            this.choftelefonoDataGridViewTextBoxColumn.DataPropertyName = "chof_telefono";
            this.choftelefonoDataGridViewTextBoxColumn.HeaderText = "chof_telefono";
            this.choftelefonoDataGridViewTextBoxColumn.Name = "choftelefonoDataGridViewTextBoxColumn";
            // 
            // chofdireccionDataGridViewTextBoxColumn
            // 
            this.chofdireccionDataGridViewTextBoxColumn.DataPropertyName = "chof_direccion";
            this.chofdireccionDataGridViewTextBoxColumn.HeaderText = "chof_direccion";
            this.chofdireccionDataGridViewTextBoxColumn.Name = "chofdireccionDataGridViewTextBoxColumn";
            // 
            // chofcodigopostalDataGridViewTextBoxColumn
            // 
            this.chofcodigopostalDataGridViewTextBoxColumn.DataPropertyName = "chof_codigo_postal";
            this.chofcodigopostalDataGridViewTextBoxColumn.HeaderText = "chof_codigo_postal";
            this.chofcodigopostalDataGridViewTextBoxColumn.Name = "chofcodigopostalDataGridViewTextBoxColumn";
            // 
            // choffechanacimientoDataGridViewTextBoxColumn
            // 
            this.choffechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "chof_fecha_nacimiento";
            this.choffechanacimientoDataGridViewTextBoxColumn.HeaderText = "chof_fecha_nacimiento";
            this.choffechanacimientoDataGridViewTextBoxColumn.Name = "choffechanacimientoDataGridViewTextBoxColumn";
            // 
            // chofhabilitadoDataGridViewCheckBoxColumn
            // 
            this.chofhabilitadoDataGridViewCheckBoxColumn.DataPropertyName = "chof_habilitado";
            this.chofhabilitadoDataGridViewCheckBoxColumn.HeaderText = "chof_habilitado";
            this.chofhabilitadoDataGridViewCheckBoxColumn.Name = "chofhabilitadoDataGridViewCheckBoxColumn";
            // 
            // chofusuarioDataGridViewTextBoxColumn
            // 
            this.chofusuarioDataGridViewTextBoxColumn.DataPropertyName = "chof_usuario";
            this.chofusuarioDataGridViewTextBoxColumn.HeaderText = "chof_usuario";
            this.chofusuarioDataGridViewTextBoxColumn.Name = "chofusuarioDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 422);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ABM de Choferes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2017DataSet gD1C2017DataSet;
        private System.Windows.Forms.BindingSource choferBindingSource;
        private GD1C2017DataSetTableAdapters.ChoferTableAdapter choferTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofapellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofdniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn choftelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofdireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofcodigopostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn choffechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chofhabilitadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofusuarioDataGridViewTextBoxColumn;
    }
}