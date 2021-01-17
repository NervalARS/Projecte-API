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
                VI.PANEL_INICI.BringToFront();
                Application.Run(VI);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el InicioController.cs");
            }
        }

        #region | Inicio de Controladores
        private void InitListeners()
        {
            #region | Botones Menu
            VI.BT_SHOW_RESTAURANTS.Click += showRestaurant;
            VI.BT_EXIT.Click += Exit;
            #endregion
            #region | Panel Restaurante
            VI.PANEL_REST_BT.Click += newViewRest;
            #endregion
        }
        #endregion

        #region | Controladores Botones Menu Inicio
        private void showRestaurant(Object sender, EventArgs e)
        {
            VI.PANEL_REST.BringToFront();
        }

        
        private void Exit(Object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region | Controladores Panel Restaurante
        private void newViewRest(Object sender, EventArgs e)
        {
            try
            {
                long ID = long.Parse(VI.PANEL_REST_TB_RESTID.Text);
                Restaurant Res = Repository.GetRestaurant(ID);
                if (Res != null)
                {
                    RestauranteController RC = new RestauranteController(Res, VI);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: "+ex);
            }
            
            
        }
        #endregion

        #region | Otros Métodos
        
        #endregion
    }
}
