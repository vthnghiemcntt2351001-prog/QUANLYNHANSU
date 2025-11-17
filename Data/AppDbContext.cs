using Microsoft.EntityFrameworkCore;
using HTQuanLyNhanSu.Models; // namespace chứa các model của bạn

namespace HTQuanLyNhanSu.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    
}
}
