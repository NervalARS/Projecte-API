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
        RestaurantesFavoritos FAV;
        public RestauranteController(Restaurant RES)
        {
            VR.ShowDialog();
            VR.RES_Telefon.Text = "Telefon: " + RES.restaurant_phone ;
            VR.RES_Horas.Text = "Horas: " + RES.hours;
            VR.RES_TipoMoneda.Text = "Tipus de moneda: " + RES.price_range;
            VR.RES_Direccion.Text = "Direccio: " + RES.address;
            foreach(string cuisines in RES.cuisines)
            {
                VR.RES_ListBoxDeTipoCocina.Items.Add(cuisines);
            }

            foreach (MMenu menu in RES.menus)
            {
                VR.RES_ListBoxDeTipoCocina.Items.Add(menu.menu_name);
            }

        }

        private void InitListeners()
        {
            VR.RES_BT_AddFav.Click += AddFavRestaurant;
            VR.RES_BT_ShowMenu.Click += showMenu;
        }


        private void AddFavRestaurant(Object sender, EventArgs e)
        {
            FAV.addToFav(RES);
        }
        
        private void showMenu(Object sender, EventArgs e)
        {
            MenuController MEN_CON = new MenuController();
        }
    }
}
