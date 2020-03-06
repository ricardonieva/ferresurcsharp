namespace ferresur
{
    partial class NuevoArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoArticulo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.txtCostoUnitarioArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaArticulo = new System.Windows.Forms.TextBox();
            this.txtStockArticulo = new System.Windows.Forms.TextBox();
            this.cbEstadoArticulo = new System.Windows.Forms.CheckBox();
            this.txtStockMinimoArticulo = new System.Windows.Forms.TextBox();
            this.cboRubroArticulo = new System.Windows.Forms.ComboBox();
            this.ferresur2DataSet = new ferresur.ferresur2DataSet();
            this.ferresur2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ferresur2DataSet1 = new ferresur.ferresur2DataSet1();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubroTableAdapter = new ferresur.ferresur2DataSet1TableAdapters.rubroTableAdapter();
            this.btnCargarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ferresur2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferresur2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferresur2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Costo Unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Precio de Venta :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rubro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock Minimo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Estado:";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(122, 19);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreArticulo.TabIndex = 8;
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(122, 45);
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionArticulo.TabIndex = 9;
            // 
            // txtCostoUnitarioArticulo
            // 
            this.txtCostoUnitarioArticulo.Location = new System.Drawing.Point(122, 97);
            this.txtCostoUnitarioArticulo.Name = "txtCostoUnitarioArticulo";
            this.txtCostoUnitarioArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtCostoUnitarioArticulo.TabIndex = 11;
            // 
            // txtPrecioVentaArticulo
            // 
            this.txtPrecioVentaArticulo.Location = new System.Drawing.Point(122, 71);
            this.txtPrecioVentaArticulo.Name = "txtPrecioVentaArticulo";
            this.txtPrecioVentaArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVentaArticulo.TabIndex = 10;
            this.txtPrecioVentaArticulo.TextChanged += new System.EventHandler(this.txtPrecioVentaArticulo_TextChanged);
            // 
            // txtStockArticulo
            // 
            this.txtStockArticulo.Location = new System.Drawing.Point(122, 158);
            this.txtStockArticulo.Name = "txtStockArticulo";
            this.txtStockArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtStockArticulo.TabIndex = 13;
            // 
            // cbEstadoArticulo
            // 
            this.cbEstadoArticulo.AutoSize = true;
            this.cbEstadoArticulo.Location = new System.Drawing.Point(122, 135);
            this.cbEstadoArticulo.Name = "cbEstadoArticulo";
            this.cbEstadoArticulo.Size = new System.Drawing.Size(80, 17);
            this.cbEstadoArticulo.TabIndex = 14;
            this.cbEstadoArticulo.Text = "checkBox1";
            this.cbEstadoArticulo.UseVisualStyleBackColor = true;
            // 
            // txtStockMinimoArticulo
            // 
            this.txtStockMinimoArticulo.Location = new System.Drawing.Point(122, 188);
            this.txtStockMinimoArticulo.Name = "txtStockMinimoArticulo";
            this.txtStockMinimoArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtStockMinimoArticulo.TabIndex = 15;
            // 
            // cboRubroArticulo
            // 
            this.cboRubroArticulo.DataSource = this.rubroBindingSource;
            this.cboRubroArticulo.DisplayMember = "nombre";
            this.cboRubroArticulo.FormattingEnabled = true;
            this.cboRubroArticulo.Location = new System.Drawing.Point(122, 218);
            this.cboRubroArticulo.Name = "cboRubroArticulo";
            this.cboRubroArticulo.Size = new System.Drawing.Size(121, 21);
            this.cboRubroArticulo.TabIndex = 16;
            this.cboRubroArticulo.ValueMember = "idrubro";
            // 
            // ferresur2DataSet
            // 
            this.ferresur2DataSet.DataSetName = "ferresur2DataSet";
            this.ferresur2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ferresur2DataSetBindingSource
            // 
            this.ferresur2DataSetBindingSource.DataSource = this.ferresur2DataSet;
            this.ferresur2DataSetBindingSource.Position = 0;
            // 
            // ferresur2DataSet1
            // 
            this.ferresur2DataSet1.DataSetName = "ferresur2DataSet1";
            this.ferresur2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "rubro";
            this.rubroBindingSource.DataSource = this.ferresur2DataSet1;
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
            // 
            // btnCargarArticulo
            // 
            this.btnCargarArticulo.Location = new System.Drawing.Point(127, 269);
            this.btnCargarArticulo.Name = "btnCargarArticulo";
            this.btnCargarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnCargarArticulo.TabIndex = 17;
            this.btnCargarArticulo.Text = "Cargar";
            this.btnCargarArticulo.UseVisualStyleBackColor = true;
            this.btnCargarArticulo.Click += new System.EventHandler(this.btnCargarArticulo_Click);
            // 
            // NuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.btnCargarArticulo);
            this.Controls.Add(this.cboRubroArticulo);
            this.Controls.Add(this.txtStockMinimoArticulo);
            this.Controls.Add(this.cbEstadoArticulo);
            this.Controls.Add(this.txtStockArticulo);
            this.Controls.Add(this.txtCostoUnitarioArticulo);
            this.Controls.Add(this.txtPrecioVentaArticulo);
            this.Controls.Add(this.txtDescripcionArticulo);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoArticulo";
            this.Text = "NuevoArticulo";
            this.Load += new System.EventHandler(this.NuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ferresur2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferresur2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferresur2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
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
        private ferresur2DataSet ferresur2DataSet;
        private System.Windows.Forms.BindingSource ferresur2DataSetBindingSource;
        private ferresur2DataSet1 ferresur2DataSet1;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private ferresur2DataSet1TableAdapters.rubroTableAdapter rubroTableAdapter;
        private System.Windows.Forms.Button btnCargarArticulo;
        public System.Windows.Forms.TextBox txtNombreArticulo;
        public System.Windows.Forms.TextBox txtDescripcionArticulo;
        public System.Windows.Forms.TextBox txtCostoUnitarioArticulo;
        public System.Windows.Forms.TextBox txtPrecioVentaArticulo;
        public System.Windows.Forms.TextBox txtStockArticulo;
        public System.Windows.Forms.CheckBox cbEstadoArticulo;
        public System.Windows.Forms.TextBox txtStockMinimoArticulo;
        public System.Windows.Forms.ComboBox cboRubroArticulo;
    }
}