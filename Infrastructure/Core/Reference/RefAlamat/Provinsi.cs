using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Core.Reference.RefAlamat;
[Table("Provinsi", Schema = "reference")]
public class Provinsi
{
    [Key]
    [StringLength(100)]
    public string Id { get; set; }
    public string NamaProvinsi { get; set; }
}
