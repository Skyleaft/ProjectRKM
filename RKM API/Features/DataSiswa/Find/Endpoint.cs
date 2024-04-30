using Mapster;
using RKM.Infrastructure.Data;
using RKM.Infrastructure.Extensions;

namespace Features.DataSiswa.Find;

internal sealed class Endpoint : Endpoint<Request, Response>
{
    private readonly GenericRepository repo;
    public Endpoint(GenericRepository repo)
    {
        this.repo = repo;
    }
    public override void Configure()
    {
        Post("siswa/find");
    }

    public override async Task HandleAsync(Request r, CancellationToken c)
    {
        var data = await repo.Siswa.ToPaginatedListAsync(r.Page, r.PageSize);
        await SendAsync(data.Adapt<Response>());
    }
}