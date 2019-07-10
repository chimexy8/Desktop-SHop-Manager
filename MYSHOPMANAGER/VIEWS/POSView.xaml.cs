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
    /// Interaction logic for POSView.xaml
    /// </summary>
    public partial class POSView : Page
    {
        Random random = new Random();
        
        ShopManagerDB dB = new ShopManagerDB();

        ShopManager shopManager;
        public POSView(ShopManager _shopManager)
        {
            InitializeComponent();
            shopManager = _shopManager;
            DataContext = this;
            combo1.ItemsSource = dB.DCategories.ToList();
            shopManager.POSDataGrid = posGrid;
            shopManager.Bindpos();
            salesdetailsidtext.Text = random.Next().ToString();
           


        }

       
        

        public void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
                
                    var Categorycombo = (ComboBox)sender;
                    var value = (Categories)Categorycombo.SelectedItem;
                    var product = dB.DProducts.Where(p => p.CategoryName == value.CategoryName);
            try
            {
                
                combo2.ItemsSource = product.ToList();
                combo2.DisplayMemberPath = "ProductName";
                combo2.SelectedIndex = -1;
                combo2.SelectedItem = null;
                combo2.SelectedValue = null;
                combo2.SelectedValue = "";
                combo2.Text = "";

            }
            catch (NullReferenceException)
            {

             
                posamounttext.Clear();
                selectedproducttext.Clear();
                combo2.SelectedIndex = -1;
                combo2.SelectedItem = null;
                combo2.SelectedValue = null;
                combo2.SelectedValue = "";
                combo2.Text = "";

            }




        }

        private void Combo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            var productcombo = (ComboBox)sender;
            var value = (Product)productcombo.SelectedItem;
           
            
                var product = dB.DProducts.Where(p => p.ProductName == value.ProductName);
            try
            {
                foreach (var item in product)
                {


                    posamounttext.Text = item.Amount.ToString();
                    selectedproducttext.Text = item.ProductName;


                }
                combo2.SelectedIndex = -1;
                combo2.SelectedItem = null;
                combo2.SelectedValue = null;
                combo2.SelectedValue = "";
            }
            catch (Exception)
            {

               
            }   
                   
               // shopmanager.BindProduct();
            
               
           
           
        }
        double count = 0;
       
        
        double carttotal;
        
        

        private void Save_Click(object sender, RoutedEventArgs e)
        {
          
            
            var d = selectedproducttext.Text;

            var product = dB.DProducts.Where(p => p.ProductName == d ).ToList();

            foreach (var item in product)
            {
                if (quantitytext.Text!=null)
                {
                    try
                    {
                        if (decimal.Parse(quantitytext.Text) < item.ReorderLevel)
                        {
                            if (item.ReorderLevel == 0)
                            {
                                MessageBox.Show("You are out of item");
                            }
                            else if (item.ReorderLevel > 0 && item.ReorderLevel <= 5)
                            {
                                MessageBox.Show("You are running low on item");

                                try
                                {
                                    
                                    var sd = new SalesDetail()
                                    {
                                        TransactionID = double.Parse(salesdetailsidtext.Text),
                                        Amount = int.Parse(posamounttext.Text),
                                  
                                        ProductName = selectedproducttext.Text,
                                        Quantity = int.Parse(quantitytext.Text)

                                    };
                                    dB.DSalesDetails.Add(sd);
                                    dB.SaveChanges();

                                    var pos = new POS()
                                    {
                                        
                                        Amount = decimal.Parse(posamounttext.Text),
                                        ProductName = selectedproducttext.Text,
                                        Quantity = decimal.Parse(quantitytext.Text)

                                    };
                                    
                                    shopManager.AddPos(pos);
                                    shopManager.Bindpos();
                                }
                                catch (Exception)
                                {

                                    MessageBox.Show("please input in the correct format");
                                }


                              if (count == 0)
                               {
                                    var total = item.Amount * double.Parse(quantitytext.Text);
                                    carttotal = total;
                                    totaltext.Text = total.ToString();
                                  item.ReorderLevel -= int.Parse(quantitytext.Text);
                                 
                               }

                                if (count > 0)
                               {
                                    var total = item.Amount * double.Parse(quantitytext.Text);
                                    var fulltot = total + carttotal;
                                    totaltext.Text = fulltot.ToString();
                                    item.ReorderLevel -= int.Parse(quantitytext.Text);
                                    
                                }
                                count += 1;
                                

                            }

                            else
                            {




                                var sd = new SalesDetail()
                                {
                                    TransactionID = double.Parse(salesdetailsidtext.Text),
                                        Amount = double.Parse(posamounttext.Text),
                                        ProductName = selectedproducttext.Text,
                                        Quantity = int.Parse(quantitytext.Text),
                                       
                            };
                               

                                    dB.DSalesDetails.Add(sd);
                               

                                dB.SaveChanges();

                                    var pos = new POS()
                                    {

                                        Amount = decimal.Parse(posamounttext.Text),

                                        ProductName = selectedproducttext.Text,
                                        Quantity = decimal.Parse(quantitytext.Text)

                                    };
                                    shopManager.AddPos(pos);
                                    shopManager.Bindpos();

                      

                                if (count == 0)
                               {



                                  double total = item.Amount * double.Parse(quantitytext.Text);
                                 carttotal = total;
                                    totaltext.Text = total.ToString();
                                    item.ReorderLevel -= int.Parse(quantitytext.Text);
                                


                              }
                              if (count > 0)
                              {



                                    var total = item.Amount * double.Parse(quantitytext.Text);
                                    
                                    var fulltot = total + carttotal;
                                    carttotal = fulltot;
                                    totaltext.Text = fulltot.ToString();
                                    item.ReorderLevel -= int.Parse(quantitytext.Text);


                                }
                                count += 1;
                               


                            }
                        }
                        else
                        {
                            MessageBox.Show("Quantity in demand is greater than available level please reduce quantity");
                        }
                    }
                    catch (FormatException)
                    {

                        MessageBox.Show("please input quantity");
                    }
                }
               
            }
            quantitytext.Clear();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          

            try
            {
                

                var sd = new Sales()
                {
                    CustomerName = fullnametext.Text,
                    TransactionID = double.Parse(salesdetailsidtext.Text),
                    Amountpaid = decimal.Parse(amountpaidtext.Text),
                    Balance = decimal.Parse(totaltext.Text) - decimal.Parse(amountpaidtext.Text),
                    Date = DateTime.Parse(datetext.Text),
                    TotalAmount = decimal.Parse(totaltext.Text)

                };
                dB.DSales.Add(sd);
                dB.SaveChanges();

                var cd = new Customer()
                {
                    CustomerName = fullnametext.Text,
                    Email = emailtext.Text,
                    Phone = phonenumbertext.Text,
                    payments = decimal.Parse(amountpaidtext.Text),
                    Balance = decimal.Parse(totaltext.Text) - decimal.Parse(amountpaidtext.Text)




                };
                  dB.DCustomer.Add(cd);
                dB.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("please input in the correct format");
            }

          
            fullnametext.Clear();
            amountpaidtext.Clear();
            totaltext.Clear();
            emailtext.Clear();
            phonenumbertext.Clear();
            posGrid.Items.Clear();
          shopManager.ClearPosGrid();
            count = 0;
            carttotal = 0;
            Random random2 = new Random();
            var NewTID = int.Parse(salesdetailsidtext.Text) + random2.Next();
            salesdetailsidtext.Text = NewTID.ToString();
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var selecteditem = posGrid.SelectedItem;
            if (selecteditem != null)
            {
                posGrid.Items.Remove(selecteditem);
                POS delstud = selecteditem as POS;
               // shopmanager.DeletePOS(delstud);
                MessageBox.Show("Purchase deleted successfully");
            }
        }
    }
}


