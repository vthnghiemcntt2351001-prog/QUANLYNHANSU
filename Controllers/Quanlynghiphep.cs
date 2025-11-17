using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HTQuanLyNhanSu.Controllers
{
    public class QuanlynghiphepController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
