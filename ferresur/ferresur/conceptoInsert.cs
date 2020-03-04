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
    public partial class ConceptoInsert : Form
    {
        public ConceptoInsert()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            controllador.controlladorConcepto.insertConcepto(this);
        }

        private void ConceptoInsert_FormClosed(object sender, FormClosedEventArgs e)
        {
            controllador.controladorMenus.menuEmpleado();
            this.Hide();
        }
    }
}
