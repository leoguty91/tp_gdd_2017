namespace UberFrba.Abm_Cliente
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
            this.buttonAltaCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieapellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliedniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clietelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliedireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecodigopostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliefechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliehabilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clieusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2017DataSet = new UberFrba.GD1C2017DataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new UberFrba.GD1C2017DataSetTableAdapters.ClienteTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAltaCliente);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(248, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 265);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Clientes";
            // 
            // buttonAltaCliente
            // 
            this.buttonAltaCliente.Location = new System.Drawing.Point(22, 222);
            this.buttonAltaCliente.Name = "buttonAltaCliente";
            this.buttonAltaCliente.Size = new System.Drawing.Size(355, 27);
            this.buttonAltaCliente.TabIndex = 7;
            this.buttonAltaCliente.Text = "Nuevo Cliente";
            this.buttonAltaCliente.UseVisualStyleBackColor = true;
            this.buttonAltaCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clieidDataGridViewTextBoxColumn,
            this.clienombreDataGridViewTextBoxColumn,
            this.clieapellidoDataGridViewTextBoxColumn,
            this.cliedniDataGridViewTextBoxColumn,
            this.cliemailDataGridViewTextBoxColumn,
            this.clietelefonoDataGridViewTextBoxColumn,
            this.cliedireccionDataGridViewTextBoxColumn,
            this.cliecodigopostalDataGridViewTextBoxColumn,
            this.cliefechanacimientoDataGridViewTextBoxColumn,
            this.cliehabilitadoDataGridViewCheckBoxColumn,
            this.clieusuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(355, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clieidDataGridViewTextBoxColumn
            // 
            this.clieidDataGridViewTextBoxColumn.DataPropertyName = "clie_id";
            this.clieidDataGridViewTextBoxColumn.HeaderText = "clie_id";
            this.clieidDataGridViewTextBoxColumn.Name = "clieidDataGridViewTextBoxColumn";
            this.clieidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clieidDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienombreDataGridViewTextBoxColumn
            // 
            this.clienombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clienombreDataGridViewTextBoxColumn.DataPropertyName = "clie_nombre";
            this.clienombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.clienombreDataGridViewTextBoxColumn.Name = "clienombreDataGridViewTextBoxColumn";
            this.clienombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clieapellidoDataGridViewTextBoxColumn
            // 
            this.clieapellidoDataGridViewTextBoxColumn.DataPropertyName = "clie_apellido";
            this.clieapellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.clieapellidoDataGridViewTextBoxColumn.Name = "clieapellidoDataGridViewTextBoxColumn";
            this.clieapellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliedniDataGridViewTextBoxColumn
            // 
            this.cliedniDataGridViewTextBoxColumn.DataPropertyName = "clie_dni";
            this.cliedniDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.cliedniDataGridViewTextBoxColumn.Name = "cliedniDataGridViewTextBoxColumn";
            this.cliedniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliemailDataGridViewTextBoxColumn
            // 
            this.cliemailDataGridViewTextBoxColumn.DataPropertyName = "clie_mail";
            this.cliemailDataGridViewTextBoxColumn.HeaderText = "clie_mail";
            this.cliemailDataGridViewTextBoxColumn.Name = "cliemailDataGridViewTextBoxColumn";
            this.cliemailDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliemailDataGridViewTextBoxColumn.Visible = false;
            // 
            // clietelefonoDataGridViewTextBoxColumn
            // 
            this.clietelefonoDataGridViewTextBoxColumn.DataPropertyName = "clie_telefono";
            this.clietelefonoDataGridViewTextBoxColumn.HeaderText = "clie_telefono";
            this.clietelefonoDataGridViewTextBoxColumn.Name = "clietelefonoDataGridViewTextBoxColumn";
            this.clietelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.clietelefonoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cliedireccionDataGridViewTextBoxColumn
            // 
            this.cliedireccionDataGridViewTextBoxColumn.DataPropertyName = "clie_direccion";
            this.cliedireccionDataGridViewTextBoxColumn.HeaderText = "clie_direccion";
            this.cliedireccionDataGridViewTextBoxColumn.Name = "cliedireccionDataGridViewTextBoxColumn";
            this.cliedireccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliedireccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // cliecodigopostalDataGridViewTextBoxColumn
            // 
            this.cliecodigopostalDataGridViewTextBoxColumn.DataPropertyName = "clie_codigo_postal";
            this.cliecodigopostalDataGridViewTextBoxColumn.HeaderText = "clie_codigo_postal";
            this.cliecodigopostalDataGridViewTextBoxColumn.Name = "cliecodigopostalDataGridViewTextBoxColumn";
            this.cliecodigopostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliecodigopostalDataGridViewTextBoxColumn.Visible = false;
            // 
            // cliefechanacimientoDataGridViewTextBoxColumn
            // 
            this.cliefechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "clie_fecha_nacimiento";
            this.cliefechanacimientoDataGridViewTextBoxColumn.HeaderText = "clie_fecha_nacimiento";
            this.cliefechanacimientoDataGridViewTextBoxColumn.Name = "cliefechanacimientoDataGridViewTextBoxColumn";
            this.cliefechanacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliefechanacimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cliehabilitadoDataGridViewCheckBoxColumn
            // 
            this.cliehabilitadoDataGridViewCheckBoxColumn.DataPropertyName = "clie_habilitado";
            this.cliehabilitadoDataGridViewCheckBoxColumn.HeaderText = "clie_habilitado";
            this.cliehabilitadoDataGridViewCheckBoxColumn.Name = "cliehabilitadoDataGridViewCheckBoxColumn";
            this.cliehabilitadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.cliehabilitadoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // clieusuarioDataGridViewTextBoxColumn
            // 
            this.clieusuarioDataGridViewTextBoxColumn.DataPropertyName = "clie_usuario";
            this.clieusuarioDataGridViewTextBoxColumn.HeaderText = "clie_usuario";
            this.clieusuarioDataGridViewTextBoxColumn.Name = "clieusuarioDataGridViewTextBoxColumn";
            this.clieusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.clieusuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.gD1C2017DataSet;
            // 
            // gD1C2017DataSet
            // 
            this.gD1C2017DataSet.DataSetName = "GD1C2017DataSet";
            this.gD1C2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxDNI);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxApellido);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(19, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 265);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(22, 166);
            this.textBoxDNI.MaxLength = 255;
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(159, 26);
            this.textBoxDNI.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(23, 104);
            this.textBoxApellido.MaxLength = 255;
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(159, 26);
            this.textBoxApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(22, 49);
            this.textBoxNombre.MaxLength = 255;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(159, 26);
            this.textBoxNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(685, 340);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ABM de Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2017DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAltaCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2017DataSet gD1C2017DataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private GD1C2017DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieapellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliedniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clietelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliedireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecodigopostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliefechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cliehabilitadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieusuarioDataGridViewTextBoxColumn;
    }
}