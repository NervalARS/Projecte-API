using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15_ProjecteConsumidor.Model
{
    class RestaurantesFavoritos
    {
        private List<Result> List = new List<Result>();

        public RestaurantesFavoritos()
        {

        }

        public void addToFav(Result r)
        {
            this.List.Add(r);
        }

        public void delToFav(Result r)
        {
            this.List.Remove(r);
        }

        public List<Result> getFavRes()
        {
            return this.List;
        }

        public void setFavRes(List<Result> l)
        {
            this.List = l;
        }

        public void cargaDades()
        {

        }
    }
}
