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
using MYSHOPMANAGER.MANAGER;
using MYSHOPMANAGER.MODELS;
using MYSHOPMANAGER.VIEWS;

namespace MYSHOPMANAGER.VIEWS
{
    /// <summary>
    /// Interaction logic for SalesDetailsView.xaml
    /// </summary>
    public partial class SalesDetailsView : Page
    {
        ShopManagerDB dB = new ShopManagerDB();
        public SalesDetailsView()
        {
            InitializeComponent();
       
            DataContext = this;
           salesDetailsGrid.ItemsSource=dB.DSalesDetails.ToList();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var selecteditem = salesDetailsGrid.SelectedItem;
            if (selecteditem != null)
            {
                salesDetailsGrid.Items.Remove(selecteditem);
                SalesDetail delstud = selecteditem as SalesDetail;
             //   shopManager.DeleteSalesDetails(delstud);
                MessageBox.Show("Sales Detail deleted successfully");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var selecteditem = salesDetailsGrid.SelectedItem;
            if (selecteditem != null)
            {
                try
                {
                    SalesDetail delstud = selecteditem as SalesDetail;
                    dB.DSalesDetails.Remove(delstud);
                    dB.SaveChanges();
                }
                catch (Exception)
                {

                    
                }
            }

        }
    }
}
