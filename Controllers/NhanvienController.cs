using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HTQuanLyNhanSu.Controllers
{
    public class NhanvienController : Controller
    {
        // GET: Hiển thị trang đăng nhập
        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Role") != "NhanVien")
            return RedirectToAction("AccessDenied", "Login");
            return View(); // => Views/Login/Index.cshtml
        }
         public IActionResult HoSo()
        {
            if (HttpContext.Session.GetString("Role") != "NhanVien")
                return RedirectToAction("AccessDenied", "Login");

            return View();
        }
         public IActionResult NghiPhep()
        {
            if (HttpContext.Session.GetString("Role") != "NhanVien")
                return RedirectToAction("AccessDenied", "Login");

            return View();
        }

        public IActionResult LuongThuong()
        {
            if (HttpContext.Session.GetString("Role") != "NhanVien")
                return RedirectToAction("AccessDenied", "Login");

            return View();
        }
    }
}