using Microsoft.AspNetCore.Mvc;

namespace HTQuanLyNhanSu.Controllers
{
    public class QLchamcongController : Controller
    {
        public IActionResult Index()
        {
            return View(); // => Views/QLchamcong/Index.cshtml
        }
    }
}
