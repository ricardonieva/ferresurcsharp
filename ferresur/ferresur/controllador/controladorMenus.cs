using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferresur.controllador
{
    class controladorMenus
    {
        public static void menuEmpleado()
        {
            menuEmpleados me = new menuEmpleados();
            me.Show();
        }

        public static void menuPrincipal()
        {
            menuPrincipal mp = new menuPrincipal();
            mp.Show();
        }

    }
}
