using Microsoft.AspNetCore.Mvc;
using MVCAppTaghelper.Models;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace MVCAppTaghelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        
        public ActionResult Menu()
        {
            string conString = _configuration.GetConnectionString("DefaultConnection");
            _logger.Log(LogLevel.Debug, conString); 
            _logger.Log(LogLevel.Information, "Testing");
            return View();
        }
        public ActionResult Echo(String name, String city)
        {
            String S1 = "user" + name + "from city=" + city;
            ViewData.Add("Data1", S1);
            return View(S1);
        }
        public ActionResult SayHello(String name)
        {
            String s1 = ("Hello" + name);
            ViewData.Add("Data1", s1);
            return View();
        }

        //Method overload
        [HttpPost]
        public IActionResult Index(int x,IFormCollection collection)
        {
            StringBuilder Data = new StringBuilder(500);
            Data.Append("x:");
            Data.Append(x);
            Data.Append(" ");
            Data.Append("name:");
            Data.Append(collection["name"]);
            Data.Append(" ");
            Data.Append("password:");
            Data.Append(collection["password"]);
            /*foreach (var item in collection)
            {
                Data.Append(item.Key);
                Data.Append(":");
                Data.Append(item.Value);
                Data.Append(" ");

            }
            */
            ViewData["x"] = Data.ToString();
            return View("IndexPost");
        }
        public ActionResult DoTask(int? id)
        {
            if (id.HasValue)
            {
                ViewData["id"] = id.Value;
            }
            else
            {
                ViewData["id"] = 0;
            }
            return View();
        }
        public ActionResult test()
        {
            return RedirectToAction("Index");
        }
        public IActionResult GetBook()
        {
            Book b1 = new Book(){ AuthorName = "H lee" };
            ViewData["Book"] = b1;
            return View();
        }
        [ResponseCache(Duration = 15)]
        public ActionResult GetTime()
        {
            String todate = DateTime.Now.ToLongTimeString();
            ViewData["date"] = todate;
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