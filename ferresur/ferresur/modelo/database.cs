using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    abstract class database
    {
        public static MySqlConnection connect()
        {
            try
            {
                MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password =; database = ferresur2; ");
                databaseConnection.Open();
                return databaseConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en conexion: "+ex.StackTrace);
                return null;
            }

        }
    }
}
