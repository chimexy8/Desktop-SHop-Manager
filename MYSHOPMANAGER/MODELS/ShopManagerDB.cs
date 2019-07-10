using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MYSHOPMANAGER.MODELS;
using MYSHOPMANAGER.MANAGER;

//using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Data.Entity;


namespace MYSHOPMANAGER.MODELS
{
    public class ShopManagerDB: DbContext
    {
       
        public DbSet<Product> DProducts { get; set; }
        public DbSet<Sales> DSales { get; set; }

        public DbSet<SalesDetail> DSalesDetails { get; set; }

        public DbSet<Categories> DCategories { get; set; }

        public DbSet<Customer> DCustomer { get; set; }
    }
}
