namespace ferresur
{
    partial class conceptoEditarEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conceptoEditarEliminar));
            this.txtIngreseId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbbPercepcionSalarial = new System.Windows.Forms.ComboBox();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.cbbTipoConcepto = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ferresur2DataSet = new ferresur.ferresur2DataSet();
            this.conceptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conceptoTableAdapter = new ferresur.ferresur2DataSetTableAdapters.conceptoTableAdapter();
            this.idconceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoConceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percepcionSalarialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferresur2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIngreseId
            // 
            this.txtIngreseId.Location = new System.Drawing.Point(410, 22);
            this.txtIngreseId.Name = "txtIngreseId";
            this.txtIngreseId.Size = new System.Drawing.Size(250, 29);
            this.txtIngreseId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese ID:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(682, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 50);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // cbbPercepcionSalarial
            // 
            this.cbbPercepcionSalarial.FormattingEnabled = true;
            this.cbbPercepcionSalarial.Items.AddRange(new object[] {
            "Deduccion",
            "Haber"});
            this.cbbPercepcionSalarial.Location = new System.Drawing.Point(410, 265);
            this.cbbPercepcionSalarial.Name = "cbbPercepcionSalarial";
            this.cbbPercepcionSalarial.Size = new System.Drawing.Size(250, 32);
            this.cbbPercepcionSalarial.TabIndex = 26;
            // 
            // cbbTipo
            // 
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Items.AddRange(new object[] {
            "Porcentual",
            "Fijo"});
            this.cbbTipo.Location = new System.Drawing.Point(410, 174);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(250, 32);
            this.cbbTipo.TabIndex = 25;
            // 
            // cbbTipoConcepto
            // 
            this.cbbTipoConcepto.FormattingEnabled = true;
            this.cbbTipoConcepto.Items.AddRange(new object[] {
            "Percepciones de Ley",
            "Obligaciones de la Empresa",
            "Asignacion Familiar"});
            this.cbbTipoConcepto.Location = new System.Drawing.Point(410, 87);
            this.cbbTipoConcepto.Name = "cbbTipoConcepto";
            this.cbbTipoConcepto.Size = new System.Drawing.Size(250, 32);
            this.cbbTipoConcepto.TabIndex = 24;
            this.cbbTipoConcepto.Tag = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(510, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 50);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "percepcionSalaria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(410, 222);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(250, 29);
            this.txtValor.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "detalle";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(410, 132);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(250, 29);
            this.txtDetalle.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "tipoConcepto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(228, 312);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 50);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idconceptoDataGridViewTextBoxColumn,
            this.tipoConceptoDataGridViewTextBoxColumn,
            this.detalleDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.percepcionSalarialDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.conceptoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 206);
            this.dataGridView1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1019, 11);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // ferresur2DataSet
            // 
            this.ferresur2DataSet.DataSetName = "ferresur2DataSet";
            this.ferresur2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conceptoBindingSource
            // 
            this.conceptoBindingSource.DataMember = "concepto";
            this.conceptoBindingSource.DataSource = this.ferresur2DataSet;
            // 
            // conceptoTableAdapter
            // 
            this.conceptoTableAdapter.ClearBeforeFill = true;
            // 
            // idconceptoDataGridViewTextBoxColumn
            // 
            this.idconceptoDataGridViewTextBoxColumn.DataPropertyName = "idconcepto";
            this.idconceptoDataGridViewTextBoxColumn.HeaderText = "idconcepto";
            this.idconceptoDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.idconceptoDataGridViewTextBoxColumn.Name = "idconceptoDataGridViewTextBoxColumn";
            this.idconceptoDataGridViewTextBoxColumn.Width = 175;
            // 
            // tipoConceptoDataGridViewTextBoxColumn
            // 
            this.tipoConceptoDataGridViewTextBoxColumn.DataPropertyName = "tipoConcepto";
            this.tipoConceptoDataGridViewTextBoxColumn.HeaderText = "tipoConcepto";
            this.tipoConceptoDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.tipoConceptoDataGridViewTextBoxColumn.Name = "tipoConceptoDataGridViewTextBoxColumn";
            this.tipoConceptoDataGridViewTextBoxColumn.Width = 175;
            // 
            // detalleDataGridViewTextBoxColumn
            // 
            this.detalleDataGridViewTextBoxColumn.DataPropertyName = "detalle";
            this.detalleDataGridViewTextBoxColumn.HeaderText = "detalle";
            this.detalleDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.detalleDataGridViewTextBoxColumn.Name = "detalleDataGridViewTextBoxColumn";
            this.detalleDataGridViewTextBoxColumn.Width = 175;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Width = 175;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.Width = 175;
            // 
            // percepcionSalarialDataGridViewTextBoxColumn
            // 
            this.percepcionSalarialDataGridViewTextBoxColumn.DataPropertyName = "percepcionSalarial";
            this.percepcionSalarialDataGridViewTextBoxColumn.HeaderText = "percepcionSalarial";
            this.percepcionSalarialDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.percepcionSalarialDataGridViewTextBoxColumn.Name = "percepcionSalarialDataGridViewTextBoxColumn";
            this.percepcionSalarialDataGridViewTextBoxColumn.Width = 175;
            // 
            // conceptoEditarEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cbbPercepcionSalarial);
            this.Controls.Add(this.cbbTipo);
            this.Controls.Add(this.cbbTipoConcepto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngreseId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "conceptoEditarEliminar";
            this.Text = "Concepto Editar Eliminar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConceptoEditarEliminar_FormClosed);
            this.Load += new System.EventHandler(this.ConceptoEditarEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferresur2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.ComboBox cbbPercepcionSalarial;
        public System.Windows.Forms.ComboBox cbbTipo;
        public System.Windows.Forms.ComboBox cbbTipoConcepto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.TextBox txtIngreseId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ferresur2DataSet ferresur2DataSet;
        private System.Windows.Forms.BindingSource conceptoBindingSource;
        private ferresur2DataSetTableAdapters.conceptoTableAdapter conceptoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idconceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoConceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percepcionSalarialDataGridViewTextBoxColumn;
    }
}