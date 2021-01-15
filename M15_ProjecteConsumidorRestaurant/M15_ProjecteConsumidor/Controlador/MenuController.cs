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
        List<Model.MenuItem> ListMenItem;
        public MenuController(List<Model.MenuItem> s)
        {
            this.ListMenItem = s;
            carga();
            InitListeners();
            VM.ShowDialog();
        }

         private void carga()
        {
            VM.dataGridView1.DataSource = ListMenItem;
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
                this.VM.label1.Text = this.ListMenItem[i].Name;
                this.VM.label4.Text = this.ListMenItem[i].Description;
                this.VM.label3.Text = "" + this.ListMenItem[i].Price;
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
