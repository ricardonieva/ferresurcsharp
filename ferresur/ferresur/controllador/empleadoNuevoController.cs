using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur.controllador
{
    class empleadoNuevoController
    {
        readonly empleadoAlta _vista;
        private modelo.empleado _empleado;
        public empleadoNuevoController(empleadoAlta vista)
        {
            this._vista = vista;
            this._empleado = new modelo.empleado();
        }

        public void botonGuardar()
        {
            _empleado.Nombre = _vista.txtNombre.Text;
            _empleado.Apellido = _vista.txtApellido.Text;
            _empleado.Cuil = _vista.txtCuil.Text;
            _empleado.Fechanac = DateTime.ParseExact(_vista.dtpFechaNac.Text, "d/m/yyyy", CultureInfo.InvariantCulture);
            _empleado.Fechaingreso = DateTime.ParseExact(_vista.dtpFechaIngreso.Text, "d/m/yyyy", CultureInfo.InvariantCulture);
            _empleado.Telefono = Double.Parse(_vista.txtTelefono.Text);
            _empleado.CuentaBancaria = _vista.txtCtaBancaria.Text;
            _empleado.IdCategoria = Int32.Parse(_vista.cbCategoria.SelectedValue.ToString());
            _empleado.insertEmpleado();
        }
    }
}
