using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15_ProjecteConsumidor.Model
{
    public class Restaurant
    {
        public string restaurant_name { get; set; }
        public string restaurant_phone { get; set; }
        public string restaurant_website { get; set; }
        public string hours { get; set; }
        public string price_range { get; set; }
        public long restaurant_id { get; set; }
        public List<string> cuisines { get; set; }
        public Address address { get; set; }
        public Geo geo { get; set; }
        public List<MMenu> menus { get; set; }
        public DateTime last_updated { get; set; }

        public Restaurant()
        {
        }

    }
}
