using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("Phieutra")]
public partial class Phieutra
{
    [Key]
    [StringLength(50)]
    public string MaPhieuTra { get; set; } = null!;

    [StringLength(50)]
    public string? MaPhieuMuon { get; set; }

    [StringLength(50)]
    public string? MaNhanVien { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayLap { get; set; }

    [InverseProperty("MaPhieuTraNavigation")]
    public virtual ICollection<ChiTietPhieutra> ChiTietPhieutras { get; set; } = new List<ChiTietPhieutra>();

    [ForeignKey("MaNhanVien")]
    [InverseProperty("Phieutras")]
    public virtual NhanVien? MaNhanVienNavigation { get; set; }

    [ForeignKey("MaPhieuMuon")]
    [InverseProperty("Phieutras")]
    public virtual PhieuMuon? MaPhieuMuonNavigation { get; set; }
}
