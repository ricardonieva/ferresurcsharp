using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    class calendario
    {
        private int idcalendario;
        private DateTime fecha;
        private bool habil;

        public int Idcalendario { get => idcalendario; set => idcalendario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public bool Habil { get => habil; set => habil = value; }
        
        public void insertCalendario()
        {
            int esHabil = 0;
            if (this.habil)
            {
                esHabil = 1;
            }
            else
            {
                esHabil = 0;
            }
            var connect = database.connect();
            string sql = "INSERT INTO calendario(fecha, habil) VALUES ('"+this.fecha.ToString("yyyy-mm-dd") + "', "+esHabil+")";
            MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connect);
            try
            {
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar calendario" + ex.StackTrace, "Aviso");
            }
        }
        public void selectCalendario()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM calendario WHERE calendario.idcalendario = " + this.idcalendario;
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.fecha = reader.GetDateTime("fecha");
                        this.habil = reader.GetBoolean("habil");
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar calendario" + ex.StackTrace, "Aviso");
            }
        }

        public int obtenerDiasLaborables(DateTime desde, DateTime hasta)
        {
            var connect = database.connect();
            string sql = "SELECT COUNT(*) AS dias FROM calendario WHERE calendario.fecha BETWEEN '"+desde.ToString("yyyy-MM-dd")+"' AND '"+hasta.ToString("yyyy-MM-dd") + "' AND calendario.habil = 1";
            //MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                int dias = 0;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {
                        dias = reader.GetInt32("dias");
                    }
                    //MessageBox.Show("Los dias laborables son: "+dias.ToString());
                }
                connect.Close();
                return dias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar calendario" + ex.StackTrace, "Aviso");
                return 0;

            }
        }
    }
}
