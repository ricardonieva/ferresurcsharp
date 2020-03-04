namespace ferresur
{
    partial class LiquidacionCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiquidacionCrear));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tiposdeliquidacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposdeliquidacion = new ferresur.tiposdeliquidacion();
            this.dtpFechaDePago = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.tiposdeliquidacionTableAdapter = new ferresur.tiposdeliquidacionTableAdapters.tiposdeliquidacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tiposdeliquidacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposdeliquidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Periodo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(372, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(422, 29);
            this.txtNombre.TabIndex = 2;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(372, 166);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 29);
            this.dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(594, 166);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 29);
            this.dtpHasta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Banco";
            // 
            // cbBanco
            // 
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Items.AddRange(new object[] {
            "Macro",
            "Santander",
            "Nacion",
            "HSBC",
            "BBVA",
            "Patagonia"});
            this.cbBanco.Location = new System.Drawing.Point(372, 218);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(422, 32);
            this.cbBanco.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de Pago";
            // 
            // cbTipo
            // 
            this.cbTipo.DataSource = this.tiposdeliquidacionBindingSource;
            this.cbTipo.DisplayMember = "Nombre";
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(372, 325);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(422, 32);
            this.cbTipo.TabIndex = 10;
            this.cbTipo.ValueMember = "idTiposDeLiquidacion";
            // 
            // tiposdeliquidacionBindingSource
            // 
            this.tiposdeliquidacionBindingSource.DataMember = "tiposdeliquidacion";
            this.tiposdeliquidacionBindingSource.DataSource = this.tiposdeliquidacion;
            // 
            // tiposdeliquidacion
            // 
            this.tiposdeliquidacion.DataSetName = "tiposdeliquidacion";
            this.tiposdeliquidacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFechaDePago
            // 
            this.dtpFechaDePago.CustomFormat = "dd/mm/yyyy";
            this.dtpFechaDePago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDePago.Location = new System.Drawing.Point(372, 273);
            this.dtpFechaDePago.Name = "dtpFechaDePago";
            this.dtpFechaDePago.Size = new System.Drawing.Size(200, 29);
            this.dtpFechaDePago.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(418, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Crear Liquidacion";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(644, 379);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(150, 50);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // tiposdeliquidacionTableAdapter
            // 
            this.tiposdeliquidacionTableAdapter.ClearBeforeFill = true;
            // 
            // LiquidacionCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 586);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaDePago);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LiquidacionCrear";
            this.Text = "Crear Liquidacion";
            this.Load += new System.EventHandler(this.LiquidacionCrear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiposdeliquidacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposdeliquidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCrear;
        private tiposdeliquidacion tiposdeliquidacion;
        private System.Windows.Forms.BindingSource tiposdeliquidacionBindingSource;
        private tiposdeliquidacionTableAdapters.tiposdeliquidacionTableAdapter tiposdeliquidacionTableAdapter;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.DateTimePicker dtpDesde;
        public System.Windows.Forms.DateTimePicker dtpHasta;
        public System.Windows.Forms.ComboBox cbBanco;
        public System.Windows.Forms.ComboBox cbTipo;
        public System.Windows.Forms.DateTimePicker dtpFechaDePago;
    }
}