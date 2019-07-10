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
    /// Interaction logic for CategoryView.xaml
    /// </summary>
    public partial class CategoryView : Page
    {
        ShopManagerDB db = new ShopManagerDB();

        public CategoryView()
        {
            InitializeComponent();

            

        }



        private void Savebutton_Click(object sender, RoutedEventArgs e)
        {
            Categories categories = new Categories() { CategoryName = categorynametext.Text };
            db.DCategories.Add(categories);
            db.SaveChanges();
            categoryGrid.ItemsSource = db.DCategories.ToList();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var selecteditem = categoryGrid.SelectedItem;
            if (selecteditem != null)
            {
                try
                {
                    // categoryGrid.Items.Remove(selecteditem);
                    Categories delstud = selecteditem as Categories;
                    db.DCategories.Remove(delstud);
                    db.SaveChanges();
                    MessageBox.Show("Category deleted successfully");
                }
                catch (Exception)
                {


                }
            }




        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            categoryGrid.ItemsSource = db.DCategories.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = (categoryGrid.SelectedItem as Categories).ID;
                var Edit = db.DCategories.Where(m => m.ID == Id).ToList();
                foreach (var item in Edit)
                {
                    categorynametext.Text = item.CategoryName.ToString();


                }


            }
            catch (Exception)
            {

            }
        }
    }
}
