using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace M15_ProjecteConsumidor.Model
{
    public class Repository
    {
        public static Restaurant selectedRestaurant = new Restaurant();

        private static string ws1 = "https://api.documenu.com/v2/";
        private static string key = "?key=e2b5f2a662a214eb62a4cd0819a1f901";
        public static Restaurant GetRestaurantWithName(string name)
        {

            selectedRestaurant = (Restaurant)MakeRequest(string.Concat(ws1, "restaurant/", name, key), null, "GET", "application/json", typeof(Restaurant)); ;
            return selectedRestaurant;
        }

        public static List<MMenu> GetMenu(Restaurant restaurant)
        {
            List<MMenu> menus = restaurant.menus;
            return menus;
        }

        public static List<MenuSection> GetMenuSections(MMenu menu)
        {
            List<MenuSection> menuSections = menu.menu_sections;
            return menuSections;
        }

        public static List<MenuItem> GetMenuItems(MenuSection menuSection)
        {
            List<MenuItem> menuItems = menuSection.menu_items;
            return menuItems;
        }

        public static List<Pricing> GetPricings(MenuItem menuItem)
        {
            List<Pricing> pricings = menuItem.pricing;
            return pricings;
        }
        public static Address GetAddress(Restaurant restaurant)
        {
            Address address = restaurant.address;
            return address;
        }

        public static List<String> GetCuisines(Restaurant restaurant)
        {
            List<String> cuisines = restaurant.cuisines;
            return cuisines;
        }

        public static Geo GetGeo(Restaurant restaurant)
        {
            Geo geo = restaurant.geo;
            return geo;
        }

        public static object MakeRequest(string requestUrl, object JSONRequest, string JSONmethod, string JSONContentType, Type JSONResponseType)
        //  requestUrl: Url completa del Web Service, amb l'opció sol·licitada
        //  JSONrequest: objecte que se li passa en el body 
        //  JSONmethod: "GET"/"POST"/"PUT"/"DELETE"
        //  JSONContentType: "application/json" en els casos que el Web Service torni objectes
        //  JSONRensponseType:  tipus d'objecte que torna el Web Service (typeof(tipus))
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest; //WebRequest WR = WebRequest.Create(requestUrl);
                string sb = JsonConvert.SerializeObject(JSONRequest);
                request.Method = JSONmethod;  // "GET"/"POST"/"PUT"/"DELETE";  
                //request.Headers.Add("X-API-KEY: ", "e2b5f2a662a214eb62a4cd0819a1f901");
                if (JSONmethod != "GET")
                {
                    request.ContentType = JSONContentType; // "application/json";   
                    Byte[] bt = Encoding.UTF8.GetBytes(sb);
                    Stream st = request.GetRequestStream();
                    st.Write(bt, 0, bt.Length);
                    st.Close();
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));

                    Stream stream1 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream1);
                    string strsb = sr.ReadToEnd();
                    Restaurant objResponse = JsonConvert.DeserializeObject<Restaurant>(strsb);
                    return objResponse;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
