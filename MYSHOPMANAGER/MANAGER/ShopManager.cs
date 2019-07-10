
using MYSHOPMANAGER.MODELS;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MYSHOPMANAGER.MANAGER
{
    public class ShopManager 
    {


        public List<Product> Products { get; set; }

        public  List<POS> pOs { get; set; }

        public DataGrid POSDataGrid { get; set; }


       
        public bool AddPos(POS pos)
        {


            try
            {
                if (pOs == null)

                    pOs = new List<POS>();
                pOs.Add(pos);

                Bindpos();
             
                return true;


            }
            catch (Exception)
            {


                return false;
            }



        }



      
        public void Bindpos()
        {
            try
            {
                if (pOs != null)
                    POSDataGrid.Items.Clear();
                foreach (var item in pOs)
                {
                    POSDataGrid.Items.Add(item);
                }
            }
            catch (NullReferenceException)
            {


            }
        }

        public void ClearPosGrid()
        {
            POSDataGrid.Items.Clear();
            pOs.Clear();
        }


       
       

        //public void GetProducts()
        //{

        //    try
        //    {

        //        Product productslist = new Product() {
        //            Amount = 1000, AvailableQuantity = 10,
        //            CategoryName = "Beverages",
        //            ProductName = "Milk",
        //            ReorderLevel = 10};

        //        ShopManagerDB dB = new ShopManagerDB();
         
        //     dB.DProducts.Add(productslist);
        //        dB.SaveChanges();
        //    }
        //    catch (NullReferenceException)
        //    {

                
        //    }  
            
        //}

        //public void GetCategories()
        //{

        //    try
        //    {

        //        Categories Categorieslist = new Categories() { CategoryName = "Beverages" };
        //        Categories Categoriesli = new Categories() {  CategoryName = "Wine" };
        //        ShopManagerDB dB = new ShopManagerDB();
        //      dB.DCategories.Add(Categorieslist);
        //        Categoriess.Add(Categoriesli);
        //        BindCategories();

               
        //    }
        //    catch (NullReferenceException)
        //    {


        //    }

        //}


    }
}
