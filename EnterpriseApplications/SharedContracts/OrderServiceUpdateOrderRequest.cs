using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedContracts
{
    public class OrderServiceUpdateOrderRequest
    {
        public int OrderID { get; set; }

        public List<OrderChange> Changes { get; set; }
    }
}
