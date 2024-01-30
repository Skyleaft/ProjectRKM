using Infrastructure.Core.Enum;

namespace RKM_API.Domain.Siswa.CreateSiswa;

public class CreateSiswaRequest
{
    public string NIS { get; set; }
    public string NISN { get; set; }
    public string Nama { get; set; }
    public string Panggilan { get; set; }
    public string TempatLahir { get; set; }
    public DateTime TangalLahir { get; set; }
    public JKEnum JenisKelamin { get; set; }

}
