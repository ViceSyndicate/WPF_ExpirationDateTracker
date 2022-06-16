using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ExpirationDateTracker.Models
{
    [Serializable] public class Product
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        private DateOnly expirationDate;
        public DateOnly ExpirationDate
        { 
            get { return expirationDate; } 
            set { expirationDate = value; }
        }

    }
}
