using Infrastructure.Core.Enum;
using System.Security.Cryptography.X509Certificates;

namespace RKM_API.Domain.Siswa;

public class Siswa
{
    public int Id { get; set; }
    public string NIS { get; set; }
    public string NISN { get; set; }
    public string Nama { get; set; }
    public string Panggilan { get; set; }
    public string TempatLahir { get; set; }
    public DateOnly TangalLahir { get; set; }
    public JKEnum JenisKelamin { get; set; }

}
