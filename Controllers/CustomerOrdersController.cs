using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using MVC_Practice2.Models;

namespace MVC_Practice2.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Erkan",
                LastName = "Karagöz",
                Email = "erkankrgz07@gmail.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 1200.00m, Quantity = 1 },
                new Order { Id = 2, ProductName = "Smartphone", Price = 800.00m, Quantity = 2 },
                new Order { Id = 3, ProductName = "Headphones", Price = 150.00m, Quantity = 3 },
            };
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);

        }
    }
}
