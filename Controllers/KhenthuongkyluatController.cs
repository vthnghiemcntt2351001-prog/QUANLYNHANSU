using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using HTQuanLyNhanSu.Controllers;

namespace HTQuanLyNhanSu.Controllers
{
    public class KhenthuongkyluatController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
