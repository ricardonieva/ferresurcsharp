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
    public partial class ReporteReciboDeHaberes : Form
    {
        controllador.reporteReciboController _controlador;
        modelo.reciboDeHaberes _recibo;
        modelo.liquidacion _liquidacion;
        public ReporteReciboDeHaberes(int idRecibo)
        {
            InitializeComponent();
            _controlador = new controllador.reporteReciboController(this);
            _recibo = new modelo.reciboDeHaberes();
            _recibo.IdReciboDeHaberes = idRecibo;
            _recibo.selectReciboDeHaberes();
            _recibo.selectLiqAsistencia();
            _recibo.selectReciboConcepto();

            _liquidacion = new modelo.liquidacion();
            _liquidacion.Idliquidacion = _recibo.IdLiquidacion;
            _liquidacion.sellectIDLiquidacion();

            lblNumeroDeRecibo.Text = _recibo.IdReciboDeHaberes.ToString();
            lblTipoDeRecibo.Text = "Original";

            modelo.empleado em = new modelo.empleado();
            em.IdEmpleado = _recibo.IdEmpleado;
            em.selectEmpleado();

            lblNombre.Text = em.Nombre;
            lblApellido.Text = em.Apellido;
            lblCuil.Text = em.Cuil;

            lblCategoria.Text = em.Categoria.Tipo1;
            lblSueldoBasico.Text = em.Categoria.SueldoBasico.ToString();
            lblFechaDeIngreso.Text = em.Fechaingreso.ToString("dd/MM/yyy");


            lblFechaDeCobro.Text = _liquidacion.FechaDePago.ToString("dd/MM/yyy");
            lblTipo.Text = em.Categoria.FormaLaboral;
            lblPeriodo.Text = _liquidacion.Desde.ToString("MM-yyy");

            int indice = 0;
            float totalHaberes = 0;
            for (int i =0; i<_recibo.ListaLiquidacion_Asistencia1.Count; i++)
            {
                dgvConceptos.Rows.Add();
                dgvConceptos[0, i].Value = _recibo.ListaLiquidacion_Asistencia1[i].Idliquidacion_asistencia;
                dgvConceptos[1, i].Value = _recibo.ListaLiquidacion_Asistencia1[i].Tipo;
                dgvConceptos[2, i].Value = _recibo.ListaLiquidacion_Asistencia1[i].Valor * _recibo.ListaLiquidacion_Asistencia1[i].Cantidad;

                indice = indice + 1;
                totalHaberes = totalHaberes + _recibo.ListaLiquidacion_Asistencia1[i].Valor * _recibo.ListaLiquidacion_Asistencia1[i].Cantidad;
            }

            float totalDeducciones = 0;
            modelo.concepto concep = new modelo.concepto();
            for (int j = 0; j<_recibo.ListaReciboConcepto.Count; j++)
            {
                concep.Idconcepto = _recibo.ListaReciboConcepto[j].Idconcepto;
                concep.selectIdConcepto();

                dgvConceptos.Rows.Add();
                dgvConceptos[0, j + indice].Value = concep.Idconcepto;
                dgvConceptos[1, j + indice].Value = concep.Detalle;
                if (concep.PercepcionSalarial == "Haber")
                {                   
                    dgvConceptos[2, j + indice].Value = _recibo.ListaReciboConcepto[j].Importe * _recibo.ListaReciboConcepto[j].Cantidad;
                    totalHaberes = totalHaberes + _recibo.ListaReciboConcepto[j].Importe * _recibo.ListaReciboConcepto[j].Cantidad;
                }
                else
                {
                    dgvConceptos[3, j + indice].Value = _recibo.ListaReciboConcepto[j].Importe * _recibo.ListaReciboConcepto[j].Cantidad;
                    totalDeducciones = totalDeducciones + _recibo.ListaReciboConcepto[j].Importe * _recibo.ListaReciboConcepto[j].Cantidad;
                }
            }

            float totalTotal = totalHaberes - totalDeducciones;

            lblTotalHaberes.Text = totalHaberes.ToString();
            lblTotalDeducciones.Text = totalDeducciones.ToString();
            lblTotalNeto.Text = totalTotal.ToString();
            lblLugarYFecha.Text = "Aguilares-Tucuman "+DateTime.Now.ToString("dd/MM/yyyy");


        }
    }
}
