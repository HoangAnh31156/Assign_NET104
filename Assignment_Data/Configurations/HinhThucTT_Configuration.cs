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
	internal class HinhThucTT_Configuration : IEntityTypeConfiguration<HinhThucTT>
	{
		public void Configure(EntityTypeBuilder<HinhThucTT> builder)
		{
			builder.ToTable("HinhThucThanhToan");

			builder.HasKey(a => a.Id);

			builder.Property(x => x.TenHTTT).IsRequired().HasColumnType("nvarchar(50)");

			builder.Property(x => x.MoTa).HasColumnType("nvarchar(200)");
		}
	}
}
