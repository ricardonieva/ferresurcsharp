using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    class grupoFamiliar
    {
        private int idgrupofamiliar;
        private string apellido;
        private string nombre;
        private int dni;
        private string parentesco;
        private DateTime fechanacimiento;
        private bool discapacidad;
        private bool estudio;
        private string nivel;
        private int idEmpleado;

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public bool Discapacidad { get => discapacidad; set => discapacidad = value; }
        public bool Estudio { get => estudio; set => estudio = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int Idgrupofamiliar { get => idgrupofamiliar; set => idgrupofamiliar = value; }

        public void selectGrupoFamiliar()
        {
            var connect = database.connect();
            string sql = "SELECT * FROM grupofamiliar WHERE grupofamiliar.idgrupofamiliar = "+this.idgrupofamiliar;
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
                        this.dni = reader.GetInt32("dni");
                        this.parentesco = reader.GetString("parentesco");
                        this.fechanacimiento = reader.GetDateTime("fechanacimiento");
                        this.idEmpleado = reader.GetInt32("empleado_idEmpleado");
                        this.discapacidad = reader.GetBoolean("discapacidad");
                        this.estudio = reader.GetBoolean("estudio");
                        this.nivel = reader.GetString("nivel");                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Empleado: " + ex.StackTrace);
            }
        }

        public int calcularEdad()
        {
            int edad = DateTime.Today.Year - this.fechanacimiento.Year;
            if (DateTime.Today < this.fechanacimiento.AddYears(edad))
                return --edad;
            else
                return edad;
        }
    }
}
