using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    public class tipoLiquidacion
    {
        private int idTiposDeLiquidacion;
        private string Nombre;
        private List<concepto> listaConcepto = new List<concepto>();
        private List<liquidacion> listaLiquidacion = new List<liquidacion>();

        public int IdTiposDeLiquidacion { get => idTiposDeLiquidacion; set => idTiposDeLiquidacion = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        internal List<concepto> ListaConcepto { get => listaConcepto; set => listaConcepto = value; }
        internal List<liquidacion> ListaLiquidacion { get => listaLiquidacion; set => listaLiquidacion = value; }

        public void insertTipoLiquidacion()
        {
            var connect = database.connect();
            string sql = "INSERT INTO tiposdeliquidacion(Nombre) VALUES ('"+this.Nombre+"')";
            MySqlCommand command = new MySqlCommand(sql, connect);
            try
            {
                command.ExecuteNonQuery();
                for (int i = 0; i < listaConcepto.Count; i++)
                {
                    sql = "INSERT INTO tiposdeliquidacion_concepto(TiposDeLiquidacion_idTiposDeLiquidacion, concepto_idconcepto) VALUES (ultimoidTipoLiquidacion(), "+this.listaConcepto[i].Idconcepto+")";
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                }
                connect.Close();
                MessageBox.Show("Se cargo Satisfactoriamente", "Aviso");
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Error"+ex.StackTrace);
            }
            
        }

        public void selectTipoLiquidacion()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM tiposdeliquidacion, tiposdeliquidacion_concepto WHERE tiposdeliquidacion.idTiposDeLiquidacion = "+this.idTiposDeLiquidacion+" AND tiposdeliquidacion.idTiposDeLiquidacion = tiposdeliquidacion_concepto.TiposDeLiquidacion_idTiposDeLiquidacion";
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.Nombre = reader.GetString("Nombre");
                        concepto concep = new concepto();
                        concep.Idconcepto = reader.GetInt32("concepto_idconcepto");
                        concep.selectIdConcepto();
                        listaConcepto.Add(concep);
                    }
                }               
                connect.Close();
                //MessageBox.Show("Se cargo Satisfactoriamente", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.StackTrace);
                connect.Close();
            }

        }

    }
}
