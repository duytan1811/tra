using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travel_ASP.Migrations
{
    public partial class InititalDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvinceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true, defaultValue: 256),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    MinPeople = table.Column<int>(type: "int", nullable: true),
                    MaxPeople = table.Column<int>(type: "int", nullable: true),
                    DayCount = table.Column<int>(type: "int", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Key", "Status", "UpdatedAt", "UpdatedById", "Value" },
                values: new object[,]
                {
                    { new Guid("01280e36-02e6-4663-823e-5e14e287bede"), null, null, "phone", null, null, null, "" },
                    { new Guid("11d9a927-1770-439e-9daf-095a66d1d7b3"), null, null, "defaultTourImage", null, null, null, "" },
                    { new Guid("5e77b941-2315-477e-a05a-69679da70afc"), null, null, "defaultBlogImage", null, null, null, "" },
                    { new Guid("b8d91fab-5b62-41ef-aacb-19791db98739"), null, null, "email", null, null, null, "" },
                    { new Guid("dae5400a-54d2-4568-8566-6e89c6dc9f87"), null, null, "appName", null, null, null, "" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Name", "ProvinceId", "Slug", "Status", "Type", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { new Guid("0049f9c7-aa39-4b87-886b-0e5ac0ff5342"), null, null, "Bình Định", null, null, null, null, null, null },
                    { new Guid("01bfe577-4b91-40b7-a580-cf200362d243"), null, null, "Thái Nguyên", null, null, null, null, null, null },
                    { new Guid("07482a9f-9385-48b9-8f8d-40e3abb54b0a"), null, null, "Long An", null, null, null, null, null, null },
                    { new Guid("0850c75d-963b-4d86-885a-5efdb7ce3553"), null, null, "Đắk Lắk", null, null, null, null, null, null },
                    { new Guid("09fa3865-4cc7-4c0f-8ffd-654de8dea2d9"), null, null, "Phú Thọ", null, null, null, null, null, null },
                    { new Guid("0e888f9c-4cec-4c4e-9318-80bbf130b501"), null, null, "Sóc Trăng", null, null, null, null, null, null },
                    { new Guid("0ecef50e-c372-4ce8-a3d4-9e0b81bd8e24"), null, null, "Nam Định", null, null, null, null, null, null },
                    { new Guid("14884c7b-30e9-487c-8a92-e9bb539e69dd"), null, null, "Nghệ An", null, null, null, null, null, null },
                    { new Guid("21268bac-5f6f-4240-8a2d-6fd0a15c319c"), null, null, "Thanh Hóa", null, null, null, null, null, null },
                    { new Guid("2207dfcf-efef-4f9d-af9f-1a8d91a79041"), null, null, "Vĩnh Long", null, null, null, null, null, null },
                    { new Guid("2ae69a2a-7cbb-493f-954c-f884ec829656"), null, null, "Quảng Ngãi", null, null, null, null, null, null },
                    { new Guid("2bc4da99-1191-4c15-b966-74e1e8bd5ff2"), null, null, "Phú Yên", null, null, null, null, null, null },
                    { new Guid("3178fe83-f1da-458f-9caa-cb06fcc3710c"), null, null, "Cà Mau", null, null, null, null, null, null },
                    { new Guid("39e8bf36-6628-4aa0-8ada-b2930eff3000"), null, null, "Hải Phòng", null, null, null, null, null, null },
                    { new Guid("3be2834f-d469-4656-a354-f0981414b78d"), null, null, "Bình Dương", null, null, null, null, null, null },
                    { new Guid("3e69ed6f-8c20-4936-98db-52b07621ac59"), null, null, "Quảng Ninh", null, null, null, null, null, null },
                    { new Guid("480739d3-559b-4945-9a4a-f4b320bf742c"), null, null, "Thái Bình", null, null, null, null, null, null },
                    { new Guid("482739cb-06cc-4b5e-8c87-2a0027e1af3b"), null, null, "Gia Lai", null, null, null, null, null, null },
                    { new Guid("4aa677a3-ac6d-4225-a3d7-e3174136fbc8"), null, null, "Bình Thuận", null, null, null, null, null, null },
                    { new Guid("4ae12f71-ba21-41fd-a6d8-66cd3f633748"), null, null, "Hà Giang", null, null, null, null, null, null },
                    { new Guid("5098c722-7a8f-4be0-a266-1980593f060d"), null, null, "An Giang", null, null, null, null, null, null },
                    { new Guid("51c47de0-06af-42d5-9258-07ff826dfe8f"), null, null, "Thừa Thiên Huế", null, null, null, null, null, null },
                    { new Guid("5add419a-f809-47ae-b8d9-80edce9dc41e"), null, null, "Kiên Giang", null, null, null, null, null, null },
                    { new Guid("5b784652-5ed6-4773-bb19-f7fce97a61c8"), null, null, "Hậu Giang", null, null, null, null, null, null },
                    { new Guid("5dbf9ce3-23a2-43f1-9a73-acd466be1bc3"), null, null, "Đồng Tháp", null, null, null, null, null, null },
                    { new Guid("61fd92f9-653a-42df-8e0d-861acf1e064e"), null, null, "Bắc Kạn", null, null, null, null, null, null },
                    { new Guid("62539ba1-53ba-41e1-b54f-a09fffd18d3a"), null, null, "Tây Ninh", null, null, null, null, null, null },
                    { new Guid("63d4a117-5bcd-4d5f-a412-c48130971aaf"), null, null, "Quảng Bình", null, null, null, null, null, null },
                    { new Guid("67b952a7-18d6-4241-a21e-16b151328b7b"), null, null, "Hưng Yên", null, null, null, null, null, null },
                    { new Guid("694ba9ec-bd31-403e-bfe0-2de5a2b537c2"), null, null, "Quảng Trị", null, null, null, null, null, null },
                    { new Guid("6974ced2-6557-49d8-8500-1c1dd67c7723"), null, null, "Điện Biên", null, null, null, null, null, null },
                    { new Guid("6a996415-fee7-4410-b675-1732583a6704"), null, null, "Khánh Hòa", null, null, null, null, null, null },
                    { new Guid("71b348cc-90b2-49fa-afee-d929f9695c93"), null, null, "Bến Tre", null, null, null, null, null, null },
                    { new Guid("73a948cc-fd6f-4dd9-9c79-346977cea1c2"), null, null, "Trà Vinh", null, null, null, null, null, null },
                    { new Guid("76f6a11f-dcc0-4496-9969-7fae593d900c"), null, null, "Sơn La", null, null, null, null, null, null },
                    { new Guid("7c6bd094-b67f-4462-898f-e5b6ea08f313"), null, null, "Thành phố Hồ Chí Minh", null, null, null, null, null, null },
                    { new Guid("7fb45860-256e-4045-bc14-fd8c550e7206"), null, null, "Hà Nội", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Name", "ProvinceId", "Slug", "Status", "Type", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { new Guid("83741c05-d0db-4c65-978c-5ac853c6e9f4"), null, null, "Ninh Bình", null, null, null, null, null, null },
                    { new Guid("84eec50a-b9f1-4daf-b54b-8caa1adc2357"), null, null, "Lạng Sơn", null, null, null, null, null, null },
                    { new Guid("87c60cdf-06ad-433c-9b6f-105a07a57508"), null, null, "Ninh Thuận", null, null, null, null, null, null },
                    { new Guid("938e3890-2ba4-46e7-b4b4-532a8c729cf9"), null, null, "Lâm Đồng", null, null, null, null, null, null },
                    { new Guid("95c2946f-4f20-4614-88dc-1123935fa6a4"), null, null, "Đồng Nai", null, null, null, null, null, null },
                    { new Guid("9893a16e-b753-492f-b99a-5802000ddafb"), null, null, "Tuyên Quang", null, null, null, null, null, null },
                    { new Guid("9b8193ee-b69c-4c76-b8d1-b97942af268e"), null, null, "Hà Nam", null, null, null, null, null, null },
                    { new Guid("9c05d561-d439-4ddd-a347-dbe22f56f80c"), null, null, "Cần Thơ", null, null, null, null, null, null },
                    { new Guid("9f058b4e-db77-49d0-abb2-0f83deb6d9a0"), null, null, "Đắk Nông", null, null, null, null, null, null },
                    { new Guid("a4809a85-4e23-48e6-af79-18f711f91933"), null, null, "Quảng Nam", null, null, null, null, null, null },
                    { new Guid("b81f8a3f-6e0a-439c-81ea-31c38f41a554"), null, null, "Bà Rịa – Vũng Tàu", null, null, null, null, null, null },
                    { new Guid("bb843c76-d840-4fe6-ad91-0f0b947ab23a"), null, null, "Hòa Bình", null, null, null, null, null, null },
                    { new Guid("bfad7a5b-7c65-4104-951d-184bd26760f1"), null, null, "Bình Phước", null, null, null, null, null, null },
                    { new Guid("c3aa0c9d-d274-4bea-b1f3-1e3d505c32f7"), null, null, "Kon Tum", null, null, null, null, null, null },
                    { new Guid("c64d6812-e660-4de4-b9ed-bd339ab758a8"), null, null, "Tiền Giang", null, null, null, null, null, null },
                    { new Guid("cad9d75e-e333-4192-a6e2-b3bc61bbed48"), null, null, "Yên Bái", null, null, null, null, null, null },
                    { new Guid("d36dc3c9-4752-434f-87d7-4b0a7b95c955"), null, null, "Lai Châu", null, null, null, null, null, null },
                    { new Guid("d9bd3cc1-fe39-47ae-ac9b-4471fccb9241"), null, null, "Cao Bằng", null, null, null, null, null, null },
                    { new Guid("da4d3994-f416-4746-a994-65fb2cfedfd8"), null, null, "Bạc Liêu", null, null, null, null, null, null },
                    { new Guid("e109d927-710e-49a0-8ae4-52c2f57b2064"), null, null, "Hà Tĩnh", null, null, null, null, null, null },
                    { new Guid("e1ec1a9a-f469-423f-970f-f9139008a378"), null, null, "Lào Cai", null, null, null, null, null, null },
                    { new Guid("e317318f-547d-46e7-b077-476d97d0735e"), null, null, "Hải Dương", null, null, null, null, null, null },
                    { new Guid("ea50ceec-b4c2-4075-b388-2fdb4bb262e6"), null, null, "Bắc Ninh", null, null, null, null, null, null },
                    { new Guid("ece5d94b-66e1-45be-bcdb-2f64b8aa48d4"), null, null, "Bắc Giang", null, null, null, null, null, null },
                    { new Guid("f81e06ee-36eb-4d29-83fe-7d11dc91536b"), null, null, "Đà Nẵng", null, null, null, null, null, null },
                    { new Guid("fad19112-3f4a-4e53-949d-b9a1128ff168"), null, null, "Vĩnh Phúc", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "IsAdmin", "LastLogin", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("0b2863d1-3468-4ad0-8881-ca52cdf1307d"), 0, "616f1653-48e9-4a6f-81b3-1bdd52e565b5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, null, true, null, "Admin", null, "ADMIN", "AQAAAAEAACcQAAAAED+SeOCagZl5GUfApy+o5Ne/mqFFBr5h9qlLZ98WSR8NOTMUH7qrRO3/dvl0F5hf5w==", null, false, "ZY5BGSWBARTE74T6ZLO7WKKMMILBEB2E", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_ProvinceId",
                table: "Tours",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
