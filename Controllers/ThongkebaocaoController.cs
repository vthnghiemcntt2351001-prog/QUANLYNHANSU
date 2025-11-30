using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HTQuanLyNhanSu.Controllers
{
    public class ThongkebaocaoController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
