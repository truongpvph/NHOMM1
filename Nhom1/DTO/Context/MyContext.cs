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
        => optionsBuilder.UseSqlServer("Data Source= TRANCHUNG\\SQLEXPRESS01 ;Initial Catalog=QLDA;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietPhieuMuon>(entity =>
        {
            entity.HasKey(e => e.MaChiTietPhieuMuon).HasName("PK__ChiTietP__81167909C263DE54");

            entity.HasOne(d => d.MaPhieuMuonNavigation).WithMany(p => p.ChiTietPhieuMuons).HasConstraintName("FK__ChiTietPh__MaPhi__5812160E");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.ChiTietPhieuMuons).HasConstraintName("FK__ChiTietPh__MaSac__571DF1D5");
        });

        modelBuilder.Entity<ChiTietPhieuPhat>(entity =>
        {
            entity.HasKey(e => e.MaChiTietPhieuPhat).HasName("PK__ChiTietP__7BB433B66FBC9EF7");

            entity.HasOne(d => d.MaPhieuPhatNavigation).WithMany(p => p.ChiTietPhieuPhats).HasConstraintName("FK__ChiTietPh__MaPhi__5EBF139D");
        });

        modelBuilder.Entity<ChiTietPhieutra>(entity =>
        {
            entity.HasKey(e => e.MaPhieuTraChiTiet).HasName("PK__ChiTietP__790804FF6821159A");

            entity.HasOne(d => d.MaDocGiaNavigation).WithMany(p => p.ChiTietPhieutras).HasConstraintName("FK__ChiTietPh__MaDoc__4CA06362");

            entity.HasOne(d => d.MaPhieuTraNavigation).WithMany(p => p.ChiTietPhieutras).HasConstraintName("FK__ChiTietPh__MaPhi__4BAC3F29");
        });

        modelBuilder.Entity<DangNhap>(entity =>
        {
            entity.HasKey(e => e.TenDangNhap).HasName("PK__DangNhap__55F68FC194F54489");
        });

        modelBuilder.Entity<DocGium>(entity =>
        {
            entity.HasKey(e => e.MaDocGia).HasName("PK__DocGia__F165F94597798E17");

            entity.HasOne(d => d.LoaiDocGiaNavigation).WithMany(p => p.DocGia).HasConstraintName("FK__DocGia__LoaiDocG__412EB0B6");
        });

        modelBuilder.Entity<LoaiDocGium>(entity =>
        {
            entity.HasKey(e => e.MaLoaiDocGia).HasName("PK__LoaiDocG__4BD2AE2898C563B3");
        });

        modelBuilder.Entity<NhaXuatBan>(entity =>
        {
            entity.HasKey(e => e.MaNhaXuatBan).HasName("PK__NhaXuatB__1AED0BFA21B0B732");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NhanVien__77B2CA471624D184");

            entity.HasOne(d => d.MaVaiTroNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaVaiT__3B75D760");

            entity.HasOne(d => d.TenDangNhapNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__TenDan__3C69FB99");
        });

        modelBuilder.Entity<PhieuMuon>(entity =>
        {
            entity.HasKey(e => e.MaPhieuMuon).HasName("PK__PhieuMuo__C4C822222A4386C4");

            entity.HasOne(d => d.MaDocGiaNavigation).WithMany(p => p.PhieuMuons).HasConstraintName("FK__PhieuMuon__MaDoc__440B1D61");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.PhieuMuons).HasConstraintName("FK__PhieuMuon__MaNha__44FF419A");
        });

        modelBuilder.Entity<PhieuPhat>(entity =>
        {
            entity.HasKey(e => e.MaPhieuPhat).HasName("PK__PhieuPha__E874D251DBA58914");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.PhieuPhats).HasConstraintName("FK__PhieuPhat__MaNha__5AEE82B9");

            entity.HasOne(d => d.MaPhieuMuonNavigation).WithMany(p => p.PhieuPhats).HasConstraintName("FK__PhieuPhat__MaPhi__5BE2A6F2");
        });

        modelBuilder.Entity<Phieutra>(entity =>
        {
            entity.HasKey(e => e.MaPhieuTra).HasName("PK__Phieutra__1D880A465B86167B");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.Phieutras).HasConstraintName("FK__Phieutra__MaNhan__48CFD27E");

            entity.HasOne(d => d.MaPhieuMuonNavigation).WithMany(p => p.Phieutras).HasConstraintName("FK__Phieutra__MaPhie__47DBAE45");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742DE166BD87");

            entity.HasOne(d => d.MaNhaXuatBanNavigation).WithMany(p => p.Saches).HasConstraintName("FK__Sach__MaNhaXuatB__5441852A");

            entity.HasOne(d => d.MaTheLoaiNavigation).WithMany(p => p.Saches).HasConstraintName("FK__Sach__MaTheLoai__534D60F1");
        });

        modelBuilder.Entity<TheLoai>(entity =>
        {
            entity.HasKey(e => e.MaTheLoai).HasName("PK__TheLoai__D73FF34AD3BCB43B");
        });

        modelBuilder.Entity<VaiTroNhanVien>(entity =>
        {
            entity.HasKey(e => e.MaVaitro).HasName("PK__VaiTroNh__CA4C49F9E337D660");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
