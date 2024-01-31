using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Core.Reference.RefAlamat;

[Table("Alamat", Schema = "reference")]
public class Alamat
{
    public long Id { get; set; }
    public string KelurahanId { get; set; }
    public Kelurahan? Kelurahan { get; set; }
    public string AlamatLengkap { get; set; }
    [StringLength(4), MinLength(0)]
    public string RT {  get; set; }
    [StringLength(4), MinLength(0)]
    public string RW { get; set; }

}
