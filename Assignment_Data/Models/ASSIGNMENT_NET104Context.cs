using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Assignment_Data.Models
{
    public partial class ASSIGNMENT_NET104Context : DbContext
    {
        public ASSIGNMENT_NET104Context()
        {
        }

        public ASSIGNMENT_NET104Context(DbContextOptions<ASSIGNMENT_NET104Context> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-B52SRBN\\SQLEXPRESS;Database=ASSIGNMENT_NET104;Trusted_Connection=True; Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
