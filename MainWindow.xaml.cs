using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//using WPF_ExpirationDateTracker.Models

namespace WPF_ExpirationDateTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal List<Models.Product> productList = new List<Models.Product>();
        public MainWindow()
        {
            InitializeComponent();
            DataManager dataManager = new DataManager();
            // populate product list from local file
            productList = dataManager.GetFoods();
            productGrid.ItemsSource = productList;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string food_name = name.Text;
            string food_expirationdate = date.Text ;

            Models.Product product = new Models.Product();
            // Handle exception when no name or date is entered.
            product.Name = food_name;
            product.ExpirationDate = DateOnly.Parse(food_expirationdate);
            //product.ExpirationDate = Date.Parse(food_expirationdate);
            //product.ExpirationDate = product.ExpirationDate.Date;

            productList.Add(product);

            DataManager dataManager = new DataManager();
            dataManager.StoreFoods(productList);
            // Update productList in the view.
            productGrid.ItemsSource = null;
            productGrid.ItemsSource = productList;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = productGrid.SelectedItem;
            if (selectedItem != null)
            {
                Models.Product targetToDelete = (Models.Product)selectedItem;
                productList.Remove(targetToDelete);
                // Update food.json & view
                DataManager dataManager = new DataManager();
                dataManager.StoreFoods(productList);
                productGrid.ItemsSource = null;
                productGrid.ItemsSource = productList;
            }
        }
    }
}
