using Microsoft.EntityFrameworkCore;
using HTQuanLyNhanSu.Models; // namespace chứa các model của bạn

namespace HTQuanLyNhanSu.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        // DbSet này ánh xạ tới bảng 'Users' trong SQL Server
        public DbSet<User> Users { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<ChamCong> ChamCongs { get; set; }
        public DbSet<KhenThuongKyLuat> KhenThuongKyLuats { get; set; }
        public DbSet<HopDongLaoDong> HopDongLaoDongs { get; set; }
        public DbSet<Luong> Luongs { get; set; }
        public DbSet<NghiPhep> NghiPheps { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1- nhiều: NhanVien - PhongBan
            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.PhongBan)      // 1 nhân viên có 1 phòng ban
                .WithMany(pb => pb.NhanViens)   // 1 phòng ban có nhiều nhân viên
                .HasForeignKey(nv => nv.PhongBanId)
                .OnDelete(DeleteBehavior.Restrict);

            // Quan hệ Trưởng phòng (tùy chọn)
            modelBuilder.Entity<PhongBan>()
                .HasOne(pb => pb.TruongPhong)
                .WithMany() // TruongPhong không cần collection ngược
                .HasForeignKey(pb => pb.TruongPhongId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    
}
}
