using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    class reciboDeHaberes
    {
        private int idReciboDeHaberes;
        private int idLiquidacion;
        private int idEmpleado;
        private List<liquidacion_Asistencia> ListaLiquidacion_Asistencia = new List<liquidacion_Asistencia>();
        private List<reciboConcepto> listaReciboConcepto = new List<reciboConcepto>();

        empleado _empleado;
        liquidacion _liquidacion;
        float sueldoMensualBruto = 0;

        float totalHaberes = 0;
        float totalDeducciones = 0;

        float totalSueldoMasHaberes = 0;



        public int IdReciboDeHaberes { get => idReciboDeHaberes; set => idReciboDeHaberes = value; }
        public int IdLiquidacion { get => idLiquidacion; set => idLiquidacion = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        internal List<liquidacion_Asistencia> ListaLiquidacion_Asistencia1 { get => ListaLiquidacion_Asistencia; set => ListaLiquidacion_Asistencia = value; }
        internal List<reciboConcepto> ListaReciboConcepto { get => listaReciboConcepto; set => listaReciboConcepto = value; }

        public reciboDeHaberes()
        {
        }

        public reciboDeHaberes(int idEmpleado, int idLiquidacion)
        {
            this._empleado = new empleado();
            this._empleado.IdEmpleado = idEmpleado;
            this._empleado.selectEmpleado();
            this._liquidacion = new liquidacion();
            this._liquidacion.Idliquidacion = idLiquidacion;
            this._liquidacion.sellectIDLiquidacion();
        }

        public void selectLiqAsistencia()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM liquidacion_asistencia WHERE liquidacion_asistencia.ReciboDeHaberes_idReciboDeHaberes =" + this.idReciboDeHaberes;
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        liquidacion_Asistencia la = new liquidacion_Asistencia();
                        la.Idliquidacion_asistencia = reader.GetInt32("idLiquidacion_Asistencia");
                        la.Tipo = reader.GetString("tipo");
                        la.Cantidad = reader.GetFloat("cantidad");
                        la.Valor = reader.GetFloat("valor");
                        la.IdReciboDeHaberes = reader.GetInt32("ReciboDeHaberes_idReciboDeHaberes");

                        ListaLiquidacion_Asistencia.Add(la);
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.StackTrace, "Error");
            }
        }

        public void selectReciboConcepto()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM recibo_concepto WHERE recibo_concepto.ReciboDeHaberes_idReciboDeHaberes = " + this.idReciboDeHaberes;
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        reciboConcepto rc = new reciboConcepto();
                        rc.IdreciboConcepto = reader.GetInt32("idRecibo_concepto");
                        rc.Importe = reader.GetFloat("importe");
                        rc.Cantidad = reader.GetInt32("cantidad");
                        rc.Idconcepto = reader.GetInt32("concepto_idconcepto");
                        rc.Idrecibodehaberes = reader.GetInt32("ReciboDeHaberes_idReciboDeHaberes");
                        listaReciboConcepto.Add(rc);
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.StackTrace, "Error");
            }
        }

        public void selectReciboDeHaberes()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM recibodehaberes WHERE recibodehaberes.idReciboDeHaberes = " + this.idReciboDeHaberes;
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.idLiquidacion = reader.GetInt32("liquidacion_idliquidacion");
                        this.idEmpleado = reader.GetInt32("empleado_idEmpleado");
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.StackTrace, "Error");
            }
        }

        public void insertReciboDeHaberes()
        {
            var connect = database.connect();
            string sql = "INSERT INTO recibodehaberes(liquidacion_idliquidacion, empleado_idEmpleado) " +
                "VALUES ("+this._liquidacion.Idliquidacion+", "+this._empleado.IdEmpleado+")";
            MySqlCommand command = new MySqlCommand(sql, connect);
            try
            {
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.StackTrace, "Error");
            }
        }

        public int ultimoIdReciboDeHaberes()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM ultimoIdDeReciboDeHaberes";
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                int id = 0;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32("idRecibo");
                    }
                }              
                connect.Close();
                return id;              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.StackTrace, "Error");
                return 0;                     
            }
        }


        public void calcularAsistencia(DateTime desde, DateTime hasta)
        {            
            if (this._empleado.Categoria.FormaLaboral == "Mensual")
            {
                calcularAsistenciaMensual(desde, hasta);
            }

        }

        public void calcularAsistenciaMensual(DateTime desde, DateTime hasta)
        {
            var connect = database.connect();
            string sql = "SELECT * FROM calendario, asistencia WHERE asistencia.empleado_idEmpleado = "+this._empleado.IdEmpleado+" AND calendario.idcalendario = asistencia.calendario_idcalendario " +
                "AND calendario.fecha BETWEEN '" + desde.ToString("yyyy-MM-dd") + "' AND '" + hasta.ToString("yyyy-MM-dd") + "'";
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            int diasTrabajadosHabiles = 0;
            int diasTrabajadosFeriados = 0;
            try
            {               
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                   
                    int habil = 0;
                    while (reader.Read())
                    {
                        habil = reader.GetInt32("habil");
                        if (habil == 1)
                        {
                            diasTrabajadosHabiles = diasTrabajadosHabiles + 1;
                        }
                        else
                        {
                            diasTrabajadosFeriados = diasTrabajadosFeriados + 1;
                        }
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.StackTrace, "Error");
                connect.Close();
            }                      

            diasTrabajadosHabiles = diasTrabajadosHabiles / 2;
            calendario calendario = new calendario();
            
            int diasHabiles = calendario.obtenerDiasLaborables(desde, hasta);
            float diasPorcentualTrabajados = (float)diasTrabajadosHabiles / (float)diasHabiles;
            float diasProcentualFeriados = (float)diasTrabajadosFeriados / (float)diasHabiles;

            liquidacion_Asistencia liq_asis = new liquidacion_Asistencia();
            liq_asis.Tipo = "Sueldo Basico";
            liq_asis.Cantidad = diasPorcentualTrabajados;
            liq_asis.Valor = _empleado.Categoria.SueldoBasico;
            liq_asis.IdReciboDeHaberes = ultimoIdReciboDeHaberes();
            liq_asis.insertLiquidacionAsistencia();
            ListaLiquidacion_Asistencia.Add(liq_asis);

            if (diasTrabajadosFeriados > 0)
            {
                liquidacion_Asistencia liq_asis2 = new liquidacion_Asistencia();
                liq_asis2.Tipo = "Dias Feriado";
                liq_asis2.Cantidad = diasProcentualFeriados;
                liq_asis2.Valor = _empleado.Categoria.SueldoBasico;
                liq_asis2.IdReciboDeHaberes = ultimoIdReciboDeHaberes();
                liq_asis2.insertLiquidacionAsistencia();
                ListaLiquidacion_Asistencia.Add(liq_asis2);
            }
            calcularSueldoMensual();
            recorrerLosConceptosHaberAntiguedad();
            recorrerConceptoPresentismo(diasPorcentualTrabajados);
            recorrerLosConceptosDeAsignacionFamiliar();
            recorrerLosConceptoDucciones();
        }

        private void calcularSueldoMensual()
        {
            for (int i = 0; i < ListaLiquidacion_Asistencia.Count; i++)
            {
                MessageBox.Show(ListaLiquidacion_Asistencia[i].Tipo);

                sueldoMensualBruto = sueldoMensualBruto + ((float)ListaLiquidacion_Asistencia[i].Valor * (float)ListaLiquidacion_Asistencia[i].Cantidad);
            }
            MessageBox.Show("Sueldo Mensual Bruto: "+ sueldoMensualBruto.ToString());
        }

        public void recorrerLosConceptosHaberAntiguedad()
        {
            //recorre los conceptos de haber
            for (int i =0; i < _liquidacion.Tipo_liq.ListaConcepto.Count; i++)
            {
                if (_liquidacion.Tipo_liq.ListaConcepto[i].PercepcionSalarial == "Haber" && _liquidacion.Tipo_liq.ListaConcepto[i].Tipoconcepto == "Antiguedad")
                {
                    float haber = 0;
                    if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipo == "Porcentual")
                    {
                        haber = sueldoMensualBruto * _liquidacion.Tipo_liq.ListaConcepto[i].Valor / 100;
                    }
                    else
                    {
                        haber = _liquidacion.Tipo_liq.ListaConcepto[i].Valor;
                    }
                    if (_empleado.obtenerAntiguedad() > 0)
                    {
                        reciboConcepto rc = new reciboConcepto();
                        rc.Importe = haber * _empleado.obtenerAntiguedad();
                        rc.Cantidad = 1;
                        rc.Idconcepto = _liquidacion.Tipo_liq.ListaConcepto[i].Idconcepto;
                        rc.Idrecibodehaberes = ultimoIdReciboDeHaberes();
                        rc.insertReciboConcepto();
                        totalHaberes = totalHaberes + haber;
                    }                   
                }
            }           
        }

        public void recorrerConceptoPresentismo(float asistenciaPorcentual)
        {
            for (int i = 0; i < _liquidacion.Tipo_liq.ListaConcepto.Count; i++)
            {
                if (_liquidacion.Tipo_liq.ListaConcepto[i].PercepcionSalarial == "Haber" && _liquidacion.Tipo_liq.ListaConcepto[i].Tipoconcepto == "Presentismo")
                {
                    if (asistenciaPorcentual == 1)
                    {
                        float haber = 0;
                        if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipo == "Porcentual")
                        {
                            haber = sueldoMensualBruto * _liquidacion.Tipo_liq.ListaConcepto[i].Valor / 100;
                        }
                        else
                        {
                            haber = _liquidacion.Tipo_liq.ListaConcepto[i].Valor;
                        }
                        reciboConcepto rc = new reciboConcepto();
                        rc.Importe = haber;
                        rc.Cantidad = 1;
                        rc.Idconcepto = _liquidacion.Tipo_liq.ListaConcepto[i].Idconcepto;
                        rc.Idrecibodehaberes = ultimoIdReciboDeHaberes();
                        rc.insertReciboConcepto();
                        totalHaberes = totalHaberes + haber;
                    }
                   
                }
            }
        }

        public void recorrerLosConceptosDeAsignacionFamiliar()
        {
            int hijos = 0;
            int discapacitados = 0;
            int estudiosPrimario = 0;
            int estudiosSecundario = 0;
            int estudiosUniversitario = 0;

            for (int i =0; i < _empleado.ListaGrupoFamiliar.Count; i++)
            {
                int edad = _empleado.ListaGrupoFamiliar[i].calcularEdad();
                if (_empleado.ListaGrupoFamiliar[i].Parentesco == "Hijo" && edad < 21)
                { 
                    hijos = hijos + 1;
                    if(_empleado.ListaGrupoFamiliar[i].Discapacidad) {
                        discapacitados = discapacitados + 1;
                    }

                    if (_empleado.ListaGrupoFamiliar[i].Estudio)
                    {
                        if (_empleado.ListaGrupoFamiliar[i].Nivel == "Primario")
                        {
                            estudiosPrimario = estudiosPrimario + 1;
                        }
                        if (_empleado.ListaGrupoFamiliar[i].Nivel == "Secundario")
                        {
                            estudiosSecundario = estudiosSecundario + 1;
                        }
                        if (_empleado.ListaGrupoFamiliar[i].Nivel == "Universidad")
                        {
                            estudiosUniversitario = estudiosUniversitario + 1;
                        }
                    }
                }

            }
            //recorre los conceptos de haber
            for (int i = 0; i < _liquidacion.Tipo_liq.ListaConcepto.Count; i++)
            {
                MessageBox.Show("Entra for a coceptos haber");
                if (_liquidacion.Tipo_liq.ListaConcepto[i].PercepcionSalarial == "Haber")
                {
                    if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipoconcepto == "Hijos")
                    {
                        if (hijos > 0)
                        {
                            float haber = 0;
                            if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipo == "Porcentual")
                            {
                                haber = sueldoMensualBruto * _liquidacion.Tipo_liq.ListaConcepto[i].Valor / 100;
                            }
                            else
                            {
                                haber = _liquidacion.Tipo_liq.ListaConcepto[i].Valor;
                            }
                            reciboConcepto rc = new reciboConcepto();
                            rc.Importe = haber;
                            rc.Cantidad = hijos;
                            rc.Idconcepto = _liquidacion.Tipo_liq.ListaConcepto[i].Idconcepto;
                            rc.Idrecibodehaberes = ultimoIdReciboDeHaberes();
                            rc.insertReciboConcepto();
                            totalHaberes = totalHaberes + haber;
                        }
                    }


                    if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipoconcepto == "Hijos Con Discapacidad")
                    {
                        if (discapacitados > 0)
                        {
                            float haber = 0;
                            if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipo == "Porcentual")
                            {
                                haber = sueldoMensualBruto * _liquidacion.Tipo_liq.ListaConcepto[i].Valor / 100;
                            }
                            else
                            {
                                haber = _liquidacion.Tipo_liq.ListaConcepto[i].Valor;
                            }
                            reciboConcepto rc = new reciboConcepto();
                            rc.Importe = haber;
                            rc.Cantidad = discapacitados;
                            rc.Idconcepto = _liquidacion.Tipo_liq.ListaConcepto[i].Idconcepto;
                            rc.Idrecibodehaberes = ultimoIdReciboDeHaberes();
                            rc.insertReciboConcepto();
                            totalHaberes = totalHaberes + haber;
                        }
                    }


                    if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipoconcepto == "Hijos Estudios Primarios")
                    {
                        if (estudiosPrimario > 0)
                        {
                            float haber = 0;
                            if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipo == "Porcentual")
                            {
                                haber = sueldoMensualBruto * _liquidacion.Tipo_liq.ListaConcepto[i].Valor / 100;
                            }
                            else
                            {
                                haber = _liquidacion.Tipo_liq.ListaConcepto[i].Valor;
                            }
                            reciboConcepto rc = new reciboConcepto();
                            rc.Importe = haber;
                            rc.Cantidad = estudiosPrimario;
                            rc.Idconcepto = _liquidacion.Tipo_liq.ListaConcepto[i].Idconcepto;
                            rc.Idrecibodehaberes = ultimoIdReciboDeHaberes();
                            rc.insertReciboConcepto();
                            totalHaberes = totalHaberes + haber;
                        }
                    }

                    if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipoconcepto == "Hijos Estudios Secundario")
                    {
                        if (estudiosSecundario > 0)
                        {
                            float haber = 0;
                            if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipo == "Porcentual")
                            {
                                haber = sueldoMensualBruto * _liquidacion.Tipo_liq.ListaConcepto[i].Valor / 100;
                            }
                            else
                            {
                                haber = _liquidacion.Tipo_liq.ListaConcepto[i].Valor;
                            }
                            reciboConcepto rc = new reciboConcepto();
                            rc.Importe = haber;
                            rc.Cantidad = estudiosSecundario;
                            rc.Idconcepto = _liquidacion.Tipo_liq.ListaConcepto[i].Idconcepto;
                            rc.Idrecibodehaberes = ultimoIdReciboDeHaberes();
                            rc.insertReciboConcepto();
                            totalHaberes = totalHaberes + haber;
                        }
                    }

                    if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipoconcepto == "Hijos Estudios Universidad")
                    {
                        if (estudiosSecundario > 0)
                        {
                            float haber = 0;
                            if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipo == "Porcentual")
                            {
                                haber = sueldoMensualBruto * _liquidacion.Tipo_liq.ListaConcepto[i].Valor / 100;
                            }
                            else
                            {
                                haber = _liquidacion.Tipo_liq.ListaConcepto[i].Valor;
                            }
                            reciboConcepto rc = new reciboConcepto();
                            rc.Importe = haber;
                            rc.Cantidad = estudiosUniversitario;
                            rc.Idconcepto = _liquidacion.Tipo_liq.ListaConcepto[i].Idconcepto;
                            rc.Idrecibodehaberes = ultimoIdReciboDeHaberes();
                            rc.insertReciboConcepto();
                            totalHaberes = totalHaberes + haber;
                        }
                    }
                }                
            }
            totalSueldoMasHaberes = sueldoMensualBruto + totalHaberes;
            MessageBox.Show("totalsueldomasHaberes: "+totalSueldoMasHaberes.ToString());

        }



        public void recorrerLosConceptoDucciones()
        {
            //recorre los conceptos de deducciones
            for (int i = 0; i < _liquidacion.Tipo_liq.ListaConcepto.Count; i++)
            {
                if (_liquidacion.Tipo_liq.ListaConcepto[i].PercepcionSalarial == "Deduccion" && _liquidacion.Tipo_liq.ListaConcepto[i].Tipoconcepto == "Percepciones de Ley")
                {
                    float deduccion = 0;
                    if (_liquidacion.Tipo_liq.ListaConcepto[i].Tipo == "Porcentual")
                    {
                        deduccion = totalSueldoMasHaberes * _liquidacion.Tipo_liq.ListaConcepto[i].Valor / 100;
                    }
                    else
                    {
                        deduccion = _liquidacion.Tipo_liq.ListaConcepto[i].Valor;
                    }
                    reciboConcepto rc = new reciboConcepto();
                    rc.Importe = deduccion;
                    rc.Cantidad = 1;
                    rc.Idconcepto = _liquidacion.Tipo_liq.ListaConcepto[i].Idconcepto;
                    rc.Idrecibodehaberes = ultimoIdReciboDeHaberes();
                    rc.insertReciboConcepto();
                    totalDeducciones = totalDeducciones + deduccion;
                }
            }
        }



    }
}
