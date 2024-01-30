using Infrastructure.Core.Enum;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace RKM_API.Domain.Siswa;

public class Siswa
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(30, ErrorMessage = "The value cannot exceed 30 characters. And Less than 5"), MinLength(5)]
    public string NIS { get; set; }
    public string? NISN { get; set; }
    [Required]
    [StringLength(35, ErrorMessage = "The value cannot exceed 30 characters. And Less than 3"), MinLength(3)]
    public string Nama { get; set; }
    public string? Panggilan { get; set; }
    public string? TempatLahir { get; set; }
    public DateTime TangalLahir { get; set; }
    public JKEnum JenisKelamin { get; set; }

}
