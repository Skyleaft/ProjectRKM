
using RKM.Domain.Entities;
using RKM.Infrastructure.Extensions;

namespace Features.DataSiswa.Find;

internal sealed class Request : FindRequest
{

}

internal sealed class Validator : Validator<Request>
{
    public Validator()
    {

    }
}

internal sealed class Response : PaginatedResponse<Siswa>
{

}
