using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Huang_Darren_HW1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private readonly IWebHostEnvironment _env;
        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutMe()
        {
            return View();
        }
        public IActionResult Music()
        {
            return View();
        }
        public IActionResult Resume()
        {
            string path = _env.WebRootPath + "/files/DarrenHuangResume.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "DarrenHuangResume.pdf");
        }
    }
}
