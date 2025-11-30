using Microsoft.AspNetCore.Mvc;

namespace HTQuanLyNhanSu.Controllers
{
    public class XemluongcanhanController : Controller
    {
        public IActionResult Xemluongcanhan()
        {
            return View("~/Views/Nhanvien/Xemluongcanhan.cshtml"); 
        }
    }
}