using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15_ProjecteConsumidor.Model
{
    public class MenuItem
    {
        public string name { get; set; }
        public string description { get; set; }
        public List<Pricing> pricing { get; set; }
        public double price { get; set; }
    }
}
