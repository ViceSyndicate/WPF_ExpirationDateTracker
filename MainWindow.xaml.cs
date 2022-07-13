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

            //string format = "yyyy-MM-dd";
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

            string food_name = name.Text;
            string food_expirationdate = date.Text;

            if (food_name == null || food_name == "")
                return;

            // Convert the date.Text to DateTime
            DateTime expiryDateTime;
            if (!DateTime.TryParse(food_expirationdate, out expiryDateTime))
                return;

            Models.Product product = new Models.Product();
            product.Name = food_name;
            product.ExpirationDate = expiryDateTime;

            productList.Add(product);

            // Store new food
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
        private void productGrid_DataGridAutoGeneratingColumnEventArgs(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType == typeof(DateTime))
            {
                DataGridTextColumn dataGridTextColumn = e.Column as DataGridTextColumn;

                if (dataGridTextColumn != null)
                {
                    dataGridTextColumn.Binding.StringFormat = "{0:d}";
                }
            }
        }

        private void productGrid_DataGridAutoGeneratingColumnEventArgs(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
