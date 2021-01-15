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
        Result RES;
        RestaurantesFavoritos FAV;
        VRestaurante VR;
        VInici V2;
        double Glat;
        double Glon;
        MMenu MmenuGlobal;

        public RestauranteController(Restaurant RESTAURANT, VInici VV)
        {
<<<<<<< Updated upstream
            RES = Repository.GetRestaurantValues(RESTAURANT);
            //Preparo todas las variables
            V2=VV;
            if (RES!=null) {
                Glat = RES.Geo.Lat;
                Glon = RES.Geo.Lon;
            }
            else
=======
            try
>>>>>>> Stashed changes
            {
                RES = RESTAURANT.Result;
                RES = Repository.GetRestaurantValues(RESTAURANT);
                //Preparo todas las variables
                V2 = VV;
                if (RES != null)
                {
                    Glat = RES.Geo.Lat;
                    Glon = RES.Geo.Lon;
                }
                else
                {
                    Glat = 32.296934;
                    Glon = -64.793031;
                }
                VR = new VRestaurante(Glat, Glon); // Aqui tienes que poner la Latitud primero, Longitud segundo, en formato double

<<<<<<< Updated upstream
            //Inicio la app
            VR.ShowDialog();
            VR.RES_Telefon.Text = "Telefon: " + RES.RestaurantPhone ;
            VR.RES_Horas.Text = "Horas: " + RES.Hours;
            VR.RES_TipoMoneda.Text = "Tipus de moneda: " + RES.PriceRange;
            VR.RES_Direccion.Text = "Direccio: " + RES.Address;
            if (RES.Cuisines != null)
            {
                foreach (string cuisines in RES.Cuisines)
=======
                //Inicio la app
                VR.RES_Nom_ID.Text = "Nom Restaurant: " + RES.RestaurantName;
                VR.RES_Telefon.Text = "Telefon: " + RES.RestaurantPhone;
                VR.RES_Horas.Text = "Horas: " + RES.Hours;
                VR.RES_TipoMoneda.Text = "Tipus de moneda: " + RES.PriceRange;
                VR.RES_Direccion.Text = "Direccio:" + RES.Address.Street + ", " + RES.Address.City + ", " + RES.Address.PostalCode + ", " + RES.Address.State;
                VR.RES_LastMod.Text = "Ultima Modificacion: " + RES.LastUpdated;
                if (RES.Cuisines != null)
>>>>>>> Stashed changes
                {
                    foreach (string cuisines in RES.Cuisines)
                    {
                        VR.RES_ListBoxDeTipoCocina.Items.Add(cuisines);
                    }
                }
<<<<<<< Updated upstream
            }
            if (RES.Menus != null)
            {
                foreach (MMenu menu in RES.Menus)
                {
                    VR.RES_ListBoxDeTipoCocina.Items.Add(menu.MenuName);
=======
                if (RES.Menus != null)
                {
                    List<MMenu> LM = RES.Menus;
                    foreach (MMenu M in LM)
                    {
                        VR.comboBox1.Items.Add(M.MenuName);
                    }
>>>>>>> Stashed changes
                }
                InitListeners();
                VR.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en constructor del restaurante vista: "+ex);
            }
        }

        private void InitListeners()
        {
            VR.RES_BT_AddFav.Click += AddFavRestaurant;
            VR.RES_BT_ShowMenu.Click += showMenu;
<<<<<<< Updated upstream
            VR.BT_EXIT.Click += exitapp; 
=======
            VR.BT_EXIT.Click += exitapp;
            VR.comboBox1.SelectedIndexChanged += CBSelected;
>>>>>>> Stashed changes
        }

        private void AddFavRestaurant(Object sender, EventArgs e)
        {
            FAV.addToFav(RES);
        }
        
        private void showMenu(Object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            //MenuController MEN_CON = new MenuController(VR.RES_DGV_Menus.SelectedRows);
=======
            if (!VR.RES_DGV_Menus.SelectedRows.Count > 0)
            {
                string s = VR.RES_DGV_Menus.SelectedRows[0].Cells[0];
                foreach (MenuSection MS in MmenuGlobal)
                {
                    if (MS.SectionName.Equals(s))
                    {
                        MenuController MEN_CON = new MenuController(MS.MenuItems);
                        break;
                    }
                }
            }
>>>>>>> Stashed changes
        }

        private void exitapp(Object sender, EventArgs e)
        {
            VR.Close();   
        }
<<<<<<< Updated upstream
=======

        private void CBSelected(Object sender, EventArgs e)
        {
            if (!VR.comboBox1.Text.Equals(null))
            {
                foreach (MMenu M in RES.Menus)
                {
                    if (M.MenuName.Equals(VR.comboBox1.Text))
                    {
                        MmenuGlobal = M;
                        VR.RES_DGV_Menus.DataSource = M.MenuSections;
                    }
                }
            }
        }
>>>>>>> Stashed changes
    }
}
