using M15_ProjecteConsumidor.Vista;
using M15_ProjecteConsumidor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Mapa
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

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
            setGMap();
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

        private void setGMap()
        {
            GMarkerGoogle gMarker;
            GMapOverlay mapOverlay;
            
            double latini = 41.589661;//RES.geo.lat;
            double lonini = 2.291150;//RES.geo.lon;

            VR.RES_GMAP.MapProvider = GMapProviders.GoogleMap;
            VR.RES_GMAP.DragButton = MouseButtons.Left;
            VR.RES_GMAP.CanDragMap = true;
            VR.RES_GMAP.Position = new PointLatLng(latini, lonini);
            VR.RES_GMAP.MinZoom = 0;
            VR.RES_GMAP.MaxZoom = 24;
            VR.RES_GMAP.Zoom = 9;
            VR.RES_GMAP.AutoScroll = true;
        }

        private void AddFavRestaurant(Object sender, EventArgs e)
        {
            FAV.addToFav(RES);
        }
        
        private void showMenu(Object sender, EventArgs e)
        {
            //MenuController MEN_CON = new MenuController(VR.RES_DGV_Menus.SelectedRows);
        }
    }
}
