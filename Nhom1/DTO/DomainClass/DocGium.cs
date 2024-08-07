using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DTO.DomainClass;

public partial class DocGium
{
    [Key]
    [StringLength(50)]
    public string MaDocGia { get; set; } = null!;

    [StringLength(50)]
    public string? TenDocGia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NgaySinh { get; set; }

    [StringLength(50)]
    public string? DiaChi { get; set; }

    [StringLength(50)]
    public string? Email { get; set; }

    [Column("CMND")]
    [StringLength(50)]
    public string? Cmnd { get; set; }

    [Column("SDT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Sdt { get; set; }

    [StringLength(50)]
    public string? LoaiDocGia { get; set; }

    [InverseProperty("MaDocGiaNavigation")]
    public virtual ICollection<ChiTietPhieutra> ChiTietPhieutras { get; set; } = new List<ChiTietPhieutra>();

    [ForeignKey("LoaiDocGia")]
    [InverseProperty("DocGia")]
    public virtual LoaiDocGium? LoaiDocGiaNavigation { get; set; }

    [InverseProperty("MaDocGiaNavigation")]
    public virtual ICollection<PhieuMuon> PhieuMuons { get; set; } = new List<PhieuMuon>();
}
