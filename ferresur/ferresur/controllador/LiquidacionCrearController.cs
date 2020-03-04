using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.controllador
{    
    class LiquidacionCrearController
    {
        private readonly LiquidacionCrear _vista;
        private modelo.liquidacion liq;

        public LiquidacionCrearController(LiquidacionCrear vista)
        {
            _vista = vista;
        }

        public void botonCrear()
        {
            liq = new modelo.liquidacion();
            liq.Nombre = _vista.txtNombre.Text;
            liq.Desde = DateTime.ParseExact(_vista.dtpDesde.Text, "d/m/yyyy", CultureInfo.InvariantCulture);
            liq.Hasta = DateTime.ParseExact(_vista.dtpHasta.Text, "d/m/yyyy", CultureInfo.InvariantCulture);
            liq.Banco = _vista.cbBanco.SelectedItem.ToString();
            liq.FechaDePago = DateTime.ParseExact(_vista.dtpFechaDePago.Text, "d/m/yyyy", CultureInfo.InvariantCulture);
            liq.IdTiposDeLiquidacion = Int32.Parse(_vista.cbTipo.SelectedValue.ToString());
            liq.insertLiquidacion();

            //MessageBox.Show("Select value: "+ _vista.cbTipo.SelectedValue.ToString());

        }


    }
}
