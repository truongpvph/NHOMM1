using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("NhaXuatBan")]
public partial class NhaXuatBan
{
    [Key]
    [StringLength(50)]
    public string MaNhaXuatBan { get; set; } = null!;

    [StringLength(50)]
    public string? TenNhaXuatBan { get; set; }

    [StringLength(50)]
    public string? DiaChi { get; set; }

    [Column("SDT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Sdt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [InverseProperty("MaNhaXuatBanNavigation")]
    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
