using FastEndpoints;
using FluentValidation;

namespace RKM_API.Domain.Siswa.CreateSiswa;

public class CreateSiswaValidator: Validator<CreateSiswaRequest>
{
    public CreateSiswaValidator()
    {
        RuleFor(x => x.Nama)
            .NotEmpty()
            .MaximumLength(35)
            .MinimumLength(3);
    }
}
