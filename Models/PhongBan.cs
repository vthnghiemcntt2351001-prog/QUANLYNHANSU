namespace HTQuanLyNhanSu.Models
{
    public class PhongBan
    {
        public int Id { get; set; }
        public string TenPhongBan { get; set; } = string.Empty;
        public string? MaPhong { get; set; }
        public string? MoTa { get; set; }
        public string? AnhDaiDien { get; set; }

        public int? TruongPhongId { get; set; }
        public NhanVien? TruongPhong { get; set; }  // navigation property

        public ICollection<NhanVien>? NhanViens { get; set; }
    }
}
