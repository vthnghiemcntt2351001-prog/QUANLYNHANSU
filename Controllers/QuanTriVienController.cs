using Microsoft.AspNetCore.Mvc;
using HTQuanLyNhanSu.Models;
using HTQuanLyNhanSu.Data;
using Microsoft.EntityFrameworkCore;

namespace HTQuanLyNhanSu.Controllers
{
    public class QuanTriVienController : Controller
    {
        private readonly AppDbContext _db;

        public QuanTriVienController(AppDbContext db)
        {
            _db = db;
        }

        // 📌 Trang Index: kiểm tra quyền Admin
        public IActionResult Index()
        {
            var role = HttpContext.Session.GetString("Role");
            if (role != "Admin")
                return RedirectToAction("AccessDenied", "Error");

            return View(); // form thêm + danh sách nằm trong Index.cshtml
        }

        // 📌 API lấy danh sách Users (JSON)
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _db.Users
                           .OrderBy(u => u.Id)
                           .Select(u => new 
                           {
                               u.Id,
                               u.Username,
                               u.Email,
                               u.Password,
                               u.Role,
                               LastAccess = u.LastAccess.ToString("yyyy-MM-dd HH:mm:ss")
                           })
                           .ToList();
            return Json(users);
        }

        // 📌 API thêm người dùng
        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user == null || string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Email))
                return Json(new { success = false, message = "Dữ liệu không hợp lệ!" });

            user.LastAccess = DateTime.Now;
            _db.Users.Add(user);
            _db.SaveChanges();

            return Json(new { success = true, message = "Thêm người dùng thành công!" });
        }

        // 📌 API sửa người dùng
        [HttpPost]
        public IActionResult UpdateUser([FromBody] User user)
        {
            if (user == null || user.Id <= 0)
                return Json(new { success = false, message = "Dữ liệu không hợp lệ!" });

            var u = _db.Users.FirstOrDefault(x => x.Id == user.Id);
            if (u == null)
                return Json(new { success = false, message = "Không tìm thấy người dùng!" });

            u.Username = user.Username;
            u.Email = user.Email;
            u.Password = user.Password;
            u.Role = user.Role;
            u.LastAccess = DateTime.Now;

            _db.SaveChanges();
            return Json(new { success = true, message = "Cập nhật người dùng thành công!" });
        }

        // 📌 API xóa người dùng
        [HttpPost]
        public IActionResult DeleteUser([FromBody] int id)
        {
            var user = _db.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return Json(new { success = false, message = "Không tìm thấy người dùng!" });

            _db.Users.Remove(user);
            _db.SaveChanges();

            return Json(new { success = true, message = "Xóa người dùng thành công!" });
        }
    }
}
