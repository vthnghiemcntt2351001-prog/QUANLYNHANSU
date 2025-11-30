using Microsoft.AspNetCore.Mvc;
using HTQuanLyNhanSu.Data;       // DbContext
using HTQuanLyNhanSu.Models;    // Model NhanVien
using Microsoft.EntityFrameworkCore;

namespace HTQuanLyNhanSu.Controllers
{
    public class QLnhanvienController : Controller
    {
        private readonly AppDbContext _context;

        public QLnhanvienController(AppDbContext context)
        {
            _context = context;
        }

        // GET: danh sách nhân viên
        public IActionResult Index()
        {
            var nhanviens = _context.NhanViens
                .Include(p => p.PhongBan)   // nếu có khóa ngoại
                .ToList();

            return View(nhanviens);
        }
    }
}



// using Microsoft.AspNetCore.Mvc;
// using HTQuanLyNhanSu.Data;
// using HTQuanLyNhanSu.Models;

// namespace HTQuanLyNhanSu.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class NhanVienApiController : ControllerBase
//     {
//         private readonly AppDbContext _db;

//         public NhanVienApiController(AppDbContext db)
//         {
//             _db = db;
//         }

//         // GET ALL
//         [HttpGet]
//         public IActionResult GetAll()
//         {
//             return Ok(_db.NhanViens.ToList());
//         }

//         // CREATE
//         [HttpPost]
//         public IActionResult Create([FromBody] NhanVien nv)
//         {
//             _db.NhanViens.Add(nv);
//             _db.SaveChanges();
//             return Ok(nv);
//         }

//         // UPDATE
//         [HttpPut("{id}")]
//         public IActionResult Update(int id, [FromBody] NhanVien nv)
//         {
//             var e = _db.NhanViens.Find(id);
//             if (e == null) return NotFound();

//             _db.Entry(e).CurrentValues.SetValues(nv);
//             _db.SaveChanges();
//             return Ok(nv);
//         }

//         // DELETE
//         [HttpDelete("{id}")]
//         public IActionResult Delete(int id)
//         {
//             var nv = _db.NhanViens.Find(id);
//             if (nv == null) return NotFound();

//             _db.NhanViens.Remove(nv);
//             _db.SaveChanges();
//             return Ok();
//         }
//     }
// }

