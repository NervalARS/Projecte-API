using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M15_ProjecteConsumidor.Vista;
using M15_ProjecteConsumidor.Model;

namespace M15_ProjecteConsumidor.Controlador
{
    class MenuController
    {
        VMenu VM = new VMenu();
        MMenu MEN = new Model.MMenu();
        public MenuController(MMenu men)
        {
            this.MEN = men;
            VM.ShowDialog();
        }


    }
}
