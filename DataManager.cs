using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json;
using Newtonsoft.Json;
using System.Configuration;

namespace WPF_ExpirationDateTracker
{
    public class DataManager
    {
        private string location;

        public DataManager()
        {
            string localFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            location = localFolderPath + "\\foods.json";
            CreateFile();
        }

        public void CreateFile()
        {
            if (File.Exists(location))
            {
                return;
            }
            else 
            {
                FileStream fs = File.Create(location);
                File.Create(location);
                fs.Close();
            }
        }

        public List<Models.Product> GetFoods()
        {
            List<Models.Product> products = new List<Models.Product>();

            if (File.Exists(location))
            {
                string jsonString = File.ReadAllText(location);
                using (StreamReader sr = new StreamReader(location))
                {
                    using (JsonTextReader reader = new JsonTextReader(sr))
                    {
                        var storedProducts = JsonConvert.DeserializeObject<List<Models.Product>>(jsonString);
                        if (storedProducts != null)
                            products = storedProducts;
                        return products;
                    }
                }  
            }
            // return empty list
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
