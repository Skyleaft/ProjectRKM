
using RKM.Domain.Entities;
using RKM.Infrastructure.Data;

namespace Features.DataSiswa.Insert;

internal sealed class Endpoint : Endpoint<Request, Response, Mapper>
{
    private readonly GenericRepository repo;
    public Endpoint(GenericRepository repo)
    {
        this.repo = repo;
    }
    public override void Configure()
    {
        Post("siswa");
    }

    public override async Task HandleAsync(Request r, CancellationToken c)
    {
        var data = r.Adapt<Siswa>();
        await repo.Siswa.AddAsync(data, c);
        var res = await repo.SaveChangesAsync(c);
        await SendCreatedAtAsync($"siswa/{data.Id}", data, new Response
        {
            AffectedRow = res,
            Id = data.Id
        });
    }
}