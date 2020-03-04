namespace ferresur
{
    partial class generarLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generarLiquidacion));
            this.label1 = new System.Windows.Forms.Label();
            this.cbLiquidacion = new System.Windows.Forms.ComboBox();
            this.liquidacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liquidacion = new ferresur.liquidacion();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.liquidacionTableAdapter = new ferresur.liquidacionTableAdapters.liquidacionTableAdapter();
            this.empleados = new ferresur.empleados();
            this.empleadoscuilnombreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoscuilnombreTableAdapter = new ferresur.empleadosTableAdapters.empleadoscuilnombreTableAdapter();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoscuilnombreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // cbLiquidacion
            // 
            this.cbLiquidacion.DataSource = this.liquidacionBindingSource;
            this.cbLiquidacion.DisplayMember = "nombre";
            this.cbLiquidacion.FormattingEnabled = true;
            this.cbLiquidacion.Location = new System.Drawing.Point(355, 66);
            this.cbLiquidacion.Name = "cbLiquidacion";
            this.cbLiquidacion.Size = new System.Drawing.Size(350, 32);
            this.cbLiquidacion.TabIndex = 1;
            this.cbLiquidacion.ValueMember = "idliquidacion";
            // 
            // liquidacionBindingSource
            // 
            this.liquidacionBindingSource.DataMember = "liquidacion";
            this.liquidacionBindingSource.DataSource = this.liquidacion;
            // 
            // liquidacion
            // 
            this.liquidacion.DataSetName = "liquidacion";
            this.liquidacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AutoGenerateColumns = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.cuilDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.check});
            this.dgvEmpleados.DataSource = this.empleadoscuilnombreBindingSource;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 137);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 72;
            this.dgvEmpleados.RowTemplate.Height = 31;
            this.dgvEmpleados.Size = new System.Drawing.Size(1032, 262);
            this.dgvEmpleados.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(555, 471);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(150, 50);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // liquidacionTableAdapter
            // 
            this.liquidacionTableAdapter.ClearBeforeFill = true;
            // 
            // empleados
            // 
            this.empleados.DataSetName = "empleados";
            this.empleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoscuilnombreBindingSource
            // 
            this.empleadoscuilnombreBindingSource.DataMember = "empleadoscuilnombre";
            this.empleadoscuilnombreBindingSource.DataSource = this.empleados;
            // 
            // empleadoscuilnombreTableAdapter
            // 
            this.empleadoscuilnombreTableAdapter.ClearBeforeFill = true;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "id";
            this.idEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.Width = 50;
            // 
            // cuilDataGridViewTextBoxColumn
            // 
            this.cuilDataGridViewTextBoxColumn.DataPropertyName = "cuil";
            this.cuilDataGridViewTextBoxColumn.HeaderText = "cuil";
            this.cuilDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.cuilDataGridViewTextBoxColumn.Name = "cuilDataGridViewTextBoxColumn";
            this.cuilDataGridViewTextBoxColumn.Width = 80;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 175;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 175;
            // 
            // check
            // 
            this.check.FalseValue = "false";
            this.check.HeaderText = "Seleccionar";
            this.check.IndeterminateValue = "";
            this.check.MinimumWidth = 9;
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.TrueValue = "true";
            this.check.Width = 80;
            // 
            // generarLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 586);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.cbLiquidacion);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "generarLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Liquidacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenerarLiquidacion_FormClosed);
            this.Load += new System.EventHandler(this.GenerarLiquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoscuilnombreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private liquidacion liquidacion;
        private System.Windows.Forms.BindingSource liquidacionBindingSource;
        private liquidacionTableAdapters.liquidacionTableAdapter liquidacionTableAdapter;
        public System.Windows.Forms.DataGridView dgvEmpleados;
        public System.Windows.Forms.ComboBox cbLiquidacion;
        private empleados empleados;
        private System.Windows.Forms.BindingSource empleadoscuilnombreBindingSource;
        private empleadosTableAdapters.empleadoscuilnombreTableAdapter empleadoscuilnombreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}