using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBusinessLogicLayer.Domain
{
    public class Order
    {
        public long OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public Customer Customer { get; set; }

        public Shipper Shipper { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
