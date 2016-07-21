﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedContracts
{
    public class OrderItem
    {
        public long OrderDetailID { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
