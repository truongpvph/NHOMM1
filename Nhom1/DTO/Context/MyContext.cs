using System;
using System.Collections.Generic;
using DTO.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DTO.Context;

public partial class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }

    public virtual DbSet<ChiTietPhieuPhat> ChiTietPhieuPhats { get; set; }

    public virtual DbSet<ChiTietPhieutra> ChiTietPhieutras { get; set; }

    public virtual DbSet<DangNhap> DangNhaps { get; set; }

    public virtual DbSet<DocGium> DocGia { get; set; }

    public virtual DbSet<LoaiDocGium> LoaiDocGia { get; set; }

    public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }

    public virtual DbSet<PhieuPhat> PhieuPhats { get; set; }

    public virtual DbSet<Phieutra> Phieutras { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<TheLoai> TheLoais { get; set; }

    public virtual DbSet<VaiTroNhanVien> VaiTroNhanViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= TINICUTI\\SQLEXPRESS ;Initial Catalog=QLDAN;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietPhieuMuon>(entity =>
        {
            entity.HasKey(e => e.MaChiTietPhieuMuon).HasName("PK__ChiTietP__811679097299897B");

            entity.HasOne(d => d.MaPhieuMuonNavigation).WithMany(p => p.ChiTietPhieuMuons).HasConstraintName("FK__ChiTietPh__MaPhi__6A30C649");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.ChiTietPhieuMuons).HasConstraintName("FK__ChiTietPh__MaSac__693CA210");
        });

        modelBuilder.Entity<ChiTietPhieuPhat>(entity =>
        {
            entity.HasKey(e => e.MaChiTietPhieuPhat).HasName("PK__ChiTietP__7BB433B6DB313294");

            entity.HasOne(d => d.MaPhieuPhatNavigation).WithMany(p => p.ChiTietPhieuPhats).HasConstraintName("FK__ChiTietPh__MaPhi__70DDC3D8");
        });

        modelBuilder.Entity<ChiTietPhieutra>(entity =>
        {
            entity.HasKey(e => e.MaPhieuTraChiTiet).HasName("PK__ChiTietP__790804FFB977D118");

            entity.HasOne(d => d.MaDocGiaNavigation).WithMany(p => p.ChiTietPhieutras).HasConstraintName("FK__ChiTietPh__MaDoc__5EBF139D");

            entity.HasOne(d => d.MaPhieuTraNavigation).WithMany(p => p.ChiTietPhieutras).HasConstraintName("FK__ChiTietPh__MaPhi__5DCAEF64");
        });

        modelBuilder.Entity<DangNhap>(entity =>
        {
            entity.HasKey(e => e.TenDangNhap).HasName("PK__DangNhap__55F68FC1A54FB55D");
        });

        modelBuilder.Entity<DocGium>(entity =>
        {
            entity.HasKey(e => e.MaDocGia).HasName("PK__DocGia__F165F94555159C9B");

            entity.HasOne(d => d.LoaiDocGiaNavigation).WithMany(p => p.DocGia).HasConstraintName("FK__DocGia__LoaiDocG__534D60F1");
        });

        modelBuilder.Entity<LoaiDocGium>(entity =>
        {
            entity.HasKey(e => e.MaLoaiDocGia).HasName("PK__LoaiDocG__4BD2AE2850986AE3");
        });

        modelBuilder.Entity<NhaXuatBan>(entity =>
        {
            entity.HasKey(e => e.MaNhaXuatBan).HasName("PK__NhaXuatB__1AED0BFA6DABE824");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NhanVien__77B2CA4793B240AA");

            entity.HasOne(d => d.MaVaiTroNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaVaiT__4D94879B");

            entity.HasOne(d => d.TenDangNhapNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__TenDan__4E88ABD4");
        });

        modelBuilder.Entity<PhieuMuon>(entity =>
        {
            entity.HasKey(e => e.MaPhieuMuon).HasName("PK__PhieuMuo__C4C8222207562E51");

            entity.HasOne(d => d.MaDocGiaNavigation).WithMany(p => p.PhieuMuons).HasConstraintName("FK__PhieuMuon__MaDoc__5629CD9C");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.PhieuMuons).HasConstraintName("FK__PhieuMuon__MaNha__571DF1D5");
        });

        modelBuilder.Entity<PhieuPhat>(entity =>
        {
            entity.HasKey(e => e.MaPhieuPhat).HasName("PK__PhieuPha__E874D2512719F207");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.PhieuPhats).HasConstraintName("FK__PhieuPhat__MaNha__6D0D32F4");

            entity.HasOne(d => d.MaPhieuMuonNavigation).WithMany(p => p.PhieuPhats).HasConstraintName("FK__PhieuPhat__MaPhi__6E01572D");
        });

        modelBuilder.Entity<Phieutra>(entity =>
        {
            entity.HasKey(e => e.MaPhieuTra).HasName("PK__Phieutra__1D880A46493A2D0F");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.Phieutras).HasConstraintName("FK__Phieutra__MaNhan__5AEE82B9");

            entity.HasOne(d => d.MaPhieuMuonNavigation).WithMany(p => p.Phieutras).HasConstraintName("FK__Phieutra__MaPhie__59FA5E80");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742D27DB8557");

            entity.HasOne(d => d.MaNhaXuatBanNavigation).WithMany(p => p.Saches).HasConstraintName("FK__Sach__MaNhaXuatB__66603565");

            entity.HasOne(d => d.MaTheLoaiNavigation).WithMany(p => p.Saches).HasConstraintName("FK__Sach__MaTheLoai__656C112C");
        });

        modelBuilder.Entity<TheLoai>(entity =>
        {
            entity.HasKey(e => e.MaTheLoai).HasName("PK__TheLoai__D73FF34A52D9177A");
        });

        modelBuilder.Entity<VaiTroNhanVien>(entity =>
        {
            entity.HasKey(e => e.MaVaitro).HasName("PK__VaiTroNh__CA4C49F95728D5D5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
