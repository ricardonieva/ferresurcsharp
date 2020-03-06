using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.modelo
{
    class Articulo
    {
        private Rubro rubro = new Rubro();
        private int idArticulo;
        private String nombre;
        private String descripcion;
        private float precioVenta;
        private float costoUnitario;
        private Boolean estado;
        private int stock;
        private int stockMinimo;
        

        public int IdArticulo { get => idArticulo; set => idArticulo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public float CostoUnitario { get => costoUnitario; set => costoUnitario = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int Stock { get => stock; set => stock = value; }
        public int StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        internal Rubro Rubro { get => rubro; set => rubro = value; }

        public void InsertarArticulo() {

            var connect = database.connect();
            String sql = "INSERT INTO `articulo`(`nombre`, `descripcion`, `precioVenta`, `costoUnitario`, `estado`, `stock`, `stockminimo`, `idRubro`)" +
                " VALUES ('"+this.nombre+"','"+this.descripcion+ "','"+this.precioVenta+ "','"+this.costoUnitario+ "','"+this.estado+ "','"+this.stock+ "','"+this.stockMinimo+ "','"+this.rubro.IdRubro+"')";
            MySqlCommand command = new MySqlCommand(sql, connect);

            try {
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Articulo registrado satisfactoriamente");
            }
            catch (Exception e) {
                MessageBox.Show("Error al hacer alta de articulo " + e.StackTrace);
            }
        }
    }
}
