using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferresur.controllador
{
    class libroUnicoController
    {
        readonly libroUnico _vista;
        private modelo.liquidacion _liquidacion;

        public libroUnicoController(libroUnico vista)
        {
            _vista = vista;
            _liquidacion = new modelo.liquidacion();

            _vista.lblidLiquidacion.Text = "";
            _vista.lblNombre.Text = "";
            _vista.lblDesde.Text = "";
            _vista.lblHasta.Text = "";
            _vista.lblFechaDePago.Text = "";
            _vista.lblTotal.Text = "";
        }

        public void cargarDatosDeLiquidacion()
        {
            float total = 0;
            _liquidacion.Idliquidacion = (int)_vista.cbLiquidacion.SelectedValue;
            _liquidacion.sellectIDLiquidacion();
            _liquidacion.cargarReciboDeHaberesALaLiquidacion();

            _vista.lblidLiquidacion.Text = _liquidacion.Idliquidacion.ToString();
            _vista.lblNombre.Text = _liquidacion.Nombre;
            _vista.lblDesde.Text = _liquidacion.Desde.ToString("dd/MM/yyyy");
            _vista.lblHasta.Text = _liquidacion.Hasta.ToString("dd/MM/yyyy");
            _vista.lblFechaDePago.Text = _liquidacion.FechaDePago.ToString("dd/MM/yyyy");

            _vista.dgvDatosRecibos.Rows.Clear();
            for (int i =0; i<_liquidacion.Recibos.Count; i++)
            {
                modelo.empleado empleado = new modelo.empleado();
                empleado.IdEmpleado = _liquidacion.Recibos[i].IdEmpleado;
                empleado.selectEmpleado();
                _vista.dgvDatosRecibos.Rows.Add();
                _vista.dgvDatosRecibos[0,i].Value = _liquidacion.Recibos[i].IdReciboDeHaberes;
                _vista.dgvDatosRecibos[1,i].Value = empleado.Apellido+", "+empleado.Nombre;
                _vista.dgvDatosRecibos[2,i].Value = empleado.Cuil;

                foreach (modelo.liquidacion_Asistencia row in _liquidacion.Recibos[i].ListaLiquidacion_Asistencia1)
                {
                    total = total+ row.Cantidad * row.Valor;
                }

                foreach (modelo.reciboConcepto rc in _liquidacion.Recibos[i].ListaReciboConcepto)
                {
                    modelo.concepto concep = new modelo.concepto();
                    concep.Idconcepto = rc.Idconcepto;
                    concep.selectIdConcepto();
                    if (concep.PercepcionSalarial != "Deduccion")
                    {
                        total = total + rc.Importe * rc.Cantidad;
                    }
                }
            }
            _vista.lblTotal.Text =  "$ "+ total.ToString();
        }
    }
}
