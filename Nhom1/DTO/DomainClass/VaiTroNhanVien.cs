using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("VaiTroNhanVien")]
public partial class VaiTroNhanVien
{
    [Key]
    [StringLength(50)]
    public string MaVaitro { get; set; } = null!;

    [StringLength(50)]
    public string? TenVaiTro { get; set; }

    [InverseProperty("MaVaiTroNavigation")]
    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
