using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15_ProjecteConsumidor.Model
{
    class RestaurantesFavoritos
    {
        private List<Restaurant> List = new List<Restaurant>();

        public RestaurantesFavoritos()
        {

        }

        public void addToFav(Restaurant r)
        {
            this.List.Add(r);
        }

        public void delToFav(Restaurant r)
        {
            this.List.Remove(r);
        }

        public List<Restaurant> getFavRes()
        {
            return this.List;
        }

        public void setFavRes(List<Restaurant> l)
        {
            this.List = l;
        }

        public void cargaDades()
        {

        }
    }
}
