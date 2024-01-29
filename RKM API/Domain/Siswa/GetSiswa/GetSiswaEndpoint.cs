using FastEndpoints;
using Mediator;

namespace RKM_API.Domain.Siswa.GetSiswa;

public class GetSiswaEndpoint : Endpoint<GetSiswaRequest, Siswa>
{
    public override void Configure()
    {
        Get("/api/siswa/");
    }
    public override async Task HandleAsync(GetSiswaRequest req, CancellationToken ct)
    {
        await SendAsync(new()
        {
            
        });
    }
}

