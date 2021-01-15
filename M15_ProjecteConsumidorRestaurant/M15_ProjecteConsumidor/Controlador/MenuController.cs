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
        MMenu MEN = new Model.MMenu();
        public MenuController(List<MenuItem> s)
        {
            carga(s);
            this.MEN = men;
            InitListeners();
            VM.ShowDialog();
        }

         private void carga(List<MenuItem> ss)
        {
            VM.dataGridView1.DataSource = ss;
        }

        private void InitListeners()
        {
            VM.BT_EXIT += exitMenusVist;
            VM.dataGridView1.SelectionChanged += SelectedItem;
        }

        private void exitMenusVist(Object sender, EventArgs e)
        {
            VM.Close();
        }

        private void SelectedItem(Object sender, EventArgs e)
        {
            /*
             string Name
             string Description
             double Price*/

            if (!VM.dataGridView1.SelectedRows.Count > 0)
            {
                MenuItem MM = VM.dataGridView1.SelectedRows;
                VM.label1.Text(MM.Name);
                /*string Title =VM.dataGridView1.SelectedRows[0].Cells[0];
                string Descripcion = VM.dataGridView1.SelectedRows[0].Cells[1];
                double Price = VM.dataGridView1.SelectedRows[0].Cells[3];
            */
           }
        }
    }
}
