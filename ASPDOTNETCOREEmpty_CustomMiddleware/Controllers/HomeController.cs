using Microsoft.AspNetCore.Mvc;

namespace ASPDOTNETCOREEmpty_CustomMiddleware.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
