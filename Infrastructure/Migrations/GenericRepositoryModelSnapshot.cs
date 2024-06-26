﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RKM.Infrastructure.Data;

#nullable disable

namespace RKM.Infrastructure.Migrations
{
    [DbContext(typeof(GenericRepository))]
    partial class GenericRepositoryModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RKM.Domain.Entities.OrangTua", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long?>("AlamatId")
                        .HasColumnType("bigint");

                    b.Property<string>("NamaAyah")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NamaIbu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PekerjaanAyahId")
                        .HasColumnType("integer");

                    b.Property<int?>("PekerjaanIbuId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AlamatId");

                    b.HasIndex("PekerjaanAyahId");

                    b.HasIndex("PekerjaanIbuId");

                    b.ToTable("OrangTua");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Reference.Pekerjaan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Kategori")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NamaPekerjaan")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NamaPekerjaan")
                        .IsUnique();

                    b.ToTable("Pekerjaan", "reference");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Kategori = "BELUM/TIDAK BEKERJA",
                            NamaPekerjaan = "BELUM/TIDAK BEKERJA"
                        },
                        new
                        {
                            Id = 2,
                            Kategori = "APARATUR/PEJABAT NEGARA",
                            NamaPekerjaan = "PEGAWAI NEGERI SIPIL"
                        });
                });

            modelBuilder.Entity("RKM.Domain.Entities.Reference.RefAlamat.Alamat", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("AlamatLengkap")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KelurahanId")
                        .IsRequired()
                        .HasColumnType("character varying(100)");

                    b.Property<string>("RT")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)");

                    b.Property<string>("RW")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)");

                    b.HasKey("Id");

                    b.HasIndex("KelurahanId");

                    b.ToTable("Alamat", "reference");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Reference.RefAlamat.Kecamatan", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("KotaId")
                        .HasColumnType("character varying(100)");

                    b.Property<string>("NamaKecamatan")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KotaId");

                    b.ToTable("Kecamatan", "reference");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Reference.RefAlamat.Kelurahan", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("KecamatanId")
                        .IsRequired()
                        .HasColumnType("character varying(100)");

                    b.Property<string>("NamaKelurahan")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KecamatanId");

                    b.ToTable("Kelurahan", "reference");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Reference.RefAlamat.Kota", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("NamaKota")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProvinsiId")
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("ProvinsiId");

                    b.ToTable("Kota", "reference");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Reference.RefAlamat.Provinsi", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("NamaProvinsi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Provinsi", "reference");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Siswa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Agama")
                        .HasColumnType("integer");

                    b.Property<long>("AlamatId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<int>("JenisKelamin")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("NIS")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("NISN")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<int?>("OrangTuaId")
                        .HasColumnType("integer");

                    b.Property<string>("Panggilan")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("PendidikanSebelum")
                        .HasColumnType("text");

                    b.Property<DateOnly>("TangalLahir")
                        .HasColumnType("date");

                    b.Property<string>("TempatLahirId")
                        .HasColumnType("character varying(100)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.Property<int?>("WaliId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AlamatId");

                    b.HasIndex("OrangTuaId");

                    b.HasIndex("TempatLahirId");

                    b.HasIndex("WaliId");

                    b.ToTable("Siswa");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Wali", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long?>("AlamatId")
                        .HasColumnType("bigint");

                    b.Property<string>("NamaWali")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PekerjaanId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AlamatId");

                    b.HasIndex("PekerjaanId");

                    b.ToTable("Wali");
                });

            modelBuilder.Entity("RKM.Domain.Entities.OrangTua", b =>
                {
                    b.HasOne("RKM.Domain.Entities.Reference.RefAlamat.Alamat", "Alamat")
                        .WithMany()
                        .HasForeignKey("AlamatId");

                    b.HasOne("RKM.Domain.Entities.Reference.Pekerjaan", "PekerjaanAyah")
                        .WithMany()
                        .HasForeignKey("PekerjaanAyahId");

                    b.HasOne("RKM.Domain.Entities.Reference.Pekerjaan", "PekerjaanIbu")
                        .WithMany()
                        .HasForeignKey("PekerjaanIbuId");

                    b.Navigation("Alamat");

                    b.Navigation("PekerjaanAyah");

                    b.Navigation("PekerjaanIbu");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Reference.RefAlamat.Alamat", b =>
                {
                    b.HasOne("RKM.Domain.Entities.Reference.RefAlamat.Kelurahan", "Kelurahan")
                        .WithMany()
                        .HasForeignKey("KelurahanId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Kelurahan");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Reference.RefAlamat.Kecamatan", b =>
                {
                    b.HasOne("RKM.Domain.Entities.Reference.RefAlamat.Kota", "Kota")
                        .WithMany()
                        .HasForeignKey("KotaId");

                    b.Navigation("Kota");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Reference.RefAlamat.Kelurahan", b =>
                {
                    b.HasOne("RKM.Domain.Entities.Reference.RefAlamat.Kecamatan", "Kecamatan")
                        .WithMany()
                        .HasForeignKey("KecamatanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kecamatan");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Reference.RefAlamat.Kota", b =>
                {
                    b.HasOne("RKM.Domain.Entities.Reference.RefAlamat.Provinsi", "Provinsi")
                        .WithMany()
                        .HasForeignKey("ProvinsiId");

                    b.Navigation("Provinsi");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Siswa", b =>
                {
                    b.HasOne("RKM.Domain.Entities.Reference.RefAlamat.Alamat", "Alamat")
                        .WithMany()
                        .HasForeignKey("AlamatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RKM.Domain.Entities.OrangTua", "OrangTua")
                        .WithMany()
                        .HasForeignKey("OrangTuaId");

                    b.HasOne("RKM.Domain.Entities.Reference.RefAlamat.Kota", "TempatLahir")
                        .WithMany()
                        .HasForeignKey("TempatLahirId");

                    b.HasOne("RKM.Domain.Entities.Wali", "Wali")
                        .WithMany()
                        .HasForeignKey("WaliId");

                    b.Navigation("Alamat");

                    b.Navigation("OrangTua");

                    b.Navigation("TempatLahir");

                    b.Navigation("Wali");
                });

            modelBuilder.Entity("RKM.Domain.Entities.Wali", b =>
                {
                    b.HasOne("RKM.Domain.Entities.Reference.RefAlamat.Alamat", "Alamat")
                        .WithMany()
                        .HasForeignKey("AlamatId");

                    b.HasOne("RKM.Domain.Entities.Reference.Pekerjaan", "Pekerjaan")
                        .WithMany()
                        .HasForeignKey("PekerjaanId");

                    b.Navigation("Alamat");

                    b.Navigation("Pekerjaan");
                });
#pragma warning restore 612, 618
        }
    }
}
