using Infrastructure.Core.Reference;
using Infrastructure.Core.Reference.RefAlamat;

namespace RKM_API.Domain.DataWali;

public class Wali
{
    public int Id { get; set; }
    public string NamaWali { get; set; }
    public Pekerjaan? Pekerjaan { get; set; }
    public Alamat? Alamat { get; set; }
}
