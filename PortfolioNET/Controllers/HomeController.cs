using Microsoft.AspNetCore.Mvc;
using PortfolioNET.Models;
using System.Diagnostics;

namespace PortfolioNET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MachineLearning()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Hobbies()
        {
            return View(); 
        }
    }
}
