﻿using Infrastructure.Core.Enum;
using Infrastructure.Core.Reference.RefAlamat;
using RKM_API.Domain.DataOrangTua;
using RKM_API.Domain.DataWali;
using System.ComponentModel.DataAnnotations;

namespace RKM_API.Domain.Siswa.CreateSiswa;

public class CreateSiswaRequest
{
    [StringLength(10), MinLength(10)]
    public string NIS { get; set; }
    [StringLength(10), MinLength(10)]
    public string? NISN { get; set; }
    [StringLength(60), MinLength(2)]
    public string Nama { get; set; }
    [StringLength(30), MinLength(2)]
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
