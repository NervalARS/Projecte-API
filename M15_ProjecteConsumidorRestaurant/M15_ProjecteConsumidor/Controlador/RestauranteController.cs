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
        Result RES;
        VRestaurante VR;
        VInici V2;
        double Glat;
        double Glon;

        public RestauranteController(Restaurant RESTAURANT, VInici VV)
        {
            RES = RESTAURANT.Result;
            RES = Repository.GetRestaurantValues(RESTAURANT);
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
            VR.RES_Nom_ID.Text = "Nom Restaurant: "+RES.RestaurantName;
            VR.RES_Telefon.Text = "Telefon: " + RES.RestaurantPhone ;
            VR.RES_Horas.Text = "Horas: " + RES.Hours;
            VR.RES_TipoMoneda.Text = "Tipus de moneda: " + RES.PriceRange;
            VR.RES_Direccion.Text = "Direccio:"+ RES.Address.Street +", " + RES.Address.City + ", " + RES.Address.PostalCode + ", " + RES.Address.State;
            VR.RES_LastMod.Text = "Ultima Modificacion: " + RES.LastUpdated;
            if (RES.Cuisines != null)
            {
                foreach (string cuisines in RES.Cuisines)
                {
                    VR.RES_ListBoxDeTipoCocina.Items.Add(cuisines);
                }
            }
            if (RES.Menus != null)
            {
                List<MMenu> LM = RES.Menus;
                foreach (MMenu M in LM)
                {
                    VR.comboBox1.Items.Add(M.MenuName);
                }
            }
            VR.ShowDialog();
        }

        private void InitListeners()
        {
            VR.RES_BT_ShowMenu.Click += showMenu;
            VR.BT_EXIT.Click += exitapp;
            VR.comboBox1.SelectedIndexChanged += CBSelected;
            VR.RES_DGV_Menus.SelectionChanged += SelectedRow;
        }

        private void showMenu(Object sender, EventArgs e)
        {
           // MenuController MEN_CON = new MenuController();
        }

        private void exitapp(Object sender, EventArgs e)
        {
            VR.Close();   
        }

        private void CBSelected(Object sender, EventArgs e)
        {
            if (!VR.comboBox1.Text.Equals(null))
            {
                foreach (MMenu M in RES.Menus)
                {
                    if (M.Equals(VR.comboBox1.Text))
                    {
                        VR.RES_DGV_Menus.DataSource = M.MenuSections;
                    }
                }
            }
        }

        private void SelectedRow(Object sender, EventArgs e)
        {
           
        }


    }
}
