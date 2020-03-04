namespace ferresur
{
    partial class tipoLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tipoLiquidacion));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvConceptos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.conceptos = new ferresur.Conceptos();
            this.conceptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conceptoTableAdapter = new ferresur.ConceptosTableAdapters.conceptoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Tipo de Liquidacion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(437, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 29);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "concepto";
            // 
            // cbConcepto
            // 
            this.cbConcepto.DataSource = this.conceptoBindingSource;
            this.cbConcepto.DisplayMember = "detalle";
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Location = new System.Drawing.Point(437, 110);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(250, 32);
            this.cbConcepto.TabIndex = 4;
            this.cbConcepto.ValueMember = "idconcepto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(537, 157);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 50);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dgvConceptos
            // 
            this.dgvConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvConceptos.Location = new System.Drawing.Point(211, 227);
            this.dgvConceptos.Name = "dgvConceptos";
            this.dgvConceptos.RowHeadersWidth = 72;
            this.dgvConceptos.RowTemplate.Height = 31;
            this.dgvConceptos.Size = new System.Drawing.Size(713, 291);
            this.dgvConceptos.TabIndex = 6;
            this.dgvConceptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConceptos_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "codigo";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "concepto";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // conceptos
            // 
            this.conceptos.DataSetName = "Conceptos";
            this.conceptos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conceptoBindingSource
            // 
            this.conceptoBindingSource.DataMember = "concepto";
            this.conceptoBindingSource.DataSource = this.conceptos;
            // 
            // conceptoTableAdapter
            // 
            this.conceptoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvConceptos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbConcepto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tipoLiquidacion";
            this.Text = "Tipo Liquidacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TipoLiquidacion_FormClosed);
            this.Load += new System.EventHandler(this.TipoLiquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.ComboBox cbConcepto;
        public System.Windows.Forms.DataGridView dgvConceptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Conceptos conceptos;
        private System.Windows.Forms.BindingSource conceptoBindingSource;
        private ConceptosTableAdapters.conceptoTableAdapter conceptoTableAdapter;
    }
}