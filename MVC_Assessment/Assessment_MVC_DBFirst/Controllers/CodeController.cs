using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assessment_1;

namespace Assessment_1.Controllers
{
    public class CodeController : Controller
    {
            private northwindEntities db = new northwindEntities(); 

            // Return all customers residing in Germany
            public ActionResult CustomersInGermany()
            {
            var Customers = db.Customers.Where(customers => customers.Country == "Germany").ToList();
            return View(Customers);
        }

            //Return customer details with a specific OrderId (e.g., 10248)
            public ActionResult CustomerByOrderId(int orderId)
            {
                var customer = db.Orders
                                 .Where(o => o.OrderID == orderId)
                                 .Select(o => o.Customer)
                                 .FirstOrDefault();
                return View(customer);
            }
    }
}
