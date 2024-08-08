using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("ChiTietPhieuMuon")]
public partial class ChiTietPhieuMuon
{
    [Key]
    [StringLength(50)]
    public string MaChiTietPhieuMuon { get; set; } = null!;

    [StringLength(50)]
    public string? MaSach { get; set; }

    [StringLength(50)]
    public string? MaPhieuMuon { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HanTra { get; set; }

    public int? SoLuong { get; set; }

    [ForeignKey("MaPhieuMuon")]
    [InverseProperty("ChiTietPhieuMuons")]
    public virtual PhieuMuon? MaPhieuMuonNavigation { get; set; }

    [ForeignKey("MaSach")]
    [InverseProperty("ChiTietPhieuMuons")]
    public virtual Sach? MaSachNavigation { get; set; }
}
