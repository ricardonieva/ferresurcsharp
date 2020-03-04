using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferresur.controllador
{
    class controlladorConcepto
    {
        static modelo.concepto concep;
        public static void insertConcepto(ConceptoInsert _vista)
        {
            modelo.concepto concep = new modelo.concepto();
            concep.Tipoconcepto = _vista.cbbTipoConcepto.Text;
            concep.Detalle = _vista.txtDetalle.Text;
            concep.Tipo = _vista.cbbTipo.Text;
            concep.Valor = float.Parse(_vista.txtValor.Text);
            concep.PercepcionSalarial = _vista.cbbPercepcionSalarial.Text;
            concep.insertConcepto();
        }

        public static void selectConceptoEditarEliminar(conceptoEditarEliminar _vista)
        {
            concep = new modelo.concepto();
            concep.Idconcepto = Int32.Parse(_vista.txtIngreseId.Text);
            concep.selectIdConcepto();

            _vista.cbbTipoConcepto.SelectedItem = concep.Tipoconcepto;
            _vista.txtDetalle.Text = concep.Detalle;
            _vista.cbbTipo.SelectedItem = concep.Tipo;
            _vista.txtValor.Text = concep.Valor.ToString();
            _vista.cbbPercepcionSalarial.SelectedItem = concep.PercepcionSalarial;
        }

        public static void updateConceptoEditarEliminar(conceptoEditarEliminar _vista)
        {
            concep.Tipoconcepto = _vista.cbbTipoConcepto.Text;
            concep.Detalle = _vista.txtDetalle.Text;
            concep.Tipo = _vista.cbbTipo.Text;
            concep.Valor = float.Parse(_vista.txtValor.Text);
            concep.PercepcionSalarial = _vista.cbbPercepcionSalarial.Text;
            concep.updateConcepto();
        }

        public static void deleteConceptoEditarEliminar(conceptoEditarEliminar _vista)
        {
            concep.deleteConcepto();
        }
    }
}
