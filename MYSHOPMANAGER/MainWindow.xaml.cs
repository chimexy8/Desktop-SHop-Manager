using System;
using MYSHOPMANAGER.MANAGER;
using MYSHOPMANAGER.MODELS;
using MYSHOPMANAGER.VIEWS;
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

namespace MYSHOPMANAGER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShopManager Shopmanager;
        public MainWindow()
        {
            InitializeComponent();
            Shopmanager = new ShopManager();
            DataContext = this;
           
           
        }

      
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "product":
                    shopframe.Content = new ProductsView();
                    break;
                case "categories":
                    shopframe.Content = new CategoryView();
                    break;
                case "sales":
                    shopframe.Content = new SalesView();
                    break;
                case "pos":
                    shopframe.Content = new POSView(Shopmanager);
                    break;
                case "salesdetails":
                    shopframe.Content = new SalesDetailsView();
                    break;
                case "customer":
                    shopframe.Content = new CustomerView();
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
