using Infrastructure.Core.Reference;
using Infrastructure.Core.Reference.RefAlamat;

namespace RKM_API.Domain.DataOrangTua;

public class OrangTua
{
    public int Id { get; set; }
    public string NamaAyah { get; set; }
    public string NamaIbu { get; set; }
    public Pekerjaan? PekerjaanAyah { get; set; }
    public Pekerjaan? PekerjaanIbu { get; set; }
    public Alamat? Alamat {  get; set; }
}
