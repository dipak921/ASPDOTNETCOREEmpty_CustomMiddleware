using Microsoft.AspNetCore.Mvc;

namespace ASPDOTNETCOREEmpty_CustomMiddleware.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["Message"] = "Welcome to ASP.NET Core MVC!";
            //ViewData["CurrentTime"] = DateTime.Now.ToString("F");
            //ViewData["Age"] = 30;

            //string[] arr = { "ASP.NET Core", "MVC", "C#", "Programming"
            //};
            //ViewData["Array"] = arr;

            //List<string> list = new List<string>()
            //{
            //    "Dipak", "Suman", "Rohit", "Satyarth"
            //};
            //ViewData["List"] = list;


            // ********** view Bag ***********
            ViewBag.Message = "Welcome to View Bag!";
            ViewBag.CurrentTime = DateTime.Now.ToString("F");
            ViewBag.Age = 30;

            ViewBag.Array = new string[] { "ASP.NET Core", "MVC", "C#", "Programming" };

            return View();
        }

        //public String Display()
        //{
        //    return ("Welcome to FCT");
        //}

        //public int IntId(int Id)
        //{
        //    return Id;
        //}

        public IActionResult About()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }


    }
}
