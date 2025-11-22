namespace HTQuanLyNhanSu.Models
{
    public class KhenThuongKyLuat
    {
        public int Id { get; set; }

        public int NhanVienId { get; set; }
        public NhanVien? NhanVien { get; set; }

        // Tự lấy PhongBan thông qua NhanVien
        public string Loai { get; set; } = string.Empty; // KhenThuong / KyLuat
        public string LyDo { get; set; } = string.Empty;

        public DateTime NgayApDung { get; set; }

        public string NguoiDuyet { get; set; } = string.Empty;
        public string? GhiChu { get; set; }
    }
}
