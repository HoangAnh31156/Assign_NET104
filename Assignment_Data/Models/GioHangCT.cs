namespace Assignment_Data.Models
{
	public class GioHangCT
	{
		public Guid Id_User { get; set; }
		public Guid ID_SP { get; set; }
		public int TrangThai { get; set; }	
		public int SoLuong { get; set; }

		public virtual SanPham SanPham { get; set; }
		public virtual GioHang GioHang { get; set; }
	}
}