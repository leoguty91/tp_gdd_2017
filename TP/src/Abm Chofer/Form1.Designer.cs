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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAltaChofer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.choferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2017DataSet = new UberFrba.GD1C2017DataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.choferTableAdapter = new UberFrba.GD1C2017DataSetTableAdapters.ChoferTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 248);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chofer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAltaChofer);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(197, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(464, 206);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Choferes";
            // 
            // buttonAltaChofer
            // 
            this.buttonAltaChofer.Location = new System.Drawing.Point(146, 162);
            this.buttonAltaChofer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAltaChofer.Name = "buttonAltaChofer";
            this.buttonAltaChofer.Size = new System.Drawing.Size(150, 21);
            this.buttonAltaChofer.TabIndex = 7;
            this.buttonAltaChofer.Text = "Nuevo Chofer";
            this.buttonAltaChofer.UseVisualStyleBackColor = true;
            this.buttonAltaChofer.Click += new System.EventHandler(this.buttonAltaChofer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(18, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(396, 114);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // chofidDataGridViewTextBoxColumn
            // 
            this.chofidDataGridViewTextBoxColumn.DataPropertyName = "chof_id";
            this.chofidDataGridViewTextBoxColumn.HeaderText = "chof_id";
            this.chofidDataGridViewTextBoxColumn.Name = "chofidDataGridViewTextBoxColumn";
            this.chofidDataGridViewTextBoxColumn.ReadOnly = true;
            this.chofidDataGridViewTextBoxColumn.Visible = false;
            // 
            // chofnombreDataGridViewTextBoxColumn
            // 
            this.chofnombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chofnombreDataGridViewTextBoxColumn.DataPropertyName = "chof_nombre";
            this.chofnombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.chofnombreDataGridViewTextBoxColumn.Name = "chofnombreDataGridViewTextBoxColumn";
            this.chofnombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chofapellidoDataGridViewTextBoxColumn
            // 
            this.chofapellidoDataGridViewTextBoxColumn.DataPropertyName = "chof_apellido";
            this.chofapellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.chofapellidoDataGridViewTextBoxColumn.Name = "chofapellidoDataGridViewTextBoxColumn";
            this.chofapellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chofdniDataGridViewTextBoxColumn
            // 
            this.chofdniDataGridViewTextBoxColumn.DataPropertyName = "chof_dni";
            this.chofdniDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.chofdniDataGridViewTextBoxColumn.Name = "chofdniDataGridViewTextBoxColumn";
            this.chofdniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chofmailDataGridViewTextBoxColumn
            // 
            this.chofmailDataGridViewTextBoxColumn.DataPropertyName = "chof_mail";
            this.chofmailDataGridViewTextBoxColumn.HeaderText = "chof_mail";
            this.chofmailDataGridViewTextBoxColumn.Name = "chofmailDataGridViewTextBoxColumn";
            this.chofmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.chofmailDataGridViewTextBoxColumn.Visible = false;
            // 
            // choftelefonoDataGridViewTextBoxColumn
            // 
            this.choftelefonoDataGridViewTextBoxColumn.DataPropertyName = "chof_telefono";
            this.choftelefonoDataGridViewTextBoxColumn.HeaderText = "chof_telefono";
            this.choftelefonoDataGridViewTextBoxColumn.Name = "choftelefonoDataGridViewTextBoxColumn";
            this.choftelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.choftelefonoDataGridViewTextBoxColumn.Visible = false;
            // 
            // chofdireccionDataGridViewTextBoxColumn
            // 
            this.chofdireccionDataGridViewTextBoxColumn.DataPropertyName = "chof_direccion";
            this.chofdireccionDataGridViewTextBoxColumn.HeaderText = "chof_direccion";
            this.chofdireccionDataGridViewTextBoxColumn.Name = "chofdireccionDataGridViewTextBoxColumn";
            this.chofdireccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.chofdireccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // chofcodigopostalDataGridViewTextBoxColumn
            // 
            this.chofcodigopostalDataGridViewTextBoxColumn.DataPropertyName = "chof_codigo_postal";
            this.chofcodigopostalDataGridViewTextBoxColumn.HeaderText = "chof_codigo_postal";
            this.chofcodigopostalDataGridViewTextBoxColumn.Name = "chofcodigopostalDataGridViewTextBoxColumn";
            this.chofcodigopostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.chofcodigopostalDataGridViewTextBoxColumn.Visible = false;
            // 
            // choffechanacimientoDataGridViewTextBoxColumn
            // 
            this.choffechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "chof_fecha_nacimiento";
            this.choffechanacimientoDataGridViewTextBoxColumn.HeaderText = "chof_fecha_nacimiento";
            this.choffechanacimientoDataGridViewTextBoxColumn.Name = "choffechanacimientoDataGridViewTextBoxColumn";
            this.choffechanacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.choffechanacimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // chofhabilitadoDataGridViewCheckBoxColumn
            // 
            this.chofhabilitadoDataGridViewCheckBoxColumn.DataPropertyName = "chof_habilitado";
            this.chofhabilitadoDataGridViewCheckBoxColumn.HeaderText = "chof_habilitado";
            this.chofhabilitadoDataGridViewCheckBoxColumn.Name = "chofhabilitadoDataGridViewCheckBoxColumn";
            this.chofhabilitadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.chofhabilitadoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // chofusuarioDataGridViewTextBoxColumn
            // 
            this.chofusuarioDataGridViewTextBoxColumn.DataPropertyName = "chof_usuario";
            this.chofusuarioDataGridViewTextBoxColumn.HeaderText = "chof_usuario";
            this.chofusuarioDataGridViewTextBoxColumn.Name = "chofusuarioDataGridViewTextBoxColumn";
            this.chofusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.chofusuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // choferBindingSource
            // 
            this.choferBindingSource.DataMember = "Chofer";
            this.choferBindingSource.DataSource = this.gD1C2017DataSet;
            // 
            // gD1C2017DataSet
            // 
            this.gD1C2017DataSet.DataSetName = "GD1C2017DataSet";
            this.gD1C2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFiltrar);
            this.groupBox2.Controls.Add(this.textBoxDNI);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxApellido);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(161, 206);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrado";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(25, 162);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(111, 21);
            this.buttonFiltrar.TabIndex = 6;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(24, 129);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDNI.MaxLength = 255;
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(113, 20);
            this.textBoxDNI.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(24, 85);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxApellido.MaxLength = 255;
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(113, 20);
            this.textBoxApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(24, 40);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombre.MaxLength = 255;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(113, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // choferTableAdapter
            // 
            this.choferTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ABM de Choferes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private GD1C2017DataSet gD1C2017DataSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource choferBindingSource;
        private GD1C2017DataSetTableAdapters.ChoferTableAdapter choferTableAdapter;
        private System.Windows.Forms.Button buttonAltaChofer;
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