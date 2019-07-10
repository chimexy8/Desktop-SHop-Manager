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

namespace MYSHOPMANAGER.VIEWS
{
    /// <summary>
    /// Interaction logic for ProductsView.xaml
    /// </summary>
    public partial class ProductsView : Page
    {
      ShopManagerDB dB = new ShopManagerDB();
        public ProductsView()
        {
            InitializeComponent();
            
            DataContext = this;
          
            combo1.ItemsSource= dB.DCategories.ToList();
            productGrid.ItemsSource = dB.DProducts.ToList();

         
        }

        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.productcategorytext == null)

                return;
            var categorycombo = (ComboBox)sender;
            var value = (Categories)categorycombo.SelectedValue;
            try
            {
                this.productcategorytext.Text = value.CategoryName;
            }
            catch (NullReferenceException)
            {



            }
        }
     
     
        private void Savebutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                var product = new Product()
                {
                   
                    Amount = int.Parse(amounttext.Text),
                    AvailableQuantity = int.Parse(stockquantitytext.Text),
                    CategoryName = productcategorytext.Text,
                    ProductName = productnametext.Text,
                    ReorderLevel = Convert.ToDecimal(stockquantitytext.Text)


                };

                dB.DProducts.Add(product);
                dB.SaveChanges();
                productGrid.ItemsSource = dB.DProducts.ToList();


                amounttext.Clear();
                productcategorytext.Clear();
                stockquantitytext.Clear();
                productnametext.Clear();
              
            }
            catch (Exception)
            {

                MessageBox.Show("please input in the correct format");
            }

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selecteditem = productGrid.SelectedItem;
            if (selecteditem != null)
            {
                try
                {

                  
                    Product delstud = selecteditem as Product;
                    dB.DProducts.Remove(delstud);
                    dB.SaveChanges();
                    MessageBox.Show("Product deleted successfully");
                }
                catch (Exception)
                {

                 
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (productGrid.SelectedItem as Product).ID;
                var Edit = dB.DProducts.Where(m => m.ID == Id).ToList();
                foreach (var item in Edit)
                {
                    productnametext.Text = item.ProductName.ToString();
                    amounttext.Text = item.Amount.ToString();
                    stockquantitytext.Text = item.AvailableQuantity.ToString();
                    Updatebutton.Visibility = Visibility.Visible;

                }

               
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (productGrid.SelectedItem as Product).ID;
                var Update = dB.DProducts.Where(m => m.ID == Id).Single();

                Update.ProductName = productnametext.Text;
                Update.Amount = double.Parse(amounttext.Text);
                Update.AvailableQuantity = int.Parse(stockquantitytext.Text);
                Update.ReorderLevel = int.Parse(stockquantitytext.Text);

                dB.SaveChanges();
                productGrid.ItemsSource = dB.DProducts.ToList();

                productnametext.Clear();
                amounttext.Clear();
                stockquantitytext.Clear();
                Updatebutton.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {

            }
        }

        
    }
}
