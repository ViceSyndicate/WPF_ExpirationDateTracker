using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ExpirationDateTracker.Models
{
    public class Product
    {
        private DateTime expirationDate;
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
    }
}
