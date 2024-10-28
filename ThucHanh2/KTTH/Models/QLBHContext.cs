using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KTTH.Models
{
    public partial class QLBHContext : DbContext
    {
        public QLBHContext()
        {
        }

        public QLBHContext(DbContextOptions<QLBHContext> options)
            : base(options)
        {
        }
      
       
        public virtual DbSet<TDanhMucSp> TDanhMucSps { get; set; } = null!;
        public virtual DbSet<TLoaiSp> TLoaiSps { get; set; } = null!;
        public virtual DbSet<TUser> TUsers { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-M863II0B\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            



            modelBuilder.Entity<TDanhMucSp>(entity =>
            {
                entity.HasKey(e => e.MaSp);

                entity.ToTable("tDanhMucSP");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength();

                entity.Property(e => e.AnhDaiDien)
                    .HasColumnType("NVARCHAR(MAX)")
                    .IsUnicode(false);
                   
                entity.Property(e => e.Gia).HasColumnType("money");

            

                entity.Property(e => e.GioiThieuSp)
                    .HasMaxLength(255);
                entity.Property(e => e.ChatLieu)
                    .HasMaxLength(255);
                entity.Property(e => e.DacTinh)
                   .HasMaxLength(255);
                entity.Property(e => e.HangSx)
                    .HasMaxLength(255);
                entity.Property(e => e.ThoiGianBaoHanh)
                .HasMaxLength(255);

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NuocSx)
                    .HasMaxLength(255);
                entity.Property(e => e.TenSp)
                    .HasMaxLength(150);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.TDanhMucSps)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK_tDanhMucSP_tLoaiSP");
            });



            modelBuilder.Entity<TLoaiSp>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.ToTable("tLoaiSP");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Loai).HasMaxLength(100);
            });

          

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("tUser");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("password")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
