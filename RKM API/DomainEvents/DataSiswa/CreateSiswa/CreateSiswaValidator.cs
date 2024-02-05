using FastEndpoints;
using FluentValidation;

namespace RKM_API.DomainEvents.DataSiswa.CreateSiswa;

public class CreateSiswaValidator : Validator<CreateSiswaRequest>
{
    public CreateSiswaValidator()
    {
        RuleFor(x => x.Nama)
            .NotEmpty()
            .MaximumLength(60)
            .MinimumLength(2);
        RuleFor(x => x.NIS).NotEmpty();
        RuleFor(x => x.TempatLahirId).NotNull();
        RuleFor(x => x.JenisKelamin).NotNull();
        RuleFor(x => x.Agama).NotNull();
        RuleFor(x => x.Alamat).NotNull();
    }
}
