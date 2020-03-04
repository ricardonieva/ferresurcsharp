using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.controllador
{
    class tipoLiquidacionController
    {
        public static void botonGuardar(tipoLiquidacion _vista, List<modelo.concepto> listaConceptos)
        {
            modelo.tipoLiquidacion tl = new modelo.tipoLiquidacion();
            tl.Nombre1 = _vista.txtNombre.Text;
            tl.ListaConcepto = listaConceptos;
            tl.insertTipoLiquidacion();
        }
    }
}
