using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYSHOPMANAGER.MODELS
{
  public  class SalesDetail
    {
        public int ID { get; set; }

        public double TransactionID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public double Amount { get; set; }
    }
}
