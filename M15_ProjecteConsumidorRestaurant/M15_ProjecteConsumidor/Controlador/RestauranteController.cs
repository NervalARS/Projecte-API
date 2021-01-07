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
        Restaurant RES;
        RestaurantesFavoritos FAV;
        VRestaurante VR;
        VInici V2;
        double Glat;
        double Glon;

        public RestauranteController(Restaurant RES, VInici VV)
        {
            //Preparo todas las variables
            V2=VV;
            RES = Repository.GetRestaurantWithName("Panera Bread");
            if (RES!=null) {
                Glat = RES.geo.lat;
                Glon = RES.geo.lon;
            }
            else
            {
                Glat = 32.296934;
                Glon = -64.793031;
            }
            VR = new VRestaurante(Glat, Glon); // Aqui tienes que poner la Latitud primero, Longitud segundo, en formato double

            //Inicio la app
            VR.ShowDialog();
            VR.RES_Telefon.Text = "Telefon: " + RES.restaurant_phone ;
            VR.RES_Horas.Text = "Horas: " + RES.hours;
            VR.RES_TipoMoneda.Text = "Tipus de moneda: " + RES.price_range;
            VR.RES_Direccion.Text = "Direccio: " + RES.address;
            if (RES.cuisines != null)
            {
                foreach (string cuisines in RES.cuisines)
                {
                    VR.RES_ListBoxDeTipoCocina.Items.Add(cuisines);
                }
            }
            if (RES.menus != null)
            {
                foreach (MMenu menu in RES.menus)
                {
                    VR.RES_ListBoxDeTipoCocina.Items.Add(menu.menu_name);
                }
            }
        }

        private void InitListeners()
        {
            VR.RES_BT_AddFav.Click += AddFavRestaurant;
            VR.RES_BT_ShowMenu.Click += showMenu;
            VR.BT_EXIT.Click += exitapp; 
        }

        private void AddFavRestaurant(Object sender, EventArgs e)
        {
            FAV.addToFav(RES);
        }
        
        private void showMenu(Object sender, EventArgs e)
        {
            //MenuController MEN_CON = new MenuController(VR.RES_DGV_Menus.SelectedRows);
        }

        private void exitapp(Object sender, EventArgs e)
        {
            VR.Close();   
        }
    }
}
