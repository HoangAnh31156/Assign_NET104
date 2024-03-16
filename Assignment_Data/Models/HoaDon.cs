namespace Assignment_Data.Models
{
	public class HoaDon
	{
		public Guid Id { get; set; }
		public Guid Id_User { get; set; }
		public Guid Id_HinhThucTT { get; set; }
		public int TrangThai { get; set; }
		public DateTime NgayTao { get; set; }
		public decimal TongTien { get; set; }

		public virtual ICollection<HoaDonCT> HoaDonCTs { get; set; }
		public virtual User User { get; set; }
		public virtual ICollection<ThanhToan> ThanhToans { get; set; }
	}
}