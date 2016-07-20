using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyServiceLayer;
using SharedContracts;

namespace MyUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OrderService_FindByID_Test()
        {
            OrderService service = new OrderService();
            OrderServiceFindByIDRequest request = new OrderServiceFindByIDRequest();
            OrderServiceFindByIDResponse response = service.FindByID(request);
        }
    }
}
