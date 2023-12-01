using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Products.Models;

namespace Sprint_13.Controllers
{
    public class TasksController : Controller
    {
        private List<string> Markets => new List<string>
        {
            "WellMart",
            "Silpo",
            "ATB",
            "Furshet",
            "Metro"
        };
        private Dictionary<string, int> ListProducts => new Dictionary<string, int>
        {
            {"Milk", 2 },
            {"Bread", 2 },
            {"Cake", 1 },
            {"Ice Cream", 5 },
            {"Cola", 10 },
        };
        private Dictionary<string, int> Products_list => new Dictionary<string, int>
        {
            {"Bread", 10 },
            {"Milk", 11 },
            {"Cheese", 140 },
            {"Sausage", 110 },
            {"Potato", 7 },
            {"Banana", 23 },
            {"Tomato", 25 },
            {"Candy", 75 },
        };
        public IActionResult Greetings() => View();

        public IActionResult SprintTasks() => View();

        public IActionResult ShoppingList() => View();

        public IActionResult ProductInfo()
        {
            List<Product> productList = Products_list.Select(kv => new Product { Name = kv.Key, Price = kv.Value }).ToList();
            return View(productList);
        }
        [HttpGet]
        public IActionResult ShoppingCart()
        {
            ViewBag.Markets = Markets;
            return View(ListProducts);
        }
        [HttpPost]
        public IActionResult ShoppingCart(string name, string address)
        {
            return Content($"You products will be shipped at: {address}. Bon appetite, {name}");
        }
    }
}
