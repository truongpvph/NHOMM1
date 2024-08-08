using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("ChiTietPhieutra")]
public partial class ChiTietPhieutra
{
    [Key]
    [StringLength(50)]
    public string MaPhieuTraChiTiet { get; set; } = null!;

    [StringLength(50)]
    public string? MaPhieuTra { get; set; }

    [StringLength(50)]
    public string? MaDocGia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgayTra { get; set; }

    [ForeignKey("MaDocGia")]
    [InverseProperty("ChiTietPhieutras")]
    public virtual DocGium? MaDocGiaNavigation { get; set; }

    [ForeignKey("MaPhieuTra")]
    [InverseProperty("ChiTietPhieutras")]
    public virtual Phieutra? MaPhieuTraNavigation { get; set; }
}
