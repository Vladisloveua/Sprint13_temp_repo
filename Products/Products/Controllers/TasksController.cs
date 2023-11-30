using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Sprint_13.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Greetings() => View();

        public IActionResult SprintTasks() => View();

        
    }
}
