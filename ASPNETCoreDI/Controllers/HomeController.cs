using ASPNETCoreDI.Models;
using ASPNETCoreDI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNETCoreDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSenderService _service;
        public HomeController(IEmailSenderService service)
        {
            _service = service;                
        }

        public IActionResult Index()
        {
            _service.SendEmail("Hi I'm Yassine");
            return View();
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