﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYSHOPMANAGER.MODELS
{
    public class POS
    {
        public int ID { get; set; }
        public string ProductName { get; set; }

        public decimal Quantity { get; set; }

        public decimal Amount { get; set; }
    }
}
