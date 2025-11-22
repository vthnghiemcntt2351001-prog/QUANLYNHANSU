namespace HTQuanLyNhanSu.Models
{
    public class HopDongLaoDong
    {
        public int Id { get; set; }

        public int NhanVienId { get; set; }
        public NhanVien? NhanVien { get; set; }

        public string LoaiHopDong { get; set; } = string.Empty; 
        // Thử việc, Xác định thời hạn, Không thời hạn...

        public DateTime NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; } // Có thể null đối với hợp đồng không thời hạn

        public decimal LuongCoBan { get; set; }

        // ➕ Tình trạng hợp đồng
        public string TinhTrang { get; set; } = "Còn hiệu lực"; 
        // Ví dụ: Đang hiệu lực, Sắp hết hạn, Đã hết hạn, Đã chấm dứt
    }
}
