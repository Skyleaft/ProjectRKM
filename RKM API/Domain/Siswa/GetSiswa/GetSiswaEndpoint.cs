using FastEndpoints;
using Mediator;
using Microsoft.EntityFrameworkCore;
using RKM_API.Entity;

namespace RKM_API.Domain.Siswa.GetSiswa;

public class GetSiswaEndpoint : Endpoint<GetSiswaRequest, List<Siswa>>
{
    private readonly GenericRepository repo;
    public GetSiswaEndpoint(GenericRepository repository)
    {
        this.repo = repository;
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

