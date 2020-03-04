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
    public partial class tipoLiquidacion : Form
    {
        List<modelo.concepto> listaConceptos = new List<modelo.concepto>();
        public tipoLiquidacion()
        {
            InitializeComponent();
        }

        private void TipoLiquidacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'conceptos.concepto' Puede moverla o quitarla según sea necesario.
            this.conceptoTableAdapter.Fill(this.conceptos.concepto);


            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Eliminar";
            btn.UseColumnTextForButtonValue = true;
            dgvConceptos.Columns.Add(btn);

        }

        private void TipoLiquidacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            controllador.controladorMenus.menuEmpleado();
            this.Hide();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            modelo.concepto concep = new modelo.concepto();
            concep.Idconcepto = Int32.Parse(cbConcepto.SelectedValue.ToString());
            concep.Detalle = cbConcepto.Text;
            listaConceptos.Add(concep);
            cargarDGV();
        }

        public void cargarDGV()
        {
            dgvConceptos.Rows.Clear();
            for (int i = 0; i < listaConceptos.Count; i++)
            {
                dgvConceptos.Rows.Add();
                dgvConceptos[0, i].Value = listaConceptos[i].Idconcepto;
                dgvConceptos[1, i].Value = listaConceptos[i].Detalle;
                
                //MessageBox.Show("Evento: " + lista[i].Fecha + " - Hora: " + lista[i].Apellido);
            }
        }

        private void DgvConceptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvConceptos.Columns[e.ColumnIndex].Name == "")
            {
                listaConceptos.RemoveAt(e.RowIndex);
                cargarDGV();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            controllador.tipoLiquidacionController.botonGuardar(this, listaConceptos);
        }
    }
}
