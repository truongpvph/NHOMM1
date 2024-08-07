using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

public partial class LoaiDocGium
{
    [Key]
    [StringLength(50)]
    public string MaLoaiDocGia { get; set; } = null!;

    [StringLength(50)]
    public string? TenLoaiDocGia { get; set; }

    public int? SoSachMuonToiDa { get; set; }

    public int? NgayMuonToiDa { get; set; }

    [InverseProperty("LoaiDocGiaNavigation")]
    public virtual ICollection<DocGium> DocGia { get; set; } = new List<DocGium>();
}
