using ASS_NAM_FPOLY.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_NAM_FPOLY.Database
{
    class YourDbContext : DbContext
    {
        public YourDbContext()
        {
        }
        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
        {
                
        }
        public DbSet<USERS> Users { get; set; }
        public DbSet<STUDENTS> Students { get; set; }
        public DbSet<GRADE> Grades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LongNT;Initial Catalog=ASS_C3_FPOLY ;Persist Security Info=True;User ID=sa;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<STUDENTS>().ToTable("STUDENTS");
            modelBuilder.Entity<USERS>().ToTable("USERS");
            modelBuilder.Entity<GRADE>().ToTable("GRADE");
        }
    }
}
