using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferresur
{
    public partial class calendario : Form
    {
        private controllador.CalendarioController _controller;
        public calendario()
        {
            InitializeComponent();
            _controller = new controllador.CalendarioController(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _controller.botonGuardar();
        }
    }
}
