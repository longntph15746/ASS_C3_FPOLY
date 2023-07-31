﻿// <auto-generated />
using System;
using ASS_NAM_FPOLY.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASS_NAM_FPOLY.Migrations
{
    [DbContext(typeof(YourDbContext))]
    partial class YourDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASS_NAM_FPOLY.DTO.GRADE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GDTC")
                        .HasColumnType("int");

                    b.Property<string>("MASV")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("TiengAnh")
                        .HasColumnType("int");

                    b.Property<int>("Tinhoc")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("GRADE");
                });

            modelBuilder.Entity("ASS_NAM_FPOLY.DTO.STUDENTS", b =>
                {
                    b.Property<string>("MASV")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Diachi")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Gioitinh")
                        .HasColumnType("bit");

                    b.Property<int?>("GradeID")
                        .HasColumnType("int");

                    b.Property<string>("Hinh")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Hoten")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("MASV");

                    b.HasIndex("GradeID");

                    b.ToTable("STUDENTS");
                });

            modelBuilder.Entity("ASS_NAM_FPOLY.DTO.USERS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("USERS");
                });

            modelBuilder.Entity("ASS_NAM_FPOLY.DTO.STUDENTS", b =>
                {
                    b.HasOne("ASS_NAM_FPOLY.DTO.GRADE", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeID");
                });
#pragma warning restore 612, 618
        }
    }
}
