using M15_ProjecteConsumidor.Vista;
using M15_ProjecteConsumidor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M15_ProjecteConsumidor.Model;

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

        public RestauranteController(Restaurant RESTAURANT, VInici VV)
        {
            Result RES = Repository.GetRestaurantValues(RESTAURANT);
            //Preparo todas las variables
            V2=VV;
            if (RES!=null) {
                Glat = RES.Geo.Lat;
                Glon = RES.Geo.Lon;
            }
            else
            {
                Glat = 32.296934;
                Glon = -64.793031;
            }
            VR = new VRestaurante(Glat, Glon); // Aqui tienes que poner la Latitud primero, Longitud segundo, en formato double

            //Inicio la app
            VR.ShowDialog();
            VR.RES_Telefon.Text = "Telefon: " + RES.RestaurantPhone ;
            VR.RES_Horas.Text = "Horas: " + RES.Hours;
            VR.RES_TipoMoneda.Text = "Tipus de moneda: " + RES.PriceRange;
            VR.RES_Direccion.Text = "Direccio: " + RES.Address;
            if (RES.Cuisines != null)
            {
                foreach (string cuisines in RES.Cuisines)
                {
                    VR.RES_ListBoxDeTipoCocina.Items.Add(cuisines);
                }
            }
            if (RES.Menus != null)
            {
                foreach (MMenu menu in RES.Menus)
                {
                    VR.RES_ListBoxDeTipoCocina.Items.Add(menu.MenuName);
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
