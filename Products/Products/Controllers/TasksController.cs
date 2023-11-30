using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Sprint_13.Controllers
{
    public class TasksController : Controller
    {
        private Dictionary<string, int> ListProducts => new Dictionary<string, int>
        {
            {"Milk", 2 },
            {"Bread", 2 },
            {"Cake", 1 },
            {"Ice Cream", 5 },
            {"Cola", 10 },
        };
        public IActionResult Greetings() => View();

        public IActionResult SprintTasks() => View();

        public IActionResult ShoppingList()
        {
            return View(ListProducts);
        }

    }
}
