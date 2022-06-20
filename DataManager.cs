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
        private string jsonFoodFile = "foods.json";

        public DataManager()
        {
            CreateFile();
        }

        public void CreateFile()
        {
            // C:\Users\%user%\Documents? 
            if (!File.Exists(jsonFoodFile))
            {
                FileStream fs = File.Create(jsonFoodFile);
                fs.Close();
            }
        }

        public List<Models.Product> GetFoods()
        {
            var products = new List<Models.Product>();

            string jsonString = File.ReadAllText(jsonFoodFile);
            //TODO
            //var something = System.Text.Json.JsonSerializer.Deserialize<Models.Product>(jsonString);
            Console.WriteLine();

            if (File.Exists(jsonFoodFile))
            {
                using (StringReader sr = new StringReader(jsonFoodFile))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    string readData = sr.ReadToEnd();

                    List<Models.Product> productsList = JsonConvert.DeserializeObject<List<Models.Product>>(readData);
                    Console.WriteLine();
                }  
                return products;
            }
        }

        public bool StoreFoods(List<Models.Product> products)
        {
            try
            {
                string serializedProducts = JsonConvert.SerializeObject(products);
                //var serializedProducts = System.Text.Json.JsonSerializer.Serialize(products);
                //File.WriteAllText(jsonFoodFile, serializedProducts);
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
