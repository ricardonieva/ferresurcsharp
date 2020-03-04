using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    class asistencia
    {
        private int idasistencia;
        private DateTime entrada;
        private DateTime salida;
        private string novedades;
        private int horasExt;
        private int idEmpleado;
        private int idCalendario;

        public int Idasistencia { get => idasistencia; set => idasistencia = value; }
        public DateTime Entrada { get => entrada; set => entrada = value; }
        public DateTime Salida { get => salida; set => salida = value; }
        public string Novedades { get => novedades; set => novedades = value; }
        public int HorasExt { get => horasExt; set => horasExt = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int IdCalendario { get => idCalendario; set => idCalendario = value; }

        public void selectAsisntecia()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM asistencia WHERE asistencia.idasistencia = " + this.idasistencia;
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.entrada = reader.GetDateTime("entrada");
                        this.salida = reader.GetDateTime("salida");
                        this.novedades = reader.GetString("novedades");
                        this.horasExt = reader.GetInt32("horasExt");
                        this.idEmpleado = reader.GetInt32("empleado_idEmpleado");
                        this.idCalendario = reader.GetInt32("calendario_idcalendario");

                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asistencia" + ex.StackTrace, "Aviso");
            }
        }
    }
}
