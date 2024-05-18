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
                name: "Configuration",
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
                    table.PrimaryKey("PK_Configuration", x => x.Id);
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
                table: "Provinces",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Name", "ProvinceId", "Slug", "Status", "Type", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { new Guid("039cf527-306e-4369-8640-08504d382ac7"), null, null, "Hà Giang", null, null, null, null, null, null },
                    { new Guid("08783d32-7d9a-46d0-8671-cc7000304e18"), null, null, "Trà Vinh", null, null, null, null, null, null },
                    { new Guid("08d2bee7-9d2c-486d-82f4-6bc8423c2077"), null, null, "Kon Tum", null, null, null, null, null, null },
                    { new Guid("0bdecaac-5fd7-4f38-ba2b-aa35195fd68b"), null, null, "An Giang", null, null, null, null, null, null },
                    { new Guid("134ba0e9-2597-4529-83da-864d7781a00a"), null, null, "Bắc Giang", null, null, null, null, null, null },
                    { new Guid("1b7d00ba-3141-4b33-9718-d061f1174a8a"), null, null, "Thành phố Hồ Chí Minh", null, null, null, null, null, null },
                    { new Guid("1b8032f8-af80-4951-bedf-b777e25a991c"), null, null, "Lào Cai", null, null, null, null, null, null },
                    { new Guid("1d7c4373-f4ed-4504-aa63-52c72ea07ede"), null, null, "Nam Định", null, null, null, null, null, null },
                    { new Guid("25d93433-8351-448e-9648-0be1102f6dcd"), null, null, "Thanh Hóa", null, null, null, null, null, null },
                    { new Guid("2967b277-b26c-4013-a509-7edf3c19f971"), null, null, "Kiên Giang", null, null, null, null, null, null },
                    { new Guid("2992c601-6e8d-49ec-8542-3e4538ffa635"), null, null, "Nghệ An", null, null, null, null, null, null },
                    { new Guid("2aa02668-f130-4acd-98ff-f990b2c23e64"), null, null, "Bình Dương", null, null, null, null, null, null },
                    { new Guid("2b036964-9ba5-4306-82f2-67aa9d97557e"), null, null, "Hải Phòng", null, null, null, null, null, null },
                    { new Guid("2c6efbbc-9766-4aed-a6e3-4e6f67049863"), null, null, "Long An", null, null, null, null, null, null },
                    { new Guid("36741948-1ab3-4cbf-b36f-3662ea0bb756"), null, null, "Vĩnh Long", null, null, null, null, null, null },
                    { new Guid("39d159aa-7687-4474-ac6b-696b16b6fa26"), null, null, "Bạc Liêu", null, null, null, null, null, null },
                    { new Guid("3d986242-b7e9-47b3-977c-e162066f5b24"), null, null, "Điện Biên", null, null, null, null, null, null },
                    { new Guid("3f61caa6-3a94-4775-9ce3-4e7d2a8ab8dc"), null, null, "Cần Thơ", null, null, null, null, null, null },
                    { new Guid("41a462fc-6765-48c7-9960-61bd3321e605"), null, null, "Bắc Ninh", null, null, null, null, null, null },
                    { new Guid("4779ad58-60b8-4489-8322-d2911f52c8e3"), null, null, "Cao Bằng", null, null, null, null, null, null },
                    { new Guid("4ca81b47-9630-4457-b357-8826e2f9a277"), null, null, "Quảng Ngãi", null, null, null, null, null, null },
                    { new Guid("4d2bf356-7059-47b2-b294-f23c19cb420c"), null, null, "Bà Rịa – Vũng Tàu", null, null, null, null, null, null },
                    { new Guid("4e817918-fb84-424e-b811-669ebca394f1"), null, null, "Phú Thọ", null, null, null, null, null, null },
                    { new Guid("512c13a3-5d8c-477c-bf00-2e05a26a47a4"), null, null, "Hà Tĩnh", null, null, null, null, null, null },
                    { new Guid("537e3b5c-058e-42aa-a95a-c70f2fb0fd57"), null, null, "Quảng Ninh", null, null, null, null, null, null },
                    { new Guid("5501562b-6d28-411a-a01a-a5c69055817a"), null, null, "Quảng Bình", null, null, null, null, null, null },
                    { new Guid("5c88a8ea-47ce-4774-9946-1193b8e0ceea"), null, null, "Sóc Trăng", null, null, null, null, null, null },
                    { new Guid("5dce9cfe-8113-4a2c-b033-aae4881479ee"), null, null, "Phú Yên", null, null, null, null, null, null },
                    { new Guid("6210ab8f-9dcf-41ec-b602-a436b6557108"), null, null, "Bình Thuận", null, null, null, null, null, null },
                    { new Guid("64230471-875b-41ea-878e-4e492c17ca32"), null, null, "Tuyên Quang", null, null, null, null, null, null },
                    { new Guid("66e49ce5-ee2b-4e0e-baa8-b14c0b74a694"), null, null, "Hà Nội", null, null, null, null, null, null },
                    { new Guid("6955728d-4617-490e-94b0-4a6168d098f7"), null, null, "Bắc Kạn", null, null, null, null, null, null },
                    { new Guid("6b6bfd6b-ccf9-48fd-8620-77a4229cd117"), null, null, "Hà Nam", null, null, null, null, null, null },
                    { new Guid("6d70269f-2a3f-4c3c-9af9-ca55b7dc8164"), null, null, "Hưng Yên", null, null, null, null, null, null },
                    { new Guid("71237b07-53e4-44a9-b47c-a12c23d469b7"), null, null, "Gia Lai", null, null, null, null, null, null },
                    { new Guid("75d4e201-9245-436b-9bf5-88cd8fd47ecb"), null, null, "Lạng Sơn", null, null, null, null, null, null },
                    { new Guid("761cdbf4-04d3-41eb-8e88-0e8e5cff26a4"), null, null, "Đà Nẵng", null, null, null, null, null, null },
                    { new Guid("798ba8ba-4542-4426-a35e-d998cb535627"), null, null, "Ninh Bình", null, null, null, null, null, null },
                    { new Guid("7b834cae-c157-40a9-8b1f-a06fd32576ac"), null, null, "Tiền Giang", null, null, null, null, null, null },
                    { new Guid("7f94a2f6-3be8-4bc7-8c8a-ef4b2370e58f"), null, null, "Khánh Hòa", null, null, null, null, null, null },
                    { new Guid("82ae4ab7-d6df-415d-8f4c-02c797d02881"), null, null, "Đồng Tháp", null, null, null, null, null, null },
                    { new Guid("8872ff78-003b-4d35-88f8-fdad16f50e7e"), null, null, "Quảng Nam", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Name", "ProvinceId", "Slug", "Status", "Type", "UpdatedAt", "UpdatedById" },
                values: new object[,]
                {
                    { new Guid("8cdfce53-c5a2-40ac-8f73-8a410f2116ef"), null, null, "Đắk Nông", null, null, null, null, null, null },
                    { new Guid("9d5121db-cd1f-47b9-b695-4b2e2732bcc4"), null, null, "Đắk Lắk", null, null, null, null, null, null },
                    { new Guid("a961ea42-d45c-477a-bd95-61eab87eb446"), null, null, "Đồng Nai", null, null, null, null, null, null },
                    { new Guid("aa047c69-9d73-472b-9099-011837e81cc5"), null, null, "Thái Bình", null, null, null, null, null, null },
                    { new Guid("ae298568-f495-4642-822a-f34b95c6cfbf"), null, null, "Lâm Đồng", null, null, null, null, null, null },
                    { new Guid("b336704d-de8e-4fc2-81a2-63874dc4d7f6"), null, null, "Bình Phước", null, null, null, null, null, null },
                    { new Guid("bf3f26f2-9c6e-4b50-bfcf-b749e3170b66"), null, null, "Ninh Thuận", null, null, null, null, null, null },
                    { new Guid("c25bf13d-d945-4a8d-b00a-5fbd93d66da4"), null, null, "Bình Định", null, null, null, null, null, null },
                    { new Guid("c81aaa6b-eff6-4c20-a83a-46cfdde882d9"), null, null, "Vĩnh Phúc", null, null, null, null, null, null },
                    { new Guid("cd96c0c5-b5b5-4c4f-a6ea-df26e082006d"), null, null, "Bến Tre", null, null, null, null, null, null },
                    { new Guid("cea49dd0-d461-4e4a-9b23-0e6d1d1c90cb"), null, null, "Lai Châu", null, null, null, null, null, null },
                    { new Guid("d6769a3a-f5a2-43f3-b638-4ceddecbf95b"), null, null, "Thừa Thiên Huế", null, null, null, null, null, null },
                    { new Guid("da9f8b07-a589-44f8-9cee-82f72d4c58aa"), null, null, "Sơn La", null, null, null, null, null, null },
                    { new Guid("dafbe1dc-33ad-4a1c-a8ce-cb8841ae2d0b"), null, null, "Hậu Giang", null, null, null, null, null, null },
                    { new Guid("e44a09c3-e8fe-49a1-a911-eaa76866a7de"), null, null, "Thái Nguyên", null, null, null, null, null, null },
                    { new Guid("e505e3cb-86c9-4c20-9a35-9916413864e6"), null, null, "Hòa Bình", null, null, null, null, null, null },
                    { new Guid("eb3d78a2-7a1f-424d-a417-41200526caa3"), null, null, "Yên Bái", null, null, null, null, null, null },
                    { new Guid("ee735289-80b2-4363-a8c6-48ce26d9fcb9"), null, null, "Tây Ninh", null, null, null, null, null, null },
                    { new Guid("eed2fa62-1ba4-43f6-9531-c765a0ec4a23"), null, null, "Hải Dương", null, null, null, null, null, null },
                    { new Guid("f6014ece-0c0d-4591-97a6-72a578ba3e2f"), null, null, "Cà Mau", null, null, null, null, null, null },
                    { new Guid("f97e2dc3-c722-4081-af7b-4870b27fea09"), null, null, "Quảng Trị", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "IsAdmin", "LastLogin", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("0b2863d1-3468-4ad0-8881-ca52cdf1307d"), 0, "616f1653-48e9-4a6f-81b3-1bdd52e565b5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, null, true, null, "Admin", null, "ADMIN", "AQAAAAEAACcQAAAAEOT3zsv+7u3OTITUOGUmEf0o59xBl8gTJxMUvGW8ePIE3eVhFQ3QrlFfIk6Ps3zV2A==", null, false, "ZY5BGSWBARTE74T6ZLO7WKKMMILBEB2E", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" });

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
                name: "Configuration");

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
