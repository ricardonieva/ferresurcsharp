using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    public class liquidacion
    {
        private int idliquidacion;
        private string nombre;
        private DateTime desde;
        private DateTime hasta;
        private string banco;
        private DateTime fechaDePago;
        private int idTiposDeLiquidacion;
        private List<reciboDeHaberes> recibos = new List<reciboDeHaberes>();

        private tipoLiquidacion tipo_liq;


        public int Idliquidacion { get => idliquidacion; set => idliquidacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Desde { get => desde; set => desde = value; }
        public DateTime Hasta { get => hasta; set => hasta = value; }
        public string Banco { get => banco; set => banco = value; }
        public DateTime FechaDePago { get => fechaDePago; set => fechaDePago = value; }
        internal List<reciboDeHaberes> Recibos { get => recibos; set => recibos = value; }
        public int IdTiposDeLiquidacion { get => idTiposDeLiquidacion; set => idTiposDeLiquidacion = value; }
        internal tipoLiquidacion Tipo_liq { get => tipo_liq; set => tipo_liq = value; }

        public liquidacion()
        {
        }

        public void insertLiquidacion()
        {
            var connect = database.connect();
            string sql = "INSERT INTO liquidacion(nombre, desde, hasta, banco, fechaDePago, TiposDeLiquidacion_idTiposDeLiquidacion) " +
                "VALUES ('"+this.nombre+"', '"+this.desde.ToString("yyyy-mm-dd")+"', '"+this.hasta.ToString("yyyy-mm-dd") + "', '"+this.banco+"', '"+this.fechaDePago.ToString("yyyy-mm-dd") + "', "+this.IdTiposDeLiquidacion+");";
            MySqlCommand command = new MySqlCommand(sql, connect);
            try
            {
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.StackTrace, "Aviso");
            }
            MessageBox.Show(sql);
        }

        public void sellectIDLiquidacion()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM liquidacion WHERE liquidacion.idliquidacion = "+this.idliquidacion;
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.nombre = reader.GetString("nombre");
                        this.desde = reader.GetDateTime("desde"); 
                        this.hasta = reader.GetDateTime("hasta");
                        this.banco = reader.GetString("banco");
                        this.fechaDePago = reader.GetDateTime("fechaDePago");
                        this.IdTiposDeLiquidacion = reader.GetInt32("TiposDeLiquidacion_idTiposDeLiquidacion");
                        tipo_liq = new tipoLiquidacion();
                        tipo_liq.IdTiposDeLiquidacion = reader.GetInt32("TiposDeLiquidacion_idTiposDeLiquidacion");
                        tipo_liq.selectTipoLiquidacion();
                    }
                }
                connect.Close();
                //MessageBox.Show("Se cargo Satisfactoriamente", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.StackTrace);
            }

        }

        public void cargarReciboDeHaberesALaLiquidacion()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM recibodehaberes WHERE recibodehaberes.liquidacion_idliquidacion = " + this.idliquidacion;
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        reciboDeHaberes rec = new reciboDeHaberes();
                        rec.IdReciboDeHaberes = reader.GetInt32("idReciboDeHaberes");
                        rec.IdLiquidacion = reader.GetInt32("liquidacion_idliquidacion");
                        rec.IdEmpleado = reader.GetInt32("empleado_idEmpleado");
                        rec.selectLiqAsistencia();
                        rec.selectReciboConcepto();
                        Recibos.Add(rec);
                    }
                }
                connect.Close();
                //MessageBox.Show("Se cargo Satisfactoriamente", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.StackTrace);
            }
        }
    }
}
