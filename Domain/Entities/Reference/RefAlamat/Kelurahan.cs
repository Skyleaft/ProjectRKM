using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKM.Domain.Entities.Reference.RefAlamat;
[Table("Kelurahan", Schema = "reference")]
public class Kelurahan
{
    [Key]
    [StringLength(100)]
    public string Id { get; set; }
    public Kecamatan Kecamatan { get; set; }
    public string NamaKelurahan { get; set; }
}
