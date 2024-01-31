using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Core.Reference.RefAlamat;
[Table("Kecamatan", Schema = "reference")]
public class Kecamatan
{
    [Key]
    [StringLength(100)]
    public string Id { get; set; }
    public Kota Kota { get; set; }
    public string NamaKecamatan { get; set; }
}
