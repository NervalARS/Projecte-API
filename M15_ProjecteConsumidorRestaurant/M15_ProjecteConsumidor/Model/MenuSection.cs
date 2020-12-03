using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15_ProjecteConsumidor.Model
{
    public class MenuSection
    {
        public string section_name { get; set; }
        public string description { get; set; }
        public List<MenuItem> menu_items { get; set; }
    }
}
