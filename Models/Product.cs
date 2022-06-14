using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ExpirationDateTracker.Models
{
    [Serializable] public class Product
    {
        string ProductName { get; set; }
        DateOnly ExpirationDate { get; set; }
    }
}
