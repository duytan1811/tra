using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travel_ASP.Migrations
{
    public partial class InitialDatabase : Migration
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

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Key", "Status", "UpdatedAt", "UpdatedById", "Value" },
                values: new object[,]
                {
                    { new Guid("154e4306-fcaf-4a7e-b257-c56ac7b7544e"), null, null, "phone", null, null, null, "" },
                    { new Guid("22db1a6c-d8fb-45ee-a23d-1b0071a14172"), null, null, "defaultBlogImage", null, null, null, "" },
                    { new Guid("9c68c504-5109-4fae-a80f-e5cbcaec12f0"), null, null, "appName", null, null, null, "" },
                    { new Guid("cce50faa-37fa-4ed8-b663-1bd75c3f94a9"), null, null, "email", null, null, null, "" },
                    { new Guid("d8e605d9-f087-42ba-9b6e-258903a1e53f"), null, null, "defaultTourImage", null, null, null, "" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Name", "ProvinceId", "Slug", "Status", "Type", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { new Guid("02b2fda4-3315-4e7b-8484-0ab1a16b105d"), null, null, "Tuyên Quang", null, null, null, null, null, null },
                    { new Guid("05b61942-6804-4ee7-8a53-f42fb9e29e57"), null, null, "Ninh Thuận", null, null, null, null, null, null },
                    { new Guid("06ea0cc0-358e-48fd-9945-352c618eb4ea"), null, null, "Trà Vinh", null, null, null, null, null, null },
                    { new Guid("0b0789f1-9eb3-4a13-9c9a-405ca38d4019"), null, null, "Thành phố Hồ Chí Minh", null, null, null, null, null, null },
                    { new Guid("0c37c0fd-b134-4dcf-8cd1-9e401b79f73b"), null, null, "Cần Thơ", null, null, null, null, null, null },
                    { new Guid("0da4ee73-807a-4fe9-be2d-f32a3e76bf15"), null, null, "Hà Giang", null, null, null, null, null, null },
                    { new Guid("0ef1a240-bd21-472a-9fd2-e4288e651f9a"), null, null, "Quảng Ngãi", null, null, null, null, null, null },
                    { new Guid("1759e3b5-b300-4800-ad97-916b3820d121"), null, null, "Đồng Tháp", null, null, null, null, null, null },
                    { new Guid("24d669d6-5371-4a72-801c-d512396fca16"), null, null, "Kon Tum", null, null, null, null, null, null },
                    { new Guid("278b3bbd-1c7d-4d2e-81c6-5dd7594a7e74"), null, null, "Đắk Nông", null, null, null, null, null, null },
                    { new Guid("2caa5d66-92ce-45f8-8bd5-69d54cfc9e86"), null, null, "Thái Nguyên", null, null, null, null, null, null },
                    { new Guid("2e58e891-a60c-4d7b-83f1-9ecea3eabed5"), null, null, "Sóc Trăng", null, null, null, null, null, null },
                    { new Guid("2e8de93a-4bf2-447f-9d41-22e9bac83f05"), null, null, "Thái Bình", null, null, null, null, null, null },
                    { new Guid("336b90be-1252-4600-a3d2-3046040eb63b"), null, null, "Phú Thọ", null, null, null, null, null, null },
                    { new Guid("38e721ac-c526-4cab-899b-ae68ce517d0b"), null, null, "Lào Cai", null, null, null, null, null, null },
                    { new Guid("39baeb22-b4d7-4071-b093-5a648be565d7"), null, null, "An Giang", null, null, null, null, null, null },
                    { new Guid("427b1ec1-c01b-4f73-97dd-f02fd935e508"), null, null, "Hà Nam", null, null, null, null, null, null },
                    { new Guid("42d6c600-8b1e-43b3-8ec7-39c000f89b43"), null, null, "Điện Biên", null, null, null, null, null, null },
                    { new Guid("4426ce92-0c13-46a6-b1ba-743f384053c2"), null, null, "Hà Nội", null, null, null, null, null, null },
                    { new Guid("4c3a6896-9876-455e-85bf-77427e8efddb"), null, null, "Đắk Lắk", null, null, null, null, null, null },
                    { new Guid("4e08dce0-1fa6-45a6-b048-de8ff5bfdd5c"), null, null, "Long An", null, null, null, null, null, null },
                    { new Guid("4fda11b0-cb47-4231-ae44-5e91aab1eb1c"), null, null, "Quảng Bình", null, null, null, null, null, null },
                    { new Guid("50be2ab1-eb0c-42a7-b58b-418452802065"), null, null, "Bà Rịa – Vũng Tàu", null, null, null, null, null, null },
                    { new Guid("53b2e766-1eaa-47b9-b2a5-5459f8596bad"), null, null, "Bình Phước", null, null, null, null, null, null },
                    { new Guid("5ee9e5c2-3931-4264-9529-a5d4d6c79c02"), null, null, "Bình Thuận", null, null, null, null, null, null },
                    { new Guid("5fd79732-298b-474c-8a1b-dcd80fc90ffa"), null, null, "Hải Dương", null, null, null, null, null, null },
                    { new Guid("61522160-e263-4b4d-bfac-77503c14d159"), null, null, "Tiền Giang", null, null, null, null, null, null },
                    { new Guid("662390ca-3698-4868-9967-f277bb3e3d05"), null, null, "Quảng Nam", null, null, null, null, null, null },
                    { new Guid("6e6af074-6f20-4b1b-a0fa-6bb2a81175ed"), null, null, "Sơn La", null, null, null, null, null, null },
                    { new Guid("6f14f511-a616-4854-ac3f-45d68fab03c0"), null, null, "Lạng Sơn", null, null, null, null, null, null },
                    { new Guid("768f56b1-2802-436d-b12c-16ce1f1cf86f"), null, null, "Yên Bái", null, null, null, null, null, null },
                    { new Guid("79fc1791-d95a-47a5-90b3-4e092cabf258"), null, null, "Hải Phòng", null, null, null, null, null, null },
                    { new Guid("7b7a1fc4-072d-49fc-859b-c678cb917252"), null, null, "Quảng Trị", null, null, null, null, null, null },
                    { new Guid("7bbd3239-64fb-4d13-af4c-c6fcf032e33a"), null, null, "Phú Yên", null, null, null, null, null, null },
                    { new Guid("805e589f-519c-46ff-888c-a7c0944aeec5"), null, null, "Hậu Giang", null, null, null, null, null, null },
                    { new Guid("9173d0db-fef6-4fa4-a504-663e27b990ae"), null, null, "Ninh Bình", null, null, null, null, null, null },
                    { new Guid("9427a6d7-d835-4a1a-b06a-3bcd03314c2e"), null, null, "Hà Tĩnh", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Name", "ProvinceId", "Slug", "Status", "Type", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { new Guid("976f8c4b-a929-4a7e-817f-5af090cec540"), null, null, "Thanh Hóa", null, null, null, null, null, null },
                    { new Guid("9874c76e-eafe-4816-a32f-151a6fc59ab6"), null, null, "Bình Định", null, null, null, null, null, null },
                    { new Guid("9a61aafd-1cdd-4dab-a042-8321570055b5"), null, null, "Khánh Hòa", null, null, null, null, null, null },
                    { new Guid("a280a102-1ec6-4c6c-9858-f646fa37b2b5"), null, null, "Quảng Ninh", null, null, null, null, null, null },
                    { new Guid("a34d739d-b05f-43dd-8455-68ad897cbf8e"), null, null, "Bạc Liêu", null, null, null, null, null, null },
                    { new Guid("afd1de18-c7b9-4bda-88ff-1899889d9e2c"), null, null, "Hưng Yên", null, null, null, null, null, null },
                    { new Guid("b7b07fb6-cad8-4612-ad68-0714f9ba8895"), null, null, "Vĩnh Long", null, null, null, null, null, null },
                    { new Guid("baad4bd0-6215-44f2-b08f-e7dda5a0cfbe"), null, null, "Lâm Đồng", null, null, null, null, null, null },
                    { new Guid("c255dc71-9b54-4f0f-99bf-237ea92b1614"), null, null, "Kiên Giang", null, null, null, null, null, null },
                    { new Guid("c7c61d02-3436-49bc-ae4e-8c058a608aa7"), null, null, "Đồng Nai", null, null, null, null, null, null },
                    { new Guid("cb7d9223-a0fc-4091-ae61-fb0252be22da"), null, null, "Bắc Kạn", null, null, null, null, null, null },
                    { new Guid("ccff2fb2-dbc5-4e6d-aea0-aa39da7c87c5"), null, null, "Bến Tre", null, null, null, null, null, null },
                    { new Guid("d30782d0-46f8-4534-aa9b-c8a96a34a8de"), null, null, "Bắc Giang", null, null, null, null, null, null },
                    { new Guid("d3a76ae3-fda7-4aea-a60a-8c4335a86bd8"), null, null, "Đà Nẵng", null, null, null, null, null, null },
                    { new Guid("d4b07036-7e95-4c2a-837c-b0f30bd42c86"), null, null, "Cao Bằng", null, null, null, null, null, null },
                    { new Guid("d8364b93-e017-4d66-91a7-1a6923462b19"), null, null, "Nam Định", null, null, null, null, null, null },
                    { new Guid("da050aae-b2ea-4745-80ad-fea42f2f3fd4"), null, null, "Lai Châu", null, null, null, null, null, null },
                    { new Guid("e12f51b9-ec9f-4710-bfe0-b0cc093441bc"), null, null, "Nghệ An", null, null, null, null, null, null },
                    { new Guid("e3042da3-70dd-44c9-8f92-bba6d9f6d1d9"), null, null, "Vĩnh Phúc", null, null, null, null, null, null },
                    { new Guid("e9d47bfe-68be-4e28-af3f-6444cd2ae8ba"), null, null, "Bình Dương", null, null, null, null, null, null },
                    { new Guid("ec9cb8fb-58be-4f4b-b975-44fe8b838191"), null, null, "Hòa Bình", null, null, null, null, null, null },
                    { new Guid("eead0bd0-3de2-4fc3-99a1-a774e0f49187"), null, null, "Gia Lai", null, null, null, null, null, null },
                    { new Guid("eefcffd1-b17e-4d45-be11-9e0857d6b433"), null, null, "Thừa Thiên Huế", null, null, null, null, null, null },
                    { new Guid("fb5c7eac-742a-4c88-ba75-aa274e1404fb"), null, null, "Bắc Ninh", null, null, null, null, null, null },
                    { new Guid("fe276321-20d1-47be-909d-977db74086e5"), null, null, "Tây Ninh", null, null, null, null, null, null },
                    { new Guid("fea2144d-a645-4944-a544-52c2f4a9fe6f"), null, null, "Cà Mau", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "IsAdmin", "LastLogin", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("0b2863d1-3468-4ad0-8881-ca52cdf1307d"), 0, "616f1653-48e9-4a6f-81b3-1bdd52e565b5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, null, true, null, "Admin", null, "ADMIN", "AQAAAAEAACcQAAAAEPH8uBiczPM4CfUP4npJs7EkyD+bJTh8RPG+yHshv8dCpDqyJLLPJR0R/Vf6caAkvg==", null, false, "ZY5BGSWBARTE74T6ZLO7WKKMMILBEB2E", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_TourId",
                table: "Bookings",
                column: "TourId");

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
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
