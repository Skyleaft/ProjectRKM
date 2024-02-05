using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RKM.Domain.Entities;
using RKM.Domain.Entities.Reference;
using RKM.Domain.Entities.Reference.RefAlamat;
using RKM.Infrastructure.Data.Seed;

namespace RKM.Infrastructure.Data;

public class GenericRepository : DbContext
{
    protected readonly IConfiguration Configuration;
    public GenericRepository(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        //SQL Server Connection
        //options.UseSqlServer(Configuration.GetConnectionString("DefaultSQLCON"));
        //PGSQL Connection
        options.UseNpgsql(Configuration.GetConnectionString("PGSQLConnection"));

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pekerjaan>().HasData(GeneratePekerjaan.Set());
        modelBuilder.Entity<Alamat>()
            .HasOne(e => e.Kelurahan)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }
    #region CoreDB
    public DbSet<Provinsi> Provinsi { get; set; }
    public DbSet<Kota> Kota { get; set; }
    public DbSet<Kecamatan> Kecamatan { get; set; }
    public DbSet<Kelurahan> Kelurahan { get; set; }
    public DbSet<Alamat> Alamat { get; set; }
    public DbSet<Pekerjaan> Pekerjaan { get; set; }
    #endregion

    public DbSet<Siswa> Siswa { get; set; }
    public DbSet<Wali> Wali { get; set; }
    public DbSet<OrangTua> OrangTua { get; set; }

}
