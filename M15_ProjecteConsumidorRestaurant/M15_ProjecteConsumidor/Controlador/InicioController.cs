using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M15_ProjecteConsumidor.Vista;
using M15_ProjecteConsumidor.Model;
using System.Windows.Forms;

namespace M15_ProjecteConsumidor.Controlador
{
    class InicioController
    {
        RestaurantesFavoritos RF = new RestaurantesFavoritos();
        VInici VI = new VInici();
        public InicioController()
        {
            InitListeners();
            VI.PANEL_INICI.BringToFront();
            Application.Run(VI);
            Restaurant r = new Restaurant();
            r.restaurant_name = "Restaurante Las Tres Torres";
            RF.addToFav(r);
        }

        #region | Inicio de Controladores
        private void InitListeners()
        {
            #region | Botones Menu
            VI.BT_SHOW_RESTAURANTS.Click += showRestaurant;
            VI.BT_SHOW_MENUS.Click += showMenu;
            VI.BT_SHOW_FAV_RESTAURANTS.Click += showFavRest;
            VI.BT_EXIT.Click += Exit;
            #endregion
            #region | Panel Restaurante
            VI.PANEL_REST_BT.Click += newViewRest;
            #endregion
            #region | Panel Menu
            VI.PANEL_MENU_BT.Click += newViewMenu;
            #endregion
            #region | Panel Restaurantes Favoritos
            VI.PANEL_FAV_BT.Click += newViewFav;
            #endregion
        }
        #endregion

        #region | Controladores Botones Menu Inicio
        private void showRestaurant(Object sender, EventArgs e)
        {
            VI.PANEL_REST.BringToFront();
        }

        private void showMenu(Object sender, EventArgs e)
        {
            VI.PANEL_MENU.BringToFront();
        }

        private void showFavRest(Object sender, EventArgs e)
        {
            VI.PANEL_FAV.BringToFront();
        }

        private void Exit(Object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region | Controladores Panel Restaurante
        private void newViewRest(Object sender, EventArgs e)
        {
            Restaurant Res = new Restaurant();
            // Mas o menos xD | ResFav = VI.PANEL_REST_DGV.SelectedRows;
            RestauranteController RC = new RestauranteController(Res);
        }
        #endregion

        #region | Controladores Panel Menus
        private void newViewMenu(Object sender, EventArgs e)
        {
            MMenu Men = new MMenu();
            // Mas o menos xD | ResFav = VI.PANEL_MENU_DGV.SelectedRows;
            MenuController MC = new MenuController(Men);
        }
        #endregion

        #region | Controlador Panel Favoritos
        private void newViewFav(Object sender, EventArgs e)
        {
            Restaurant ResFav = new Restaurant();
            // Mas o menos xD | ResFav = VI.PANEL_FAV_DGV.SelectedRows;
            RestauranteController RC = new RestauranteController(ResFav);
            FavRestCargarList();
        }
        #endregion

        #region | Otros Métodos
        private void FavRestCargarList()
        {
            if (RF!=null)
            {
                foreach (Restaurant rest in this.RF.getFavRes())
                {
                    VI.PANEL_FAV_LIST.Items.Add(rest.restaurant_name);
                }
            }
            else
            {

            }
        }
        #endregion
    }
}
