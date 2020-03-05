namespace ferresur
{
    partial class libroUnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libroUnico));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLiquidacion = new System.Windows.Forms.ComboBox();
            this.liquidacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.liquidacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liquidacion = new ferresur.liquidacion();
            this.liquidacionTableAdapter = new ferresur.liquidacionTableAdapters.liquidacionTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFechaDePago = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblidLiquidacion = new System.Windows.Forms.Label();
            this.dgvDatosRecibos = new System.Windows.Forms.DataGridView();
            this.idRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoyNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libro Unico de Liquidacion de Haberes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionar Liquidacion";
            // 
            // cbLiquidacion
            // 
            this.cbLiquidacion.DataSource = this.liquidacionBindingSource1;
            this.cbLiquidacion.DisplayMember = "nombre";
            this.cbLiquidacion.FormattingEnabled = true;
            this.cbLiquidacion.Location = new System.Drawing.Point(297, 58);
            this.cbLiquidacion.Name = "cbLiquidacion";
            this.cbLiquidacion.Size = new System.Drawing.Size(463, 32);
            this.cbLiquidacion.TabIndex = 2;
            this.cbLiquidacion.ValueMember = "idliquidacion";
            this.cbLiquidacion.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // liquidacionBindingSource1
            // 
            this.liquidacionBindingSource1.DataMember = "liquidacion";
            this.liquidacionBindingSource1.DataSource = this.liquidacionBindingSource;
            // 
            // liquidacionBindingSource
            // 
            this.liquidacionBindingSource.DataSource = this.liquidacion;
            this.liquidacionBindingSource.Position = 0;
            // 
            // liquidacion
            // 
            this.liquidacion.DataSetName = "liquidacion";
            this.liquidacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // liquidacionTableAdapter
            // 
            this.liquidacionTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "idLiquidacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Desde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(699, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(899, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha de Pago";
            // 
            // lblFechaDePago
            // 
            this.lblFechaDePago.AutoSize = true;
            this.lblFechaDePago.Location = new System.Drawing.Point(899, 158);
            this.lblFechaDePago.Name = "lblFechaDePago";
            this.lblFechaDePago.Size = new System.Drawing.Size(145, 25);
            this.lblFechaDePago.TabIndex = 12;
            this.lblFechaDePago.Text = "Fecha de Pago";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(699, 158);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(63, 25);
            this.lblHasta.TabIndex = 11;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(480, 158);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(69, 25);
            this.lblDesde.TabIndex = 10;
            this.lblDesde.Text = "Desde";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(249, 158);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblidLiquidacion
            // 
            this.lblidLiquidacion.AutoSize = true;
            this.lblidLiquidacion.Location = new System.Drawing.Point(12, 158);
            this.lblidLiquidacion.Name = "lblidLiquidacion";
            this.lblidLiquidacion.Size = new System.Drawing.Size(126, 25);
            this.lblidLiquidacion.TabIndex = 8;
            this.lblidLiquidacion.Text = "idLiquidacion";
            // 
            // dgvDatosRecibos
            // 
            this.dgvDatosRecibos.AllowUserToAddRows = false;
            this.dgvDatosRecibos.AllowUserToDeleteRows = false;
            this.dgvDatosRecibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosRecibos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatosRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRecibo,
            this.ApellidoyNombre,
            this.cuil,
            this.botonVer});
            this.dgvDatosRecibos.Location = new System.Drawing.Point(13, 206);
            this.dgvDatosRecibos.Name = "dgvDatosRecibos";
            this.dgvDatosRecibos.ReadOnly = true;
            this.dgvDatosRecibos.RowHeadersVisible = false;
            this.dgvDatosRecibos.RowHeadersWidth = 72;
            this.dgvDatosRecibos.RowTemplate.Height = 31;
            this.dgvDatosRecibos.Size = new System.Drawing.Size(1031, 343);
            this.dgvDatosRecibos.TabIndex = 13;
            this.dgvDatosRecibos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatosRecibos_CellClick);
            // 
            // idRecibo
            // 
            this.idRecibo.HeaderText = "idRecibo";
            this.idRecibo.MinimumWidth = 9;
            this.idRecibo.Name = "idRecibo";
            this.idRecibo.ReadOnly = true;
            this.idRecibo.Width = 128;
            // 
            // ApellidoyNombre
            // 
            this.ApellidoyNombre.HeaderText = "Apellido y Nombre";
            this.ApellidoyNombre.MinimumWidth = 9;
            this.ApellidoyNombre.Name = "ApellidoyNombre";
            this.ApellidoyNombre.ReadOnly = true;
            this.ApellidoyNombre.Width = 194;
            // 
            // cuil
            // 
            this.cuil.HeaderText = "cuil";
            this.cuil.MinimumWidth = 9;
            this.cuil.Name = "cuil";
            this.cuil.ReadOnly = true;
            this.cuil.Width = 82;
            // 
            // botonVer
            // 
            this.botonVer.HeaderText = "Recibos";
            this.botonVer.MinimumWidth = 9;
            this.botonVer.Name = "botonVer";
            this.botonVer.ReadOnly = true;
            this.botonVer.Text = "Ver";
            this.botonVer.UseColumnTextForButtonValue = true;
            this.botonVer.Width = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Pagado:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(153, 552);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 25);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "lblTotal";
            // 
            // libroUnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 586);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvDatosRecibos);
            this.Controls.Add(this.lblFechaDePago);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblidLiquidacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLiquidacion);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "libroUnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libro Unico";
            this.Load += new System.EventHandler(this.LibroUnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource liquidacionBindingSource;
        private liquidacion liquidacion;
        private System.Windows.Forms.BindingSource liquidacionBindingSource1;
        private liquidacionTableAdapters.liquidacionTableAdapter liquidacionTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbLiquidacion;
        public System.Windows.Forms.Label lblFechaDePago;
        public System.Windows.Forms.Label lblHasta;
        public System.Windows.Forms.Label lblDesde;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblidLiquidacion;
        public System.Windows.Forms.DataGridView dgvDatosRecibos;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoyNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil;
        private System.Windows.Forms.DataGridViewButtonColumn botonVer;
    }
}