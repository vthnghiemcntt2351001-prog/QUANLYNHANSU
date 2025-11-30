namespace HTQuanLyNhanSu.Models
{
    public class ChamCong
    {
        public int Id { get; set; }

        public int NhanVienId { get; set; }
        public NhanVien? NhanVien { get; set; }

        public DateTime Ngay { get; set; } 
        public string TrangThai { get; set; } = string.Empty; // DiLam, Nghi, NghiPhep
        public string? GhiChu { get; set; }
    }
}
