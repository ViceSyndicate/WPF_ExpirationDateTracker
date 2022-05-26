using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_ExpirationDateTracker.Models;

namespace WPF_ExpirationDateTracker.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _productName;
        private DateOnly _expiryDate;
        private ProductModel _selectedProduct;
        private BindableCollection<ProductModel> _products = new BindableCollection<ProductModel>();

        public ShellViewModel()
        {
            Products.Add(new ProductModel {});
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }
        public DateOnly ExpiryDate
        {
            get
            {
                return _expiryDate;
            }
            set
            {
                _expiryDate = value;
            }
        }

        public BindableCollection<ProductModel> Products
        {
            get { return _products; }
            set { _products = value; }
        }

        

        public ProductModel SelectedProduct
        {
            get { return _selectedProduct; }
            set 
            { 
                _selectedProduct = value; 
                NotifyOfPropertyChange(() => SelectedProduct);
            }
        }
    }
}
