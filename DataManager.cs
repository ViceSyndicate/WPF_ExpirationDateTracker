using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json;
using Newtonsoft.Json;

namespace WPF_ExpirationDateTracker
{
    public class DataManager
    {
        string userName;
        private string location = "C:\\Users\\victo\\source\\repos\\WPF_ExpirationDateTracker\\WPF_ExpirationDateTracker\\foods.json";
        //private string jsonFoodFile = "foods.json";

        public DataManager()
        {
            CreateFile();
            userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Console.WriteLine();
        }

        public void CreateFile()
        {
            // C:\Users\%user%\Documents? 
            if (!File.Exists(location))
            {
                FileStream fs = File.Create(location);
                File.Create(location);
                fs.Close();
            }
        }

        public List<Models.Product> GetFoods()
        {
            var products = new List<Models.Product>();

            string jsonString = File.ReadAllText(location);
            //TODO
            //var something = System.Text.Json.JsonSerializer.Deserialize<Models.Product>(jsonString);
            Console.WriteLine();

            if (File.Exists(location))
            {

                using (StreamReader sr = new StreamReader(location))
                {
                    string line = sr.ReadLine();
                    string readData = sr.ReadToEnd();

                    //List<Models.Product> productsList = JsonConvert.DeserializeObject<List<Models.Product>>(readData);
                    using (JsonTextReader reader = new JsonTextReader(sr))
                    {
                        List<Models.Product> productsList = JsonConvert.DeserializeObject<List<Models.Product>>(jsonString);
                        return productsList;
                    }
                    Console.WriteLine();
                }  
                return products;
            }
            return products;
        }

        public bool StoreFoods(List<Models.Product> products)
        {
            try
            {
                string serializedProducts = JsonConvert.SerializeObject(products);
                //var serializedProducts = System.Text.Json.JsonSerializer.Serialize(products);
                File.WriteAllText(location, serializedProducts);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            return true;
        }
    }
}
