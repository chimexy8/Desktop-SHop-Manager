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
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : Page
    {
        ShopManagerDB dB=new ShopManagerDB();
        public CustomerView()
        {
            InitializeComponent();
         
            DataContext = this;
            CustomerGrid.ItemsSource=dB.DCustomer.ToList();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selecteditem = CustomerGrid.SelectedItem;
            if (selecteditem != null)
            {
                try
                {

                   
                    Customer delstud = selecteditem as Customer;
                    dB.DCustomer.Remove(delstud);
                    dB.SaveChanges();
                    MessageBox.Show("Product deleted successfully");
                }
                catch (Exception)
                {


                }
            }
        }

       
    }
}
