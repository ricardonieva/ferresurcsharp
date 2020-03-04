using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.controllador
{
    class generarLiquidacionController
    {
        readonly private generarLiquidacion _vista;
        private modelo.liquidacion liq;

        public generarLiquidacionController(generarLiquidacion vista)
        {
            this._vista = vista;
            liq = new modelo.liquidacion();
        }

        public void botonGenerar()
        {
            liq.Idliquidacion = Int32.Parse(_vista.cbLiquidacion.SelectedValue.ToString());
            liq.sellectIDLiquidacion();
            //MessageBox.Show(liq.Desde.ToString("yyyy-MM-dd"));
            //MessageBox.Show(liq.Hasta.ToString("yyyy-MM-dd"));
            
            foreach (DataGridViewRow row in _vista.dgvEmpleados.Rows)
            {
                //Access the CheckBox
                DataGridViewCheckBoxCell cb = row.Cells[4] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cb.Value))
                {
                    modelo.reciboDeHaberes rh = new modelo.reciboDeHaberes(Int32.Parse(row.Cells[0].Value.ToString()), liq.Idliquidacion);
                    rh.insertReciboDeHaberes();
                    rh.calcularAsistencia(liq.Desde, liq.Hasta);
                }
                else
                {
                }

            }
                ///////////////
                //modelo.calendario calendar = new modelo.calendario();
                //DateTime desde = new DateTime(2019, 11, 1);
                //DateTime hasta = new DateTime(2019, 11, 30);

                //calendar.obtenerDiasLaborables(liq.Desde, liq.Hasta);
            }
    }
}
