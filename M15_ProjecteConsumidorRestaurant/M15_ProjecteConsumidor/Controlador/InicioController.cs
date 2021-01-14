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

        VInici VI = new VInici();
        public InicioController()
        {
            try
            {
                InitListeners();
                Application.Run(VI);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el InicioController.cs" + e);
            }
        }

        #region | Inicio de Controladores
        private void InitListeners()
        {
            #region | Botones Menu
            VI.BT_SHOW_RESTAURANTS.Click += showRestaurant;
            VI.BT_SHOW_MENUS.Click += showMenu;
            VI.BT_EXIT.Click += Exit;
            #endregion
            #region | Panel Restaurante
            VI.PANEL_REST_BT.Click += newViewRest;
            #endregion
            #region | Panel Menu
            VI.PANEL_MENU_BT.Click += newViewMenu;
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

       private void Exit(Object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region | Controladores Panel Restaurante
        private void newViewRest(Object sender, EventArgs e)
        {
            try {
                Restaurant Res = Repository.GetRestaurant(VI.PANEL_REST_TB_RESTID.Text);
                RestauranteController RC = new RestauranteController(Res, this.VI);
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: "+exc);
            }
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

       
        #region | Otros Métodos
        
        #endregion
    }
}
