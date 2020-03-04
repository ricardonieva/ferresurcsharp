using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    class empleado
    {
        private int idEmpleado;
        private string nombre;
        private string apellido;
        private string cuil;
        private DateTime fechanac;
        private DateTime fechaingreso;
        private double telefono;
        private string cuentaBancaria;
        private int idCategoria;
        private categoria categoria;
        private List<grupoFamiliar> listaGrupoFamiliar = new List<grupoFamiliar>();

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cuil { get => cuil; set => cuil = value; }
        public DateTime Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
        public double Telefono { get => telefono; set => telefono = value; }
        public string CuentaBancaria { get => cuentaBancaria; set => cuentaBancaria = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public DateTime Fechanac { get => fechanac; set => fechanac = value; }
        internal categoria Categoria { get => categoria; set => categoria = value; }
        internal List<grupoFamiliar> ListaGrupoFamiliar { get => listaGrupoFamiliar; set => listaGrupoFamiliar = value; }

        public void selectEmpleado()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM empleadogrupofamiliar WHERE idEmpleado = " + this.idEmpleado;
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
                        this.apellido = reader.GetString("apellido");
                        this.cuil = reader.GetString("cuil");
                        this.fechanac = reader.GetDateTime("fechanac");
                        this.fechaingreso = reader.GetDateTime("fechaingreso");
                        this.telefono = reader.GetDouble("telefono");
                        this.cuentaBancaria = reader.GetString("cuentaBancaria");
                        this.categoria = new categoria();
                        this.categoria.IdCategoria = reader.GetInt32("Categoria_idCategoria");
                        this.categoria.selectCategoria();                      
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Empleado: "+ex.StackTrace);
            }
            selelectGrupoFamiliar();
        }

        public void selelectGrupoFamiliar()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM grupofamiliar WHERE grupofamiliar.empleado_idEmpleado =" + this.idEmpleado;
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {       
                        grupoFamiliar gf = new grupoFamiliar();
                        gf.Idgrupofamiliar = reader.GetInt32("idgrupofamiliar");
                        gf.selectGrupoFamiliar();
                        ListaGrupoFamiliar.Add(gf);
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Empleado: " + ex.StackTrace);
            }
        }

        public int obtenerAntiguedad()
        {
            var connect = database.connect();
            string sql = "SELECT TIMESTAMPDIFF(YEAR, @fechaingreso, NOW()) AS años_transcurridos";
            MySqlCommand command = new MySqlCommand(sql, connect);
            command.Parameters.AddWithValue("@fechaingreso", this.fechaingreso);
            MySqlDataReader reader;
            try
            {
                int años = 0;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       años = reader.GetInt32("años_transcurridos");
                    }
                }
                connect.Close();
                return años;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Empleado: " + ex.StackTrace);
                return 0;
            }
        }

        public void insertEmpleado()
        {
            var connect = database.connect();
            string sql = "INSERT INTO empleado (nombre, apellido, cuil, fechanac, fechaingreso, telefono, cuentaBancaria, Categoria_idCategoria) " +
            "VALUES ('"+this.nombre+"', '"+this.apellido+"', "+this.cuil+", '"+this.fechanac.ToString("yyyy-mm-dd") + "', '"+this.fechaingreso.ToString("yyyy-mm-dd") + "', "+this.telefono+", '"+this.cuentaBancaria+"', "+this.idCategoria+")";
            MessageBox.Show(sql);
            MySqlCommand command = new MySqlCommand(sql, connect);
            try
            {
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Empleado registrador satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Empleado: " + ex.StackTrace);
            }
        }
    }
}
