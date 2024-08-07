using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("PhieuMuon")]
public partial class PhieuMuon
{
    [Key]
    [StringLength(50)]
    public string MaPhieuMuon { get; set; } = null!;

    [StringLength(50)]
    public string? MaDocGia { get; set; }

    [StringLength(50)]
    public string? MaNhanVien { get; set; }

    public DateOnly? NgayLapPhieuMuon { get; set; }

    [InverseProperty("MaPhieuMuonNavigation")]
    public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = new List<ChiTietPhieuMuon>();

    [ForeignKey("MaDocGia")]
    [InverseProperty("PhieuMuons")]
    public virtual DocGium? MaDocGiaNavigation { get; set; }

    [ForeignKey("MaNhanVien")]
    [InverseProperty("PhieuMuons")]
    public virtual NhanVien? MaNhanVienNavigation { get; set; }

    [InverseProperty("MaPhieuMuonNavigation")]
    public virtual ICollection<PhieuPhat> PhieuPhats { get; set; } = new List<PhieuPhat>();

    [InverseProperty("MaPhieuMuonNavigation")]
    public virtual ICollection<Phieutra> Phieutras { get; set; } = new List<Phieutra>();
}
