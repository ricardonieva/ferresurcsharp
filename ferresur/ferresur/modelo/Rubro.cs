using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferresur.modelo
{
    class Rubro
    {
        private int idRubro;
        private String nombre;
        private String descripcion;

        public int IdRubro { get => idRubro; set => idRubro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }


}
