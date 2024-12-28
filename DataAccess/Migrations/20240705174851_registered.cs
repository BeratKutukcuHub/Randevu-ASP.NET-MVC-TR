using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class registered : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    EntityDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.EntityDepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    EntityAppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityDepartmentId = table.Column<int>(type: "int", nullable: false),
                    EntitySectionId = table.Column<int>(type: "int", nullable: false),
                    DateInAppointment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.EntityAppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Departments_EntityDepartmentId",
                        column: x => x.EntityDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "EntityDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    EntitySectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityDepartmentId = table.Column<int>(type: "int", nullable: false),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.EntitySectionId);
                    table.ForeignKey(
                        name: "FK_Sections_Departments_EntityDepartmentId",
                        column: x => x.EntityDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "EntityDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    EntityPersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntitySectionId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(name: "E_Mail", type: "nvarchar(max)", nullable: true),
                    SocialMedia1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMedia2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.EntityPersonId);
                    table.ForeignKey(
                        name: "FK_Persons_Sections_EntitySectionId",
                        column: x => x.EntitySectionId,
                        principalTable: "Sections",
                        principalColumn: "EntitySectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0099d4fe-0468-40d1-9684-b4591f910f40", null, "Admin", "ADMIN" },
                    { "387a9458-2af5-499e-ad97-633da73bb712", null, "Personal", "PERSONAL" },
                    { "e1389997-a8bb-4edb-85ec-4c58aa6fa38b", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "EntityDepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Dahiliye (İç Hastalıkları)" },
                    { 2, "Genel Cerrahi" },
                    { 3, "Kadın Doğum (Obstetrik ve Jinekoloji)" },
                    { 4, "Radyoloji" },
                    { 5, "Pediatri (Çocuk Sağlığı ve Hastalıkları)" },
                    { 6, "Göz Hastalıkları (Oftalmoloji)" },
                    { 7, "Kulak Burun Boğaz (KBB)" },
                    { 8, "Nöroloji" },
                    { 9, "Ortopedi" },
                    { 10, "Psikiyatri" },
                    { 11, "Oral ve Diş Sağlığı" },
                    { 12, "Fizyoterapi ve Rehabilitasyon" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "EntitySectionId", "EntityDepartmentId", "SectionName" },
                values: new object[,]
                {
                    { 1, 1, "Kardiyoloji" },
                    { 2, 1, "Gastroenteroloji" },
                    { 3, 1, "Nefroloji" },
                    { 4, 1, "Endokrinoloji" },
                    { 5, 1, "Pulmonoloji" },
                    { 6, 1, "Hematoloji" },
                    { 7, 2, "Kolon ve Rektum Cerrahisi" },
                    { 8, 2, "Gastrointestinal Cerrahi" },
                    { 9, 2, "Meme Cerrahisi" },
                    { 10, 2, "Tiroid ve Paratiroid Cerrahisi" },
                    { 11, 2, "Yara Bakımı ve Travma Cerrahisi" },
                    { 12, 3, "Obstetrik (Doğum Bilimi)" },
                    { 13, 3, "Jinekoloji" },
                    { 14, 4, "Röntgen" },
                    { 15, 4, "Bilgisayarlı Tomografi (BT)" },
                    { 16, 4, "Manyetik Rezonans Görüntüleme (MR)" },
                    { 17, 4, "Ultrasonografi (USG)" },
                    { 18, 4, "Nükleer Tıp (Sintigrafi)" },
                    { 19, 5, "Genel Pediatri" },
                    { 20, 5, "Neonatoloji" },
                    { 21, 5, "Çocuk Enfeksiyon Hastalıkları" },
                    { 22, 5, "Çocuk Nefrolojisi" },
                    { 23, 5, "Çocuk Kardiyolojisi" },
                    { 24, 5, "Çocuk Endokrinolojisi" },
                    { 25, 5, "Çocuk Psikiyatrisi" },
                    { 26, 6, "Genel Oftalmoloji" },
                    { 27, 6, "Katarakt Cerrahisi" },
                    { 28, 6, "Retina ve Vitreus Hastalıkları" },
                    { 29, 6, "Kornea Hastalıkları ve Kornea Transplantasyonu" },
                    { 30, 6, "Glaukom (Göz Tansiyonu) Tedavisi" },
                    { 31, 6, "Pediyatrik Oftalmoloji" },
                    { 32, 6, "Plastik ve Rekonstrüktif Göz Cerrahisi" },
                    { 33, 6, "Üveit (Göz İçi İltihabı) Tedavisi" },
                    { 34, 6, "Orbita ve Oküloplasti" },
                    { 35, 7, "Kulak Hastalıkları" },
                    { 36, 7, "Burun ve Sinüs Hastalıkları" },
                    { 37, 7, "Boğaz Hastalıkları" },
                    { 38, 7, "Baş ve Boyun Cerrahisi" },
                    { 39, 7, "Çocuklar için Kulak Burun Boğaz" },
                    { 40, 8, "Baş Ağrıları ve Migren Tedavisi" },
                    { 41, 8, "Epilepsi ve Nöbet Bozuklukları" },
                    { 42, 8, "Nöromüsküler Hastalıklar" },
                    { 43, 8, "İnme (Stroke)" },
                    { 44, 8, "Hareket Bozuklukları" },
                    { 45, 8, "Demyelinizan Hastalıklar" },
                    { 46, 8, "Nöroonkoloji" },
                    { 47, 8, "Nöroimmünoloji" },
                    { 48, 8, "Nörofizyoloji" },
                    { 49, 9, "Artroplasti (Eklem Protezi)" },
                    { 50, 9, "Travmatoloji" },
                    { 51, 9, "Pediatrik Ortopedi" },
                    { 52, 9, "Omurga Cerrahisi" },
                    { 53, 9, "El ve Üst Ekstremite Cerrahisi" },
                    { 54, 9, "Ayak ve Ayak Bileği Cerrahisi" },
                    { 55, 9, "Ortopedik Onkoloji" },
                    { 56, 9, "Ortopedik Rehabilitasyon" },
                    { 57, 10, "Genel Psikiyatri" },
                    { 58, 10, "Çocuk ve Ergen Psikiyatrisi" },
                    { 59, 10, "Bağımlılık Psikiyatrisi" },
                    { 60, 10, "Ruhsal Sağlık ve Psikoterapi" },
                    { 61, 10, "Klinik Psikofarmakoloji" },
                    { 62, 10, "Acil Psikiyatri" },
                    { 63, 10, "Geropsikiyatri" },
                    { 64, 10, "Adli Psikiyatri" },
                    { 65, 11, "Genel Diş Hekimliği" },
                    { 66, 11, "Periodontoloji" },
                    { 67, 11, "Endodonti" },
                    { 68, 11, "Ortodonti" },
                    { 69, 11, "Oral ve Maksillofasiyal Cerrahi" },
                    { 70, 11, "Prostodonti" },
                    { 71, 11, "Estetik Diş Hekimliği" },
                    { 72, 12, "Ortopedik Fizyoterapi" },
                    { 73, 12, "Nörolojik Fizyoterapi" },
                    { 74, 12, "Kardiyopulmoner Fizyoterapi" },
                    { 75, 12, "Pediyatrik Fizyoterapi" },
                    { 76, 12, "Geriyatrik Fizyoterapi" },
                    { 77, 12, "Spor Fizyoterapisi" },
                    { 78, 12, "Fiziksel Tıp ve Rehabilitasyon" },
                    { 79, 12, "Onkolojik Fizyoterapi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_EntityDepartmentId",
                table: "Appointments",
                column: "EntityDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_EntitySectionId",
                table: "Persons",
                column: "EntitySectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_EntityDepartmentId",
                table: "Sections",
                column: "EntityDepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
