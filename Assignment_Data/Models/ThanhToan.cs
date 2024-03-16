﻿namespace Assignment_Data.Models
{
	public class ThanhToan
	{
		public Guid Id { get; set; }
		public Guid Id_HoaDon { get; set; }
		public Guid Id_HTTT { get; set; }
		public int TrangThai { get; set; }
		public DateTime NgayTT { get; set; }

		public virtual HoaDon HoaDon { get; set; }
		public virtual HinhThucTT HinhThucTT { get; set; }
	}
}