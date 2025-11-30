namespace HTQuanLyNhanSu.Models
{
   public class ChamCong
{
    public int Id { get; set; }

    public int NhanVienId { get; set; }
    public NhanVien? NhanVien { get; set; }

    public DateTime? NgayLamViec { get; set; }
    public DateTime? NgayNghi { get; set; }
    public int? TongCong { get; set; }

    public string? GhiChu { get; set; }
}

}
