using Microsoft.AspNetCore.Mvc;

namespace HTQuanLyNhanSu.Controllers
{
    public class QLnhanvienController : Controller
    {
        public IActionResult Index()
        {
            return View(); // => Views/Login/Index.cshtml
        }
    }
}




