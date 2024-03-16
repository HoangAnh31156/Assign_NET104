using Assignment_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Data.Configurations
{
	internal class HoaDon_Configuration : IEntityTypeConfiguration<HoaDon>
	{
		public void Configure(EntityTypeBuilder<HoaDon> builder)
		{
			builder.ToTable("HoaDon");

			builder.HasKey(a => a.Id);

			builder.HasOne(a => a.User)
				.WithMany(a => a.HoaDons)
				.HasForeignKey(a => a.Id_User);

			builder.Property(x => x.TrangThai).IsRequired();

			builder.Property(x => x.NgayTao).IsRequired();

			
		}
	}
}
