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
    public partial class generarLiquidacion : Form
    {
        controllador.generarLiquidacionController _controlador;
        public generarLiquidacion()
        {
            InitializeComponent();
            _controlador = new controllador.generarLiquidacionController(this);
        }

        private void GenerarLiquidacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empleados.empleadoscuilnombre' Puede moverla o quitarla según sea necesario.
            this.empleadoscuilnombreTableAdapter.Fill(this.empleados.empleadoscuilnombre);

            // TODO: esta línea de código carga datos en la tabla 'liquidacion._liquidacion' Puede moverla o quitarla según sea necesario.
            this.liquidacionTableAdapter.Fill(this.liquidacion._liquidacion);           
        }

        private void GenerarLiquidacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            controllador.controladorMenus.menuEmpleado();
            this.Hide();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            _controlador.botonGenerar();
        }
    }
}
