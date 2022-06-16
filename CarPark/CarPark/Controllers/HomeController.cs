using Microsoft.AspNetCore.Mvc;
using Ornek1._1.Models;
using System.Diagnostics;

namespace Ornek1._1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //var carPark = new CarPark
            //{
            //    CarParkName = "asdfg",
            //    CarParkID = 11,
            //    CarParkCapacity = 2500,
            //    CarParkFloor = 5,
            //    CarparkAdress = "kjfghkjhfgkhjlhjgkh"

            //};
            //var customer = new Customer
            //{
            //    CustomerName = "Kerem",
            //    CustomerSurname = "Altıntaş",
            //    CustomerID = "5555555",
            //    CustomerCarLisencePlate = "16 RAR 45"
            //};
            //var customerItem = new CustomerItem
            //{
            //    Customer = customer,
            //    CarPark= carPark
            //};
            return View(new CustomerItem());
        }

        [HttpPost]
        public IActionResult Index(CustomerItem customerItem)
        {
            
            return View(customerItem);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}