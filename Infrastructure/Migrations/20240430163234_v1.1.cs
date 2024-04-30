using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RKM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "reference");

            migrationBuilder.CreateTable(
                name: "Pekerjaan",
                schema: "reference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaPekerjaan = table.Column<string>(type: "text", nullable: false),
                    Kategori = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pekerjaan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinsi",
                schema: "reference",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    NamaProvinsi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinsi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kota",
                schema: "reference",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ProvinsiId = table.Column<string>(type: "character varying(100)", nullable: true),
                    NamaKota = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kota", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kota_Provinsi_ProvinsiId",
                        column: x => x.ProvinsiId,
                        principalSchema: "reference",
                        principalTable: "Provinsi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kecamatan",
                schema: "reference",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    KotaId = table.Column<string>(type: "character varying(100)", nullable: true),
                    NamaKecamatan = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kecamatan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kecamatan_Kota_KotaId",
                        column: x => x.KotaId,
                        principalSchema: "reference",
                        principalTable: "Kota",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kelurahan",
                schema: "reference",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    KecamatanId = table.Column<string>(type: "character varying(100)", nullable: false),
                    NamaKelurahan = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kelurahan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kelurahan_Kecamatan_KecamatanId",
                        column: x => x.KecamatanId,
                        principalSchema: "reference",
                        principalTable: "Kecamatan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alamat",
                schema: "reference",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KelurahanId = table.Column<string>(type: "character varying(100)", nullable: false),
                    AlamatLengkap = table.Column<string>(type: "text", nullable: false),
                    RT = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    RW = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alamat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alamat_Kelurahan_KelurahanId",
                        column: x => x.KelurahanId,
                        principalSchema: "reference",
                        principalTable: "Kelurahan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrangTua",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaAyah = table.Column<string>(type: "text", nullable: false),
                    NamaIbu = table.Column<string>(type: "text", nullable: false),
                    PekerjaanAyahId = table.Column<int>(type: "integer", nullable: true),
                    PekerjaanIbuId = table.Column<int>(type: "integer", nullable: true),
                    AlamatId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrangTua", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrangTua_Alamat_AlamatId",
                        column: x => x.AlamatId,
                        principalSchema: "reference",
                        principalTable: "Alamat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrangTua_Pekerjaan_PekerjaanAyahId",
                        column: x => x.PekerjaanAyahId,
                        principalSchema: "reference",
                        principalTable: "Pekerjaan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrangTua_Pekerjaan_PekerjaanIbuId",
                        column: x => x.PekerjaanIbuId,
                        principalSchema: "reference",
                        principalTable: "Pekerjaan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Wali",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaWali = table.Column<string>(type: "text", nullable: false),
                    PekerjaanId = table.Column<int>(type: "integer", nullable: true),
                    AlamatId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wali", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wali_Alamat_AlamatId",
                        column: x => x.AlamatId,
                        principalSchema: "reference",
                        principalTable: "Alamat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Wali_Pekerjaan_PekerjaanId",
                        column: x => x.PekerjaanId,
                        principalSchema: "reference",
                        principalTable: "Pekerjaan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Siswa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NIS = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    NISN = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Nama = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Panggilan = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    TempatLahirId = table.Column<string>(type: "character varying(100)", nullable: true),
                    TangalLahir = table.Column<DateOnly>(type: "date", nullable: false),
                    JenisKelamin = table.Column<int>(type: "integer", nullable: false),
                    Agama = table.Column<int>(type: "integer", nullable: false),
                    PendidikanSebelum = table.Column<string>(type: "text", nullable: true),
                    AlamatId = table.Column<long>(type: "bigint", nullable: false),
                    OrangTuaId = table.Column<int>(type: "integer", nullable: true),
                    WaliId = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siswa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siswa_Alamat_AlamatId",
                        column: x => x.AlamatId,
                        principalSchema: "reference",
                        principalTable: "Alamat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siswa_Kota_TempatLahirId",
                        column: x => x.TempatLahirId,
                        principalSchema: "reference",
                        principalTable: "Kota",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Siswa_OrangTua_OrangTuaId",
                        column: x => x.OrangTuaId,
                        principalTable: "OrangTua",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Siswa_Wali_WaliId",
                        column: x => x.WaliId,
                        principalTable: "Wali",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "reference",
                table: "Pekerjaan",
                columns: new[] { "Id", "Kategori", "NamaPekerjaan" },
                values: new object[,]
                {
                    { 1, "BELUM/TIDAK BEKERJA", "BELUM/TIDAK BEKERJA" },
                    { 2, "APARATUR/PEJABAT NEGARA", "PEGAWAI NEGERI SIPIL" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alamat_KelurahanId",
                schema: "reference",
                table: "Alamat",
                column: "KelurahanId");

            migrationBuilder.CreateIndex(
                name: "IX_Kecamatan_KotaId",
                schema: "reference",
                table: "Kecamatan",
                column: "KotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kelurahan_KecamatanId",
                schema: "reference",
                table: "Kelurahan",
                column: "KecamatanId");

            migrationBuilder.CreateIndex(
                name: "IX_Kota_ProvinsiId",
                schema: "reference",
                table: "Kota",
                column: "ProvinsiId");

            migrationBuilder.CreateIndex(
                name: "IX_OrangTua_AlamatId",
                table: "OrangTua",
                column: "AlamatId");

            migrationBuilder.CreateIndex(
                name: "IX_OrangTua_PekerjaanAyahId",
                table: "OrangTua",
                column: "PekerjaanAyahId");

            migrationBuilder.CreateIndex(
                name: "IX_OrangTua_PekerjaanIbuId",
                table: "OrangTua",
                column: "PekerjaanIbuId");

            migrationBuilder.CreateIndex(
                name: "IX_Pekerjaan_NamaPekerjaan",
                schema: "reference",
                table: "Pekerjaan",
                column: "NamaPekerjaan",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Siswa_AlamatId",
                table: "Siswa",
                column: "AlamatId");

            migrationBuilder.CreateIndex(
                name: "IX_Siswa_OrangTuaId",
                table: "Siswa",
                column: "OrangTuaId");

            migrationBuilder.CreateIndex(
                name: "IX_Siswa_TempatLahirId",
                table: "Siswa",
                column: "TempatLahirId");

            migrationBuilder.CreateIndex(
                name: "IX_Siswa_WaliId",
                table: "Siswa",
                column: "WaliId");

            migrationBuilder.CreateIndex(
                name: "IX_Wali_AlamatId",
                table: "Wali",
                column: "AlamatId");

            migrationBuilder.CreateIndex(
                name: "IX_Wali_PekerjaanId",
                table: "Wali",
                column: "PekerjaanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Siswa");

            migrationBuilder.DropTable(
                name: "OrangTua");

            migrationBuilder.DropTable(
                name: "Wali");

            migrationBuilder.DropTable(
                name: "Alamat",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "Pekerjaan",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "Kelurahan",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "Kecamatan",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "Kota",
                schema: "reference");

            migrationBuilder.DropTable(
                name: "Provinsi",
                schema: "reference");
        }
    }
}
