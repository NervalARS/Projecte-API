using M15_ProjecteConsumidor.Vista;
using M15_ProjecteConsumidor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M15_ProjecteConsumidor.Controlador
{
    class RestauranteController
    {
        VRestaurante VR = new VRestaurante();
        Restaurant RES = new Restaurant();
        public RestauranteController(Restaurant RES)
        {
            VR.ShowDialog();
        }

        private void InitListeners()
        {
            VR.RES_BT_AddFav.Click += AddFavRestaurant;
            VR.RES_BT_ShowMenu.Click += showMenu;
        }


        private void AddFavRestaurant(Object sender, EventArgs e)
        {
            
        }
        
        private void showMenu(Object sender, EventArgs e)
        {
        
        }
    }
}
