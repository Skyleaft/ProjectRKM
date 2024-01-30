using Microsoft.EntityFrameworkCore;
using RKM_API.Domain.Siswa;

namespace RKM_API.Entity;

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

    }
    public DbSet<Siswa> Siswa { get; set; }
}
