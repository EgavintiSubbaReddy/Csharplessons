using FirstMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace FirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DoLogin(string txtuser, string txtpwd)
        {
            ViewData["uservalue"] = "${txtuser}, {txtpwd}";
            return View();
        }
       
        public IActionResult SayHello(string name)
        {
            if (string.IsNullOrEmpty(name))
                ViewData["v1"] = "Name is Empty";
            else
                ViewData["v1"] = name;
            return View();

        }
        public IActionResult Add(int x, int y)
        {
            int result = x + y;
            ViewData["addResult"] = result;
            return View();
            

        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x * y;
            ViewData["multiplyResult"] = result;
            return View();
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddNewBook(Book pbook)
        {
            Book book = new Book();
            return View(book);
        }



        public IActionResult SaveNewBook(Book pBook)
        {

            return View(pBook);
        }
        public IActionResult ListAllBook()
        {
            string fName = @"c:\temp\book.csv";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                string[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(",");
                    book = StringToBook(data, new Book());
                    list.Add(book);
                }
                return View(list);

            }
        }
        private Book StringToBook(string[] data,Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;
        }
    }
}