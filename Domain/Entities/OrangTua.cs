using RKM.Domain.Entities.Reference;
using RKM.Domain.Entities.Reference.RefAlamat;

namespace RKM.Domain.Entities;

public class OrangTua
{
    public int Id { get; set; }
    public string NamaAyah { get; set; }
    public string NamaIbu { get; set; }
    public Pekerjaan? PekerjaanAyah { get; set; }
    public Pekerjaan? PekerjaanIbu { get; set; }
    public Alamat? Alamat { get; set; }
}
