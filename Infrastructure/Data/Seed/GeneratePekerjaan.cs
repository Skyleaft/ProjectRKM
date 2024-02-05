using RKM.Domain.Entities.Reference;

namespace RKM.Infrastructure.Data.Seed;

public static class GeneratePekerjaan
{
    public static List<Pekerjaan> Set()
    {
        return new List<Pekerjaan>
        {
            new Pekerjaan(1,"BELUM/TIDAK BEKERJA","BELUM/TIDAK BEKERJA"),
            new Pekerjaan(2,"PEGAWAI NEGERI SIPIL","APARATUR/PEJABAT NEGARA"),

        };

    }
}
