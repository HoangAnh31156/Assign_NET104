﻿namespace Assignment_Data.Models
{
	public class Role
	{
		public int Id { get; set; }
		public string? VaiTro { get; set; }

		public virtual ICollection<User> Users { get; set; }
	}
}