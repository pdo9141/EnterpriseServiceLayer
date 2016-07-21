using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedContracts
{
    public class OrderServiceFindByIDResponse
    {
        public long OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public bool Shipped { get; set; }

        public DateTime ShippedDate { get; set; }

        public string FullAddress { get; set; }

        public string CompanyName { get; set; }

        public string ShipperCompany { get; set; }

        public List<OrderItem> Details { get; set; }
    }
}
