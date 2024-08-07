using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("ChiTietPhieuPhat")]
public partial class ChiTietPhieuPhat
{
    [Key]
    [StringLength(50)]
    public string MaChiTietPhieuPhat { get; set; } = null!;

    [StringLength(50)]
    public string? MaPhieuPhat { get; set; }

    public int? SoNgayQuaHan { get; set; }

    public int? SoTienPhat { get; set; }

    [ForeignKey("MaPhieuPhat")]
    [InverseProperty("ChiTietPhieuPhats")]
    public virtual PhieuPhat? MaPhieuPhatNavigation { get; set; }
}
