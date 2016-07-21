using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedContracts
{
    public class OrderChange
    {
        public OrderChangeTypes TypeOfChange { get; set; }

        public OrderItem NewItem { get; set; }
    }
}
