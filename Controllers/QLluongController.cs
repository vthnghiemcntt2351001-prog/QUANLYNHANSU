using Microsoft.AspNetCore.Mvc;

namespace HTQuanLyNhanSu.Controllers
{
    public class QLluongController : Controller
    {
        public IActionResult Index()
        {
            return View(); // => Views/QLluong/Index.cshtml
        }
    }
}