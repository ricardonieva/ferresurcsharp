using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferresur.controllador
{
    class ArticuloAltaController
    {
        readonly NuevoArticulo _vista;

        public ArticuloAltaController(NuevoArticulo vista)
        {
            _vista = vista;
        }

        public void CargarArticulo() {
            modelo.Articulo art = new modelo.Articulo();
            art.Nombre = _vista.txtNombreArticulo.Text;
            art.Descripcion = _vista.txtNombreArticulo.Text;
            art.PrecioVenta =float.Parse(_vista.txtPrecioVentaArticulo.Text);
            art.CostoUnitario = float.Parse(_vista.txtCostoUnitarioArticulo.Text);
            art.Estado =_vista.cbEstadoArticulo.Checked;
            art.Stock = Int32.Parse(_vista.txtStockArticulo.Text);
            art.StockMinimo = Int32.Parse(_vista.txtStockMinimoArticulo.Text);
            art.Rubro.IdRubro = Int32.Parse(_vista.cboRubroArticulo.SelectedValue.ToString());
            art.InsertarArticulo();
                
         }
    }
}
