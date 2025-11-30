using Microsoft.AspNetCore.Mvc;

namespace HTQuanLyNhanSu.Controllers
{
    public class QLphongbanController : Controller
    {
        public IActionResult Index()
        {
            return View(); // => Views/QLphongban/Index.cshtml
        }
    }
}