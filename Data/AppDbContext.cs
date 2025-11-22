using Microsoft.EntityFrameworkCore;
using HTQuanLyNhanSu.Models; // namespace chứa các model của bạn

namespace HTQuanLyNhanSu.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<ChamCong> ChamCongs { get; set; }
        public DbSet<KhenThuongKyLuat> KhenThuongKyLuats { get; set; }
        public DbSet<HopDongLaoDong> HopDongLaoDongs { get; set; }
        public DbSet<Luong> Luongs { get; set; }
        public DbSet<NghiPhep> NghiPheps { get; set; }
    
}
}
