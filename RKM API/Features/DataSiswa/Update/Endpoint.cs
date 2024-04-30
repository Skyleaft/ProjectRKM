using Microsoft.EntityFrameworkCore;
using RKM.Domain.Entities;
using RKM.Infrastructure.Data;

namespace Features.DataSiswa.Update;

internal sealed class Endpoint : Endpoint<Request, Response, Mapper>
{
    private readonly GenericRepository repo;
    public Endpoint(GenericRepository repo)
    {
        this.repo = repo;
    }
    public override void Configure()
    {
        Put("Siswa/{Id}");
    }

    public override async Task HandleAsync(Request r, CancellationToken c)
    {
        var data = await repo.Siswa.FirstOrDefaultAsync(x=>x.Id == r.Id);
        if(data == null)
        {
            await SendNotFoundAsync(c);
        }
        data = r.Adapt<Siswa>();
        var res = await repo.SaveChangesAsync(c);
        await SendOkAsync(c);
    }
}