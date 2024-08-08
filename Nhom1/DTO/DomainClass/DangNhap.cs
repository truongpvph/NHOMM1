using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

[Table("DangNhap")]
public partial class DangNhap
{
    [Key]
    [StringLength(50)]
    public string TenDangNhap { get; set; } = null!;

    [StringLength(50)]
    public string? MatKhau { get; set; }

    [InverseProperty("TenDangNhapNavigation")]
    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
