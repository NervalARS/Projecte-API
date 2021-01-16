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
        VRestaurante VR;
        VInici V2;
        double Glat;
        double Glon;
        Model.MMenu MmenuGlobal;

        public RestauranteController(Restaurant RESTAURANT, VInici VV)
        {
            try
            {
                this.V2 = VV; //Esto guardara la vista inicio
                V2.Close(); //Cerramos el inicio

                //Esto recoge el restaurante requerido
                RES = RESTAURANT.Result;
                RES = Repository.GetRestaurantValues(RESTAURANT);


                //Si el restaurante es null, le assignara al mapa el triangulo de las vermidas para hacer la broma xD
                //si no pues coge las coorenadas del restaurante y se las ensenya (no tengo la enye en el teclado, luego lo cambias xD)
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

                //Aqui le pasamos al metodo que esta dentro de la vista las cooredanas para que las assigne al mapa
                VR = new VRestaurante(Glat, Glon);

                //Abrimos la vista
                VR.ShowDialog();

                //Assigno los datos BASICOS del restaurante a la interfaz
                VR.RES_Nom_ID.Text = "Nom Restaurant: " + RES.RestaurantName;
                VR.RES_Telefon.Text = "Telefon: " + RES.RestaurantPhone;
                VR.RES_Horas.Text = "Horas: " + RES.Hours;
                VR.RES_TipoMoneda.Text = "Tipus de moneda: " + RES.PriceRange;
                VR.RES_Direccion.Text = "Direccio: " + RES.Address;
                VR.RES_LastMod.Text = "Ultima Modificacion: " + RES.LastUpdated;

                //Tipo de cocina (LISTA)
                if (RES.Cuisines != null)
                {
                    foreach (string cuisines in RES.Cuisines)
                    {
                        VR.RES_ListBoxDeTipoCocina.Items.Add(cuisines);
                    }
                }

                //Combo box Menus
                if (RES.Menus != null)
                {
                    foreach (MMenu menu in RES.Menus)
                    {
                        VR.RES_ListBoxDeTipoCocina.Items.Add(menu.MenuName);
                        if (RES.Menus != null)
                        {
                            List<MMenu> LM = RES.Menus;
                            foreach (MMenu M in LM)
                            {
                                VR.comboBox1.Items.Add(M.MenuName);
                            }
                        }
                        InitListeners();
                        VR.ShowDialog();
                    }
                }




            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex);
            }
        }

        private void InitListeners()
        {
            VR.RES_BT_ShowMenu.Click += showMenu;
            VR.BT_EXIT.Click += exitapp; 
            VR.BT_EXIT.Click += exitapp;
            VR.comboBox1.SelectedIndexChanged += CBSelected;
        }

        private void showMenu(Object sender, EventArgs e)
        {
            //MenuController MEN_CON = new MenuController(VR.RES_DGV_Menus.SelectedRows);
            if (!(VR.RES_DGV_Menus.SelectedRows.Count > 0))
            {
                string s ="" + VR.RES_DGV_Menus.SelectedRows[0].Cells[0];
                foreach (MenuSection MS in MmenuGlobal)
                {
                    if (MS.SectionName.Equals(s))
                    {
                        MenuController MEN_CON = new MenuController(MS.MenuItems);
                        break;
                    }
                }
            }
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
                    if (M.MenuName.Equals(VR.comboBox1.Text))
                    {
                        MmenuGlobal = M;
                        VR.RES_DGV_Menus.DataSource = M.MenuSections;
                    }
                }
            }
        }
    }
}
