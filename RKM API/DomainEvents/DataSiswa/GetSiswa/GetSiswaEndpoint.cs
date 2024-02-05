using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using RKM.Domain.Entities;
using RKM.Infrastructure.Data;

namespace RKM_API.DomainEvents.DataSiswa.GetSiswa;

public class GetSiswaEndpoint : Endpoint<GetSiswaRequest, List<Siswa>>
{
    private readonly GenericRepository repo;
    public GetSiswaEndpoint(GenericRepository repository)
    {
        repo = repository;
    }
    public override void Configure()
    {
        Get("/api/siswa/");
        AllowAnonymous();
    }
    public override async Task HandleAsync(GetSiswaRequest req, CancellationToken ct)
    {
        var res = await repo.Siswa.ToListAsync();
        await SendAsync(res);
    }
}

