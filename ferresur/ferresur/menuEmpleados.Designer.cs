﻿namespace ferresur
{
    partial class menuEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuEmpleados));
            this.btnNuevoConcepto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoConcepto
            // 
            this.btnNuevoConcepto.Location = new System.Drawing.Point(437, 23);
            this.btnNuevoConcepto.Name = "btnNuevoConcepto";
            this.btnNuevoConcepto.Size = new System.Drawing.Size(250, 50);
            this.btnNuevoConcepto.TabIndex = 0;
            this.btnNuevoConcepto.Text = "Nuevo Concepto";
            this.btnNuevoConcepto.UseVisualStyleBackColor = true;
            this.btnNuevoConcepto.Click += new System.EventHandler(this.BtnNuevoConcepto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Editar o Eliminar Concepto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Nuevo Tipo Liquidacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(437, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Nueva Liquidacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(437, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Generar Liquidacion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(437, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "Nuevo Empleado";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(437, 421);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 50);
            this.button6.TabIndex = 6;
            this.button6.Text = "Calendario";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(437, 477);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(250, 50);
            this.button7.TabIndex = 7;
            this.button7.Text = "Asistencia";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(437, 303);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(250, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "Libro Unico";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // menuEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 586);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevoConcepto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menuEmpleados";
            this.Text = "Menu Empleados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuEmpleados_FormClosed);
            this.Load += new System.EventHandler(this.MenuEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoConcepto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}