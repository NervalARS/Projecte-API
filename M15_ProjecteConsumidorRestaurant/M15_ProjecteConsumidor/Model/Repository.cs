using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Linq;


namespace M15_ProjecteConsumidor.Model
{
    public class Repository
    {
        public static Restaurant selectedRestaurant = new Restaurant();

        private static string ws1 = "https://api.documenu.com/v2/";
        private static string key = "?key=e2b5f2a662a214eb62a4cd0819a1f901";
        public static Restaurant GetRestaurant(long id)
        {

            selectedRestaurant = (Restaurant)MakeRequest(string.Concat(ws1, "restaurant/", id, key), null, "GET", "application/json", typeof(Restaurant));
            return selectedRestaurant;
        }

        public static Result GetRestaurantValues(Restaurant Restaurant)
        {

            Result RestaurantResult =  Restaurant.Result;
            return RestaurantResult;
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
                    object objResponse = JsonConvert.DeserializeObject<Restaurant>(strsb);
                    return objResponse;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static bool insertUser(AppRegister U)
        {
            try
            {
                APIEntities1 AE = new APIEntities1();
                AE.AppRegister.Add(U);
                AE.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: "+ex);
                return false;
            }
        }

        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool usuariExistent(string usr, string pas)
        {
            APIEntities1 AE = new APIEntities1();
            List<AppRegister> ListUsers = AE.AppRegister.ToList();
            foreach (AppRegister U in ListUsers)
            {
                if ( (U.USRS.Equals(ComputeSha256Hash(usr))) && (U.PASSW.Equals(ComputeSha256Hash(pas))) )
                {
                    return true;
                }
            }
            return false;
        }
    }
}
