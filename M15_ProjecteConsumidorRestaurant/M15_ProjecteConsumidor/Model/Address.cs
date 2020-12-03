using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15_ProjecteConsumidor.Model
{
    public class Address
    {
        public string city { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
        public string street { get; set; }
        public string formatted { get; set; }
    }
}
