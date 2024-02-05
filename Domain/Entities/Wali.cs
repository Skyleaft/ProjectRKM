using RKM.Domain.Entities.Reference;
using RKM.Domain.Entities.Reference.RefAlamat;

namespace RKM.Domain.Entities;

public class Wali
{
    public int Id { get; set; }
    public string NamaWali { get; set; }
    public Pekerjaan? Pekerjaan { get; set; }
    public Alamat? Alamat { get; set; }
}
