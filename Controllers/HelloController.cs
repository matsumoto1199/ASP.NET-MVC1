using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace practice2_1021.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome()
        {
            return "This is Welcome page.";
        }
        public IActionResult About()
        {
            ViewData["message"] = "会社概要ページ";
            return View();
        }
    }
}
