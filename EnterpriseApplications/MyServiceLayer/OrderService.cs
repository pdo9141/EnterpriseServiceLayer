using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedContracts;
using MyBusinessLogicLayer.Domain;

namespace MyServiceLayer
{
    public class OrderService
    {
        public OrderServiceFindByIDResponse FindByID(OrderServiceFindByIDRequest request)
        {
            // load the graph for the order using the data access layer
            // you can directly use an O/RM here or perhaps a repository or your data mappers
            Order order = LoadOrderFromPersistence(request.OrderID);

            // prepare the response using an adapter/mapper
            OrderServiceFindByIDAdapter adapter = new OrderServiceFindByIDAdapter(order);
            OrderServiceFindByIDResponse response = adapter.Fill();

            return response;
        }

        private Order LoadOrderFromPersistence(long orderID)
        {
            // fake the funk
            Order order = new Order();
            order.OrderID = 1;
            order.OrderDate = DateTime.UtcNow;
            order.Address = "153 Test Ave.";
            order.City = "Costa Mesa";
            order.Country = "USA";
            order.Customer = new Customer { CompanyName = "" };
            order.Shipper = new Shipper { CompanyName = "" };
            order.OrderDetails = new List<OrderDetail>() { 
                new OrderDetail
                {
                    OrderDetailID = 1,
                    Quantity = 2,
                    Discount = 1.0M,
                    Product = new Product { Description = "Test Description" },
                    UnitPrice = 7.20M
                }};

            return order;
        }

        public OrderServiceUpdateOrderResponse Update(OrderServiceUpdateOrderRequest request)
        {
            // count insertions (if only insertions are requested, avoid loading the graph)
            int insertCount = (from op in request.Changes
                              where op.TypeOfChange == OrderChangeTypes.Create
                              select op).Count();

            if (insertCount == request.Changes.Count)
            {
                foreach (OrderChange change in request.Changes)
                {
                    Order newOrder = new Order();
                    // .
                    // .
                    // .
                    InsertOrderIntoPersistence(newOrder);
                }
            }

            // load the graph for the order using the data access layer
            // you can directly use an O/RM here or perhaps a repository or your data mappers
            Order order = LoadOrderFromPersistence(request.OrderID);
            foreach (OrderChange change in request.Changes)
            {
                switch (change.TypeOfChange)
                {
                    case OrderChangeTypes.Create:
                        break;
                    case OrderChangeTypes.Update:
                        break;
                    case OrderChangeTypes.Delete:
                        break;
                }
            }

            // prepare the response
            // need an adapter here? probably not
            OrderServiceUpdateOrderResponse response = new OrderServiceUpdateOrderResponse();
            // .
            // .
            // .
            return response;
        }

        private void InsertOrderIntoPersistence(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
