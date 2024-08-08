using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("NhanVien")]
public partial class NhanVien
{
    [Key]
    [StringLength(50)]
    public string MaNhanVien { get; set; } = null!;

    public int? CaTruc { get; set; }

    [StringLength(50)]
    public string? TenDangNhap { get; set; }

    [StringLength(50)]
    public string? HoTen { get; set; }

    [StringLength(50)]
    public string? MaVaiTro { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SoDienThoai { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgaySinh { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaiKhoan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MatKhau { get; set; }

    [Column("SoCCCD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SoCccd { get; set; }

    [ForeignKey("MaVaiTro")]
    [InverseProperty("NhanViens")]
    public virtual VaiTroNhanVien? MaVaiTroNavigation { get; set; }

    [InverseProperty("MaNhanVienNavigation")]
    public virtual ICollection<PhieuMuon> PhieuMuons { get; set; } = new List<PhieuMuon>();

    [InverseProperty("MaNhanVienNavigation")]
    public virtual ICollection<PhieuPhat> PhieuPhats { get; set; } = new List<PhieuPhat>();

    [InverseProperty("MaNhanVienNavigation")]
    public virtual ICollection<Phieutra> Phieutras { get; set; } = new List<Phieutra>();

    [ForeignKey("TenDangNhap")]
    [InverseProperty("NhanViens")]
    public virtual DangNhap? TenDangNhapNavigation { get; set; }
}
