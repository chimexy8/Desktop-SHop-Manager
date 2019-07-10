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

namespace MYSHOPMANAGER.VIEWS
{
    /// <summary>
    /// Interaction logic for SalesView.xaml
    /// </summary>
    public partial class SalesView : Page
    {
        ShopManagerDB dB=new ShopManagerDB();
        public SalesView()
        {
            InitializeComponent();

          
            DataContext = this;
            salesGrid.ItemsSource=dB.DSales.ToList();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selecteditem = salesGrid.SelectedItem;
            if (selecteditem != null)
            {
                try
                {

                    Sales delstud = selecteditem as Sales;
                    dB.DSales.Remove(delstud);
                    dB.SaveChanges();
                    MessageBox.Show("Sales deleted successfully");
                }
                catch (Exception)
                {

                    
                }
            }
        }

        private void SalesGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            e.Cancel = true;


        }

        private void SalesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sales dt = salesGrid.SelectedItem as Sales;

            listd.Items.Clear();
            listv.Items.Clear();
            var vv =dB.DSalesDetails.Where(p => p.TransactionID == dt.TransactionID);

            try
            {

                foreach (var item in vv)
                {

                    listv.Items.Add(item.ProductName);
                    listd.Items.Add(item.Quantity);

                }
            }
            catch (Exception)
            {

                
            }
        }

      
    }
}
