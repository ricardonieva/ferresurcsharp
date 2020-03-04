namespace ferresur
{
    partial class ConceptoInsert
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConceptoInsert));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbbTipoConcepto = new System.Windows.Forms.ComboBox();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.cbbPercepcionSalarial = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nuevo Concepto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "tipoConcepto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "detalle";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(490, 123);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(200, 29);
            this.txtDetalle.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(490, 213);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 29);
            this.txtValor.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "percepcionSalaria";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(490, 295);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 50);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // cbbTipoConcepto
            // 
            this.cbbTipoConcepto.FormattingEnabled = true;
            this.cbbTipoConcepto.Items.AddRange(new object[] {
            "Percepciones de Ley",
            "Obligaciones de la Empresa",
            "Asignacion Familiar"});
            this.cbbTipoConcepto.Location = new System.Drawing.Point(490, 78);
            this.cbbTipoConcepto.Name = "cbbTipoConcepto";
            this.cbbTipoConcepto.Size = new System.Drawing.Size(200, 32);
            this.cbbTipoConcepto.TabIndex = 13;
            // 
            // cbbTipo
            // 
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Items.AddRange(new object[] {
            "Porcentual",
            "Fijo"});
            this.cbbTipo.Location = new System.Drawing.Point(490, 172);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(200, 32);
            this.cbbTipo.TabIndex = 14;
            // 
            // cbbPercepcionSalarial
            // 
            this.cbbPercepcionSalarial.FormattingEnabled = true;
            this.cbbPercepcionSalarial.Items.AddRange(new object[] {
            "Deduccion",
            "Haber"});
            this.cbbPercepcionSalarial.Location = new System.Drawing.Point(490, 256);
            this.cbbPercepcionSalarial.Name = "cbbPercepcionSalarial";
            this.cbbPercepcionSalarial.Size = new System.Drawing.Size(200, 32);
            this.cbbPercepcionSalarial.TabIndex = 15;
            // 
            // ConceptoInsert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1056, 586);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConceptoInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conceptos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConceptoInsert_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtDetalle;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.ComboBox cbbTipoConcepto;
        public System.Windows.Forms.ComboBox cbbTipo;
        public System.Windows.Forms.ComboBox cbbPercepcionSalarial;
    }
}

