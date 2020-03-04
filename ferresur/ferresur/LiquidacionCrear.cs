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
    public partial class LiquidacionCrear : Form
    {
        private readonly controllador.LiquidacionCrearController _controlador;
        public LiquidacionCrear()
        {
            InitializeComponent();
            _controlador = new controllador.LiquidacionCrearController(this);
        }

        private void LiquidacionCrear_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiposdeliquidacion._tiposdeliquidacion' Puede moverla o quitarla según sea necesario.
            this.tiposdeliquidacionTableAdapter.Fill(this.tiposdeliquidacion._tiposdeliquidacion);

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            _controlador.botonCrear();
        }
    }
}
