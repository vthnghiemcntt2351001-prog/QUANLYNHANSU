using Microsoft.AspNetCore.Mvc;

namespace HTQuanLyNhanSu.Controllers
{
    public class DangkynghiphepController : Controller
    {
        public IActionResult Dangkynghiphep()
        {
            return View("~/Views/Nhanvien/Dangkynghiphep.cshtml"); 
        }
    }
}
