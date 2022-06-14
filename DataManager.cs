using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ExpirationDateTracker
{
    internal class DataManager
    {
        private string binaryFoodFile = "foods.bin";

        public void CreateFile()
        {
            if (!File.Exists(binaryFoodFile))
            {
                File.Create(binaryFoodFile);
            }
        }

        public bool StoreFoods(List<WPF_ExpirationDateTracker.Models.Product> products)
        {
            using (StreamWriter sw = new StreamWriter(binaryFoodFile))
            { 
                sw.WriteLine(products.Count.ToString());
            }
            return false;
        }
    }
}
