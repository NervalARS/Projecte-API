using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M15_ProjecteConsumidor.Vista;
using M15_ProjecteConsumidor.Model;

namespace M15_ProjecteConsumidor.Controlador
{
    class MenuController
    {
        VMenu VM = new VMenu();
        Model.MMenu MEN = new Model.MMenu();
        MenuSection ListMenItem;
        string moneda;

        public MenuController(MenuSection MS, string mone)
        {
            this.moneda = mone;
            this.ListMenItem = MS;
            carga();
            InitListeners();
            VM.ShowDialog();
        }

        private void carga()
        {
            VM.dataGridView1.DataSource = ListMenItem.MenuItems;
        }

        private void InitListeners()
        {
            VM.BT_EXIT.Click += exitMenusVist;
            VM.dataGridView1.CellClick += SelectedItem;
        }

        private void exitMenusVist(Object sender, EventArgs e)
        {
            VM.Close();
        }

        private void SelectedItem(Object sender, DataGridViewCellEventArgs e)
        {
            /*
             string Name
             string Description
             double Price*/

            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;

                Model.MenuItem M = ListMenItem.MenuItems[i];

                this.VM.label1.Text = "Nom Menu: "+M.Name;
                this.VM.label4.Text = "" + M.Price+this.moneda;
                this.VM.label3.Text = "Descripcion: " + M.Description;
            }
        }

        /*private void SelectedItem(Object sender, EventArgs e)
        {
            /*
             string Name
             string Description
             double Price

            if (!VM.dataGridView1.SelectedRows.Count > 0)
            {
                MenuItem MM = VM.dataGridView1.SelectedRows;
                VM.label1.Text(MM.Name);
                /*string Title =VM.dataGridView1.SelectedRows[0].Cells[0];
                string Descripcion = VM.dataGridView1.SelectedRows[0].Cells[1];
                double Price = VM.dataGridView1.SelectedRows[0].Cells[3];
            
           }
        }*/
    }
}
