using MyBusinessLogicLayer.Domain;
using SharedContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceLayer
{
    internal class OrderServiceFindByIDAdapter
    {
        private Order _order;

        public OrderServiceFindByIDAdapter(Order order)
        {
            _order = order;
        }

        public OrderServiceFindByIDResponse Fill()
        {
            OrderServiceFindByIDResponse response = new OrderServiceFindByIDResponse();
            response.OrderID = _order.OrderID;
            response.OrderDate = _order.OrderDate;
            response.FullAddress = String.Format("{0}, {1}, {2}", _order.Address, _order.City, _order.Country);
            response.CompanyName = _order.Customer.CompanyName;
            response.ShipperCompany = _order.Shipper.CompanyName;
            response.Details = new List<OrderItem>();
            foreach (OrderDetail detail in _order.OrderDetails)
            {
                OrderItem item = new OrderItem();
                item.OrderDetailID = detail.OrderDetailID;
                item.Quantity = detail.Quantity;
                item.Discount = detail.Discount;
                item.Description = detail.Product.Description;
                item.UnitPrice = detail.UnitPrice;
                item.TotalPrice = detail.Quantity * detail.UnitPrice * detail.Discount;
                response.Details.Add(item);
            }

            return response;
        }
    }
}
