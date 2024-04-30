using RKM.Domain.Entities.Reference.RefAlamat;
using RKM.Domain.Entities;
using RKM.Domain.Shared;
using FluentValidation;

namespace Features.DataSiswa.Update;

internal class Request
{
    public int Id { get; set; }
    public string NIS { get; set; }
    public string? NISN { get; set; }
    public string Nama { get; set; }
    public string? Panggilan { get; set; }
    public string? TempatLahirId { get; set; }
    public DateOnly TangalLahir { get; set; }
    public JenisKelamin JenisKelamin { get; set; }
    public Agama Agama { get; set; }
    public string? PendidikanSebelum { get; set; }
    public virtual Alamat Alamat { get; set; }
    public virtual OrangTua? OrangTua { get; set; }
    public virtual Wali? Wali { get; set; }
}

internal sealed class Validator : Validator<Request>
{
    public Validator()
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

internal sealed class Response
{
    public int AffectedRow { get; set; }
}
