namespace HTQuanLyNhanSu.Models
{
    public class NghiPhep
    {
        public int Id { get; set; }

        public int NhanVienId { get; set; }
        public NhanVien? NhanVien { get; set; }

        // ➕ Loại nghỉ
        public string LoaiNghi { get; set; } = string.Empty; // Ví dụ: Nghỉ phép, Nghỉ ốm

        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public string LyDo { get; set; } = string.Empty;

        // ➕ Trạng thái hiển thị trên giao diện
        public string TrangThai { get; set; } = "Chưa duyệt"; // "Đã duyệt", "Chưa duyệt", "Từ chối"

        // ➕ Người duyệt
        public string? NguoiDuyet { get; set; }
    }
}
