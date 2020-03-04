using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    class liquidacion_Asistencia
    {
        private int idliquidacion_asistencia;
        private string tipo;
        private float cantidad;
        private float valor;
        private int idReciboDeHaberes;

        public int Idliquidacion_asistencia { get => idliquidacion_asistencia; set => idliquidacion_asistencia = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public float Valor { get => valor; set => valor = value; }
        public int IdReciboDeHaberes { get => idReciboDeHaberes; set => idReciboDeHaberes = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }

        public void insertLiquidacionAsistencia()
        {
            var connect = database.connect();
            string sql = "INSERT INTO liquidacion_asistencia(tipo, cantidad, valor, ReciboDeHaberes_idReciboDeHaberes) " +
                "VALUES ('"+this.Tipo+"', @cantidad, @valor, "+this.IdReciboDeHaberes+")";
            //MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connect);
            command.Parameters.AddWithValue("@cantidad", this.Cantidad);
            command.Parameters.AddWithValue("@valor", this.Valor);
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

        
    }
}
