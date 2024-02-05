using FastEndpoints;
using Mapster;
using RKM.Domain.Entities;
using RKM.Infrastructure.Data;

namespace RKM_API.DomainEvents.DataSiswa.CreateSiswa;

public class CreateSiswaEndpoint : Endpoint<CreateSiswaRequest, string>
{
    private readonly GenericRepository repo;
    public CreateSiswaEndpoint(GenericRepository repository)
    {
        repo = repository;
    }
    public override void Configure()
    {
        Post("/api/siswa/");
        AllowAnonymous();
    }
    public override async Task HandleAsync(CreateSiswaRequest req, CancellationToken ct)
    {
        await repo.Siswa.AddAsync(req.Adapt<Siswa>(), ct);
        var res = await repo.SaveChangesAsync(ct);
        await SendAsync(res.ToString());
    }
}

