using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ExpirationDateTracker.Models
{
    public class ProductModel
    {
        string ProductName { get; set; }
        DateOnly ExpirationDate { get; set; }
    }
}
