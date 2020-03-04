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
    public partial class libroUnico : Form
    {
        private controllador.libroUnicoController _controlador;
        public libroUnico()
        {
            InitializeComponent();
            _controlador = new controllador.libroUnicoController(this);
        }

        private void LibroUnico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'liquidacion._liquidacion' Puede moverla o quitarla según sea necesario.
            this.liquidacionTableAdapter.Fill(this.liquidacion._liquidacion);

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controlador.cargarDatosDeLiquidacion();
        }

        private void DgvDatosRecibos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDatosRecibos.Columns[e.ColumnIndex].Name == "botonVer")
            {
                int id = Int32.Parse(dgvDatosRecibos[0, e.RowIndex].Value.ToString());
                ReporteReciboDeHaberes repo = new ReporteReciboDeHaberes(id);
                repo.Show();
            }
        }
    }
}
