using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project.Models
{
    public partial class NGANHANGContext : DbContext
    {
        public NGANHANGContext()
        {
        }

        public NGANHANGContext(DbContextOptions<NGANHANGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chinhanh> Chinhanh { get; set; }
        public virtual DbSet<Giaodich> Giaodich { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Loaigd> Loaigd { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Roleid> Roleid { get; set; }
        public virtual DbSet<Taikhoan> Taikhoan { get; set; }
        public virtual DbSet<TaikhoanNhanvien> TaikhoanNhanvien { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=localhost;Database=NGANHANG;uid=sa;pwd=123456;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chinhanh>(entity =>
            {
                entity.ToTable("CHINHANH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Diachi)
                    .HasColumnName("DIACHI")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tangthai).HasColumnName("TANGTHAI");

                entity.Property(e => e.Tenchinhanh)
                    .HasColumnName("TENCHINHANH")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Giaodich>(entity =>
            {
                entity.ToTable("GIAODICH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Makhachang).HasColumnName("MAKHACHANG");

                entity.Property(e => e.Makhachhangnhan).HasColumnName("MAKHACHHANGNHAN");

                entity.Property(e => e.Maloaigd).HasColumnName("MALOAIGD");

                entity.Property(e => e.Ngaygd)
                    .HasColumnName("NGAYGD")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Noidung)
                    .HasColumnName("NOIDUNG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sotien).HasColumnName("SOTIEN");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.MakhachangNavigation)
                    .WithMany(p => p.Giaodich)
                    .HasForeignKey(d => d.Makhachang)
                    .HasConstraintName("FK__GIAODICH__MAKHAC__20C1E124");

                entity.HasOne(d => d.MaloaigdNavigation)
                    .WithMany(p => p.Giaodich)
                    .HasForeignKey(d => d.Maloaigd)
                    .HasConstraintName("FK__GIAODICH__MALOAI__21B6055D");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.ToTable("KHACHHANG");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__KHACHHAN__161CF724DBF52DAE")
                    .IsUnique();

                entity.HasIndex(e => e.Sdt)
                    .HasName("UQ__KHACHHAN__CA1930A56DA8D3DD")
                    .IsUnique();

                entity.HasIndex(e => e.Socmtnd)
                    .HasName("UQ__KHACHHAN__477C3ACD63069740")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Avatar)
                    .HasColumnName("AVATAR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi)
                    .HasColumnName("DIACHI")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaymotk)
                    .HasColumnName("NGAYMOTK")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("NGAYSINH")
                    .HasColumnType("date");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.Socmtnd).HasColumnName("SOCMTND");

                entity.Property(e => e.Sodutk).HasColumnName("SODUTK");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasColumnName("TEN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
                entity.Property(e => e.Ngaycapcm)
                    .HasColumnName("NGAYCAPCM")
                    .HasColumnType("date");
                entity.Property(e => e.Noicapcm).HasColumnName("NOICAPCM");
            });

            modelBuilder.Entity<Loaigd>(entity =>
            {
                entity.ToTable("LOAIGD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tengd)
                    .HasColumnName("TENGD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
                entity.Property(e => e.Ma).HasColumnName("MA");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("MENU");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Controller)
                    .HasColumnName("CONTROLLER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Macha).HasColumnName("MACHA");

                entity.Property(e => e.Roule)
                    .HasColumnName("ROULE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ten)
                    .HasColumnName("TEN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("TRANGTHAI")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Roleid>(entity =>
            {
                entity.ToTable("ROLEID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Menu).HasColumnName("MENU");

                entity.Property(e => e.Sua).HasColumnName("SUA");

                entity.Property(e => e.Taikhoanid).HasColumnName("TAIKHOANID");

                entity.Property(e => e.Them).HasColumnName("THEM");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.Property(e => e.Xoa).HasColumnName("XOA");

                entity.HasOne(d => d.MenuNavigation)
                    .WithMany(p => p.Roleid)
                    .HasForeignKey(d => d.Menu)
                    .HasConstraintName("FK__ROLEID__MENU__29572725");

                entity.HasOne(d => d.Taikhoan)
                    .WithMany(p => p.Roleid)
                    .HasForeignKey(d => d.Taikhoanid)
                    .HasConstraintName("FK__ROLEID__TAIKHOAN__286302EC");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.ToTable("TAIKHOAN");

                entity.HasIndex(e => e.Sdt)
                    .HasName("UQ__TAIKHOAN__CA1930A53A7A0355")
                    .IsUnique();

                entity.HasIndex(e => e.Socmtnd)
                    .HasName("UQ__TAIKHOAN__477C3ACD8A34221A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Avatar)
                    .HasColumnName("AVATAR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Chinhanh).HasColumnName("CHINHANH");

                entity.Property(e => e.Diachi)
                    .HasColumnName("DIACHI")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Loaitk).HasColumnName("LOAITK");

                entity.Property(e => e.Makhau)
                    .HasColumnName("MAKHAU")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("NGAYSINH")
                    .HasColumnType("date");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.Socmtnd).HasColumnName("SOCMTND");

                entity.Property(e => e.Ten)
                    .HasColumnName("TEN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
            });

            modelBuilder.Entity<TaikhoanNhanvien>(entity =>
            {
                entity.ToTable("TAIKHOAN_NHANVIEN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Magiaodich).HasColumnName("MAGIAODICH");

                entity.Property(e => e.Manhanvien).HasColumnName("MANHANVIEN");

                entity.HasOne(d => d.MagiaodichNavigation)
                    .WithMany(p => p.TaikhoanNhanvien)
                    .HasForeignKey(d => d.Magiaodich)
                    .HasConstraintName("FK__TAIKHOAN___MAGIA__2D27B809");

                entity.HasOne(d => d.ManhanvienNavigation)
                    .WithMany(p => p.TaikhoanNhanvien)
                    .HasForeignKey(d => d.Manhanvien)
                    .HasConstraintName("FK__TAIKHOAN___MANHA__2C3393D0");
            });
        }
    }
}
