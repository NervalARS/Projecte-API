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
        bool loged;
        
        VInici VI = new VInici();
        public InicioController()
        {
            try
            {
                VI.PANEL_REG_AlertaINSUSER.Visible = false;
                this.loged = false;
                InitListeners();
                VI.PANEL_Login.BringToFront();
                Application.Run(VI);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el InicioController.cs: "+e);
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
            #region | Panel Registrar
            VI.PANEL_REG_BT_Volver.Click += VolverALogin;
            VI.PANEL_REG_BT_Registrar.Click += BTRegistrarse;
            #endregion
            #region | Panel Logear
            VI.PANEL_INI_BTRegist.Click += BTRegistrForm;
            VI.PANEL_INIC_BTLogin.Click += BTLogin;
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
        
        #region| Controladores Panel Registrarse
        private void BTRegistrarse(Object sender, EventArgs e)
        {
            try
            {
                AppRegister U = new AppRegister();
                U.USRS = Repository.ComputeSha256Hash(VI.PANEL_REG_USR.Text);
                U.PASSW = Repository.ComputeSha256Hash(VI.PANEL_REG_PASS.Text);
                if (Repository.insertUser(U))
                {
                    VI.PANEL_REG_AlertaINSUSER.Visible = true;
                    VI.PANEL_REG_AlertaINSUSER.Text = "Usuario Insertado Correctamente,\n Vuelve al login para iniciar";
                }
                else
                {
                    VI.PANEL_REG_AlertaINSUSER.Visible = true;
                    VI.PANEL_REG_AlertaINSUSER.Text = "Algo ha fallado en la inserccion";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BTRegistrarse(): "+ex);
            }
        }

        private void VolverALogin(Object sender, EventArgs e)
        {
            VI.PANEL_REG_USR.Text = "";
            VI.PANEL_REG_PASS.Text = "";
            VI.PANEL_REG_AlertaINSUSER.Visible = false;
            VI.PANEL_REG_AlertaINSUSER.Text = "";

            VI.PANEL_Login.BringToFront();
        }
        #endregion

        #region | Controladores Panel Login
        private void BTRegistrForm(Object sender, EventArgs e)
        {
            VI.PANEL_INIC_TBUser.Text = "";
            VI.PANEL_INIC_TBPass.Text = "";
            VI.PANEL_Registrar.BringToFront();
        }

        private void BTLogin(Object sender, EventArgs e)
        {
            try
            {
                if (Repository.usuariExistent(VI.PANEL_INIC_TBUser.Text, VI.PANEL_INIC_TBPass.Text))
                {
                    VI.BT_SHOW_RESTAURANTS.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en el BTLogin: " + ex);
            }
        }
        #endregion

        #region | Controladores Panel Login 
        #endregion
        #region | Otros Métodos

        #endregion
    }
}
