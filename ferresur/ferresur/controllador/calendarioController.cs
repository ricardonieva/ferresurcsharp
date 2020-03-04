using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferresur.controllador
{
    class CalendarioController
    {
        readonly calendario _vista;
        private modelo.calendario _calendario;

        public CalendarioController(calendario vista)
        {
            _vista = vista;
            _calendario = new modelo.calendario();
        }

        public void botonGuardar()
        {
            _calendario.Fecha = DateTime.ParseExact(_vista.dtpFecha.Text, "d/m/yyyy", CultureInfo.InvariantCulture);
            _calendario.Habil = _vista.cbHabil.Checked;
            _calendario.insertCalendario();
        }
    }
}
