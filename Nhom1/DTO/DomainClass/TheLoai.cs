using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("TheLoai")]
public partial class TheLoai
{
    [Key]
    [StringLength(50)]
    public string MaTheLoai { get; set; } = null!;

    [StringLength(50)]
    public string? TenTheLoai { get; set; }

    [InverseProperty("MaTheLoaiNavigation")]
    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
