using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("Sach")]
public partial class Sach
{
    [Key]
    [StringLength(50)]
    public string MaSach { get; set; } = null!;

    [StringLength(50)]
    public string? MaTheLoai { get; set; }

    [StringLength(50)]
    public string? MaNhaXuatBan { get; set; }

    [StringLength(50)]
    public string? TenSach { get; set; }

    public int? GiaSach { get; set; }

    public int? SoLuong { get; set; }

    [StringLength(50)]
    public string? TrangThaiSach { get; set; }

    public DateOnly? NgayNhap { get; set; }

    [StringLength(50)]
    public string? MoTa { get; set; }

    [StringLength(50)]
    public string? ViTri { get; set; }

    [InverseProperty("MaSachNavigation")]
    public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = new List<ChiTietPhieuMuon>();

    [ForeignKey("MaNhaXuatBan")]
    [InverseProperty("Saches")]
    public virtual NhaXuatBan? MaNhaXuatBanNavigation { get; set; }

    [ForeignKey("MaTheLoai")]
    [InverseProperty("Saches")]
    public virtual TheLoai? MaTheLoaiNavigation { get; set; }
}
