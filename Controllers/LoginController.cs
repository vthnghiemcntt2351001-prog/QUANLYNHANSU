using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using HTQuanLyNhanSu.Data;
using HTQuanLyNhanSu.Models;
using System.Linq;

namespace HTQuanLyNhanSu.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Hiển thị trang đăng nhập
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // => Views/Login/Index.cshtml
        }

    //     // POST: Xử lý đăng nhập
    //     [HttpPost]
    //     public IActionResult Index(string username, string password, string role)
    //     {
    //         var user = _context.Users.FirstOrDefault(u =>
    //             u.Username == username &&
    //             u.Password == password );

    //         if (user == null)
    //         {
    //             ViewBag.Error = "Sai tài khoản hoặc mật khẩu";
    //             return View();
    //         }
    //  // Kiểm tra vai trò được chọn có khớp với vai trò của tài khoản
    // if (role == "employee" && user.Role != "NhanVien")
    // {
    //     ViewBag.Error = "Tài khoản không phải nhân viên";
    //     return View();
    // }

    // if (role == "manager" && user.Role == "NhanVien")
    // {
    //     ViewBag.Error = "Tài khoản nhân viên không được phép đăng nhập với vai trò quản lý";
    //     return View();
    // }



    //         HttpContext.Session.SetString("Username", user.Username);
    //         HttpContext.Session.SetString("Role", user.Role);

    //         return user.Role switch
    //         {
    //             "Admin" => RedirectToAction("Index", "Admin"),
    //             "NhanSu" => RedirectToAction("Index", "NhanSu"),
    //             "NhanVien" => RedirectToAction("Index", "NhanVien"),
    //             _ => RedirectToAction("Index")
    //         };
    //     }

    //     public IActionResult Logout()
    //     {
    //         HttpContext.Session.Clear();
    //         return RedirectToAction("Index");
    //     }

[HttpPost]
public IActionResult Index(string username, string password, string role)
{
    var user = _context.Users.FirstOrDefault(u =>
        u.Username == username &&
        u.Password == password);

    // Sai tài khoản hoặc mật khẩu
    if (user == null)
    {
        ViewBag.Error = "Sai tài khoản hoặc mật khẩu!";
        return View();
    }

    // --- KIỂM TRA VAI TRÒ ĐÚNG VỚI LỰA CHỌN TRÊN FORM ---

    // Người dùng chọn "Nhân viên"
    if (role == "employee" && user.Role != "NhanVien")
    {
        ViewBag.Error = "Tài khoản nhân viên không được phép đăng nhập với vai trò quản lý!";
        return View();
    }

    // Người dùng chọn "Quản lý" nhưng tài khoản lại là nhân viên
    if (role == "manager" && user.Role == "NhanVien")
    {
        ViewBag.Error = "Tài khoản nhân viên không được phép đăng nhập với vai trò quản lý!";
        return View();
    }
    if (User != null)
        {
    // Lưu session
    HttpContext.Session.SetString("Username", user.Username);
    HttpContext.Session.SetString("Role", user.Role);
        }
    // Điều hướng
    return user.Role switch
    {
        "Admin" => RedirectToAction("Index", "QuanTriVien"),
        "NhanSu" => RedirectToAction("Index", "Home"),
        "NhanVien" => RedirectToAction("Index", "NhanVien"),
        _ => RedirectToAction("Index")
    };
        
}


    }
}