using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MYSHOPMANAGER.MODELS;



namespace MYSHOPMANAGER.MODELS
{
   public class Product
    {
        public int ID { get; set; }

        public string ProductName { get; set; }

        public string CategoryName { get; set; }

        public double Amount { get; set; }

        public double AvailableQuantity { get; set; }

        public decimal ReorderLevel { get; set; }

       


    }
}
