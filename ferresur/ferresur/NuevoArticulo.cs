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
    public partial class NuevoArticulo : Form
    {
        private controllador.ArticuloAltaController _articuloAltaController;

        public NuevoArticulo()
        {
            InitializeComponent();
            _articuloAltaController = new controllador.ArticuloAltaController(this);
        }

        private void txtPrecioVentaArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferresur2DataSet1.rubro' Puede moverla o quitarla según sea necesario.
            this.rubroTableAdapter.Fill(this.ferresur2DataSet1.rubro);

        }

        private void btnCargarArticulo_Click(object sender, EventArgs e)
        {
            _articuloAltaController.CargarArticulo();
        }
    }
}
