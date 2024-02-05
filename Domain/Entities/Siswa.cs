using RKM.Domain.Entities.Reference.RefAlamat;
using RKM.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKM.Domain.Entities;

public class Siswa
{
    public int Id { get; set; }
    [StringLength(10), MinLength(10)]
    public string NIS { get; set; }
    [StringLength(10), MinLength(10)]
    public string? NISN { get; set; }
    [StringLength(60), MinLength(2)]
    public string Nama { get; set; }
    [StringLength(30), MinLength(2)]
    public string? Panggilan { get; set; }
    public string? TempatLahirId { get; set; }
    public virtual Kota? TempatLahir { get; set; }
    public DateOnly TangalLahir { get; set; }
    public JenisKelamin JenisKelamin { get; set; }
    public Agama Agama { get; set; }
    public string? PendidikanSebelum { get; set; }
    public virtual Alamat Alamat { get; set; }
    public virtual OrangTua? OrangTua { get; set; }
    public virtual Wali? Wali { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
    public string? CreatedBy { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? LastUpdated { get; set; } = DateTime.Now;
    public string? UpdatedBy { get; set; }
}
