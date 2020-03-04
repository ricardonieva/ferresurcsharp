using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    class categoria
    {
        private int idCategoria;
        private string Tipo;
        private float sueldoBasico;
        private string formaLaboral;
        private List<empleado> listaEmpleado;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public float SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public string FormaLaboral { get => formaLaboral; set => formaLaboral = value; }
        internal List<empleado> ListaEmpleado { get => listaEmpleado; set => listaEmpleado = value; }

        public void insertCategoria()
        {
            var connect = database.connect();
            string sql = "INSERT INTO categoria(Tipo, sueldoBasico, formaLaboral) " +
                "VALUES ('"+this.Tipo+"', "+this.sueldoBasico+", '"+this.formaLaboral+"')";
            MySqlCommand command = new MySqlCommand(sql, connect);
            try
            {
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar concepto"+ex.StackTrace, "Aviso");
            }
        }

        public void selectCategoria()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM categoria WHERE categoria.idCategoria = "+this.idCategoria;
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.Tipo = reader.GetString("Tipo");
                        this.sueldoBasico = reader.GetFloat("sueldoBasico");
                        this.formaLaboral = reader.GetString("formaLaboral");
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar concepto" + ex.StackTrace, "Aviso");
            }
        }

    }
}
