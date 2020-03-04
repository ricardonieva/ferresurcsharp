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
    public partial class menuEmpleados : Form
    {
        public menuEmpleados()
        {
            InitializeComponent();
        }

        private void BtnNuevoConcepto_Click(object sender, EventArgs e)
        {
            ConceptoInsert coninsert = new ConceptoInsert();
            coninsert.Show();
            this.Hide();
        }

        private void MenuEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            controllador.controladorMenus.menuPrincipal();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            conceptoEditarEliminar cee = new conceptoEditarEliminar();
            cee.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tipoLiquidacion tl = new tipoLiquidacion();
            tl.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LiquidacionCrear lc = new LiquidacionCrear();
            lc.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            generarLiquidacion gl = new generarLiquidacion();
            gl.Show();
            this.Hide();
        }

        private void MenuEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            empleadoAlta ea = new empleadoAlta();
            ea.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            calendario calendar = new calendario();
            calendar.Show();
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            libroUnico lu = new libroUnico();
            lu.Show();
            this.Hide();
        }
    }
}
