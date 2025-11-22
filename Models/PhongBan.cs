namespace HTQuanLyNhanSu.Models
{
    public class PhongBan
    {
        public int Id { get; set; }
        public string TenPhongBan { get; set; } = string.Empty;

        public ICollection<NhanVien>? NhanViens { get; set; }
    }
}