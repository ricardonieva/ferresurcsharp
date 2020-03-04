using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ferresur.modelo
{
    public class concepto
    {
        private int idconcepto;
        private string tipoconcepto;
        private string detalle;
        private string tipo;
        private float valor;
        private string percepcionSalarial;

        public concepto()
        {
        }

        public int Idconcepto { get => idconcepto; set => idconcepto = value; }
        public string Tipoconcepto { get => tipoconcepto; set => tipoconcepto = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public float Valor { get => valor; set => valor = value; }
        public string PercepcionSalarial { get => percepcionSalarial; set => percepcionSalarial = value; }

        public void insertConcepto()
        {
            var connect = database.connect();
            string sql = "INSERT INTO concepto(tipoConcepto, detalle, tipo, valor, percepcionSalarial) " +
            "VALUES ('"+this.tipoconcepto+"', '"+this.detalle+"', '"+this.tipo+"', '"+this.valor+"', '"+this.percepcionSalarial+"')";

            MySqlCommand command = new MySqlCommand(sql, connect);
            try
            {
                command.ExecuteNonQuery();
                //MessageBox.Show("Concepto generado satisfactoriamente", "Aviso");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Concepto"+ex.Message, "Aviso");
            }

        }

        public void selectIdConcepto()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM concepto WHERE concepto.idconcepto = "+this.Idconcepto;
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.idconcepto = reader.GetInt32("idconcepto");
                        this.tipoconcepto = reader.GetString("tipoConcepto");
                        this.detalle = reader.GetString("detalle");
                        this.tipo = reader.GetString("tipo");
                        this.valor = reader.GetFloat("valor");
                        this.percepcionSalarial = reader.GetString("percepcionSalarial");
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Concepto" + ex.StackTrace, "Aviso");
                connect.Close();
            }
        }


        public void updateConcepto()
        {
            var connect = database.connect();
            string sql = "UPDATE concepto SET tipoConcepto= '"+this.tipoconcepto+"',detalle= '"+this.detalle+"',tipo= '"+this.tipo+"',valor= "+this.valor+",percepcionSalarial= '"+this.percepcionSalarial+"' WHERE idconcepto= "+this.idconcepto;
            //MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connect);
            try
            {
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Concepto" + ex.StackTrace, "Aviso");
                connect.Close();
            }
        }

        public void deleteConcepto()
        {
            var connect = database.connect();
            string sql = "DELETE FROM concepto WHERE idconcepto ="+this.idconcepto;
            MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connect);
            try
            {
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Concepto" + ex.StackTrace, "Aviso");
                connect.Close();
            }
        }
    }
}
