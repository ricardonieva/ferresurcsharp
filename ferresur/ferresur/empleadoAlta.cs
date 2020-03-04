using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur
{
    public partial class empleadoAlta : Form
    {
        private controllador.empleadoNuevoController _controller;
        public empleadoAlta()
        {
            InitializeComponent();
            this._controller = new controllador.empleadoNuevoController(this);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            _controller.botonGuardar();
        }

        private void EmpleadoAlta_FormClosed(object sender, FormClosedEventArgs e)
        {
            controllador.controladorMenus.menuEmpleado();
            this.Hide();
        }

        private void EmpleadoAlta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'categoria._categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.categoria._categoria);

        }
    }
}
