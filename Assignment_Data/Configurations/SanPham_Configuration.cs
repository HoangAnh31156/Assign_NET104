﻿using Assignment_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Data.Configurations
{
	internal class SanPham_Configuration : IEntityTypeConfiguration<SanPham>
	{
		public void Configure(EntityTypeBuilder<SanPham> builder)
		{
			builder.ToTable("SanPham");

			builder.HasKey(a => a.Id);

			builder.HasOne(a => a.LoaiSP)
				.WithMany(a => a.SanPhams)
				.HasForeignKey(a => a.Id_LoaiSP);

			builder.Property(x => x.TrangThai).IsRequired();

			builder.Property(x => x.MauSac).IsRequired().HasColumnType("nvarchar(30)");

		}
	}
}
