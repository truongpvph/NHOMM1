using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("PhieuPhat")]
public partial class PhieuPhat
{
    [Key]
    [StringLength(50)]
    public string MaPhieuPhat { get; set; } = null!;

    [StringLength(50)]
    public string? MaNhanVien { get; set; }

    [StringLength(50)]
    public string? MaPhieuMuon { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayLapPhieuPhat { get; set; }

    [InverseProperty("MaPhieuPhatNavigation")]
    public virtual ICollection<ChiTietPhieuPhat> ChiTietPhieuPhats { get; set; } = new List<ChiTietPhieuPhat>();

    [ForeignKey("MaNhanVien")]
    [InverseProperty("PhieuPhats")]
    public virtual NhanVien? MaNhanVienNavigation { get; set; }

    [ForeignKey("MaPhieuMuon")]
    [InverseProperty("PhieuPhats")]
    public virtual PhieuMuon? MaPhieuMuonNavigation { get; set; }
}
