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
    public partial class conceptoEditarEliminar : Form
    {
        public conceptoEditarEliminar()
        {
            InitializeComponent();
        }

        private void ConceptoEditarEliminar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferresur2DataSet.concepto' Puede moverla o quitarla según sea necesario.
            this.conceptoTableAdapter.Fill(this.ferresur2DataSet.concepto);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            controllador.controlladorConcepto.selectConceptoEditarEliminar(this);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            controllador.controlladorConcepto.updateConceptoEditarEliminar(this);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            controllador.controlladorConcepto.deleteConceptoEditarEliminar(this);
        }

        private void ConceptoEditarEliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            controllador.controladorMenus.menuEmpleado();
            this.Hide();
        }
    }
}
