namespace HTQuanLyNhanSu.Models
{
    public class Luong
    {
        public int Id { get; set; }

        public int NhanVienId { get; set; }
        public NhanVien? NhanVien { get; set; }

        // Lương cơ bản/ngày
        public decimal LuongTheoNgay { get; set; }

        // Phụ cấp
        public decimal PhuCap { get; set; }

        // Số ngày đi làm trong tháng
        public int SoNgayCong { get; set; }

        // Tiền khen thưởng trong tháng
        public decimal TienKhenThuong { get; set; }

        // Tiền kỷ luật trong tháng
        public decimal TienKyLuat { get; set; }

        // Tổng lương = (LuongTheoNgay * SoNgayCong) + PhuCap + TienKhenThuong - TienKyLuat
        public decimal TongLuong
        { 
            get
            {
                return (LuongTheoNgay * SoNgayCong) + PhuCap + TienKhenThuong - TienKyLuat;
            }
        }
    }
}
