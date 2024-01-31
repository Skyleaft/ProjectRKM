using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Core.Reference;

[Index(nameof(NamaPekerjaan), IsUnique = true)]
[Table("Pekerjaan", Schema = "reference")]
public class Pekerjaan
{
    public Pekerjaan(int id, string namaPekerjaan, string kategori)
    {
        Id = id;
        NamaPekerjaan = namaPekerjaan;
        Kategori = kategori;
    }
    public Pekerjaan() { }

    public int Id { get; set; }
    public string NamaPekerjaan { get; set; }
    public string Kategori { get; set; }
}
