namespace HTQuanLyNhanSu.Models
{
    public class NhanVien
    {
        public int Id { get; set; }
        public string MaNV { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string GioiTinh { get; set; } = string.Empty;
        
        public DateTime NgaySinh { get; set; }
         public DateTime NgayVaoLam { get; set; }
         public string SDT { get; set; } = string.Empty;
        public string CCCD { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        
        public string DiaChi { get; set; } = string.Empty;

        public int PhongBanId { get; set; }
        public PhongBan? PhongBan { get; set; }
    }
}
