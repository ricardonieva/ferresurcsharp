using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    class reciboConcepto
    {
        private int idreciboConcepto;
        private float importe;
        private int cantidad;
        private int idconcepto;
        private int idrecibodehaberes;

        public int IdreciboConcepto { get => idreciboConcepto; set => idreciboConcepto = value; }
        public float Importe { get => importe; set => importe = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Idconcepto { get => idconcepto; set => idconcepto = value; }
        public int Idrecibodehaberes { get => idrecibodehaberes; set => idrecibodehaberes = value; }

        public void insertReciboConcepto()
        {
            var connect = database.connect();
            string sql = "INSERT INTO recibo_concepto(importe, cantidad, concepto_idconcepto, ReciboDeHaberes_idReciboDeHaberes) " +
                "VALUES (@importe, "+this.cantidad+", "+this.idconcepto+", "+this.idrecibodehaberes+")";
            MySqlCommand command = new MySqlCommand(sql, connect);
            command.Parameters.AddWithValue("@importe", this.importe);
            MessageBox.Show(command.CommandText);
            try
            {
                command.ExecuteNonQuery();
                command.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.StackTrace, "Error");
            }
        }
    }
}
