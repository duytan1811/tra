﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using STM.DataAccess.Contexts;

#nullable disable

namespace Travel_ASP.Migrations
{
    [DbContext(typeof(TravelDbContext))]
    partial class TravelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Travel_ASP.Models.Blog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Travel_ASP.Models.Configuration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Configuration");
                });

            modelBuilder.Entity("Travel_ASP.Models.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Travel_ASP.Models.Province", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Provinces");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0bdecaac-5fd7-4f38-ba2b-aa35195fd68b"),
                            Name = "An Giang"
                        },
                        new
                        {
                            Id = new Guid("4d2bf356-7059-47b2-b294-f23c19cb420c"),
                            Name = "Bà Rịa – Vũng Tàu"
                        },
                        new
                        {
                            Id = new Guid("134ba0e9-2597-4529-83da-864d7781a00a"),
                            Name = "Bắc Giang"
                        },
                        new
                        {
                            Id = new Guid("6955728d-4617-490e-94b0-4a6168d098f7"),
                            Name = "Bắc Kạn"
                        },
                        new
                        {
                            Id = new Guid("39d159aa-7687-4474-ac6b-696b16b6fa26"),
                            Name = "Bạc Liêu"
                        },
                        new
                        {
                            Id = new Guid("41a462fc-6765-48c7-9960-61bd3321e605"),
                            Name = "Bắc Ninh"
                        },
                        new
                        {
                            Id = new Guid("cd96c0c5-b5b5-4c4f-a6ea-df26e082006d"),
                            Name = "Bến Tre"
                        },
                        new
                        {
                            Id = new Guid("c25bf13d-d945-4a8d-b00a-5fbd93d66da4"),
                            Name = "Bình Định"
                        },
                        new
                        {
                            Id = new Guid("2aa02668-f130-4acd-98ff-f990b2c23e64"),
                            Name = "Bình Dương"
                        },
                        new
                        {
                            Id = new Guid("b336704d-de8e-4fc2-81a2-63874dc4d7f6"),
                            Name = "Bình Phước"
                        },
                        new
                        {
                            Id = new Guid("6210ab8f-9dcf-41ec-b602-a436b6557108"),
                            Name = "Bình Thuận"
                        },
                        new
                        {
                            Id = new Guid("f6014ece-0c0d-4591-97a6-72a578ba3e2f"),
                            Name = "Cà Mau"
                        },
                        new
                        {
                            Id = new Guid("3f61caa6-3a94-4775-9ce3-4e7d2a8ab8dc"),
                            Name = "Cần Thơ"
                        },
                        new
                        {
                            Id = new Guid("4779ad58-60b8-4489-8322-d2911f52c8e3"),
                            Name = "Cao Bằng"
                        },
                        new
                        {
                            Id = new Guid("761cdbf4-04d3-41eb-8e88-0e8e5cff26a4"),
                            Name = "Đà Nẵng"
                        },
                        new
                        {
                            Id = new Guid("9d5121db-cd1f-47b9-b695-4b2e2732bcc4"),
                            Name = "Đắk Lắk"
                        },
                        new
                        {
                            Id = new Guid("8cdfce53-c5a2-40ac-8f73-8a410f2116ef"),
                            Name = "Đắk Nông"
                        },
                        new
                        {
                            Id = new Guid("3d986242-b7e9-47b3-977c-e162066f5b24"),
                            Name = "Điện Biên"
                        },
                        new
                        {
                            Id = new Guid("a961ea42-d45c-477a-bd95-61eab87eb446"),
                            Name = "Đồng Nai"
                        },
                        new
                        {
                            Id = new Guid("82ae4ab7-d6df-415d-8f4c-02c797d02881"),
                            Name = "Đồng Tháp"
                        },
                        new
                        {
                            Id = new Guid("71237b07-53e4-44a9-b47c-a12c23d469b7"),
                            Name = "Gia Lai"
                        },
                        new
                        {
                            Id = new Guid("039cf527-306e-4369-8640-08504d382ac7"),
                            Name = "Hà Giang"
                        },
                        new
                        {
                            Id = new Guid("6b6bfd6b-ccf9-48fd-8620-77a4229cd117"),
                            Name = "Hà Nam"
                        },
                        new
                        {
                            Id = new Guid("66e49ce5-ee2b-4e0e-baa8-b14c0b74a694"),
                            Name = "Hà Nội"
                        },
                        new
                        {
                            Id = new Guid("512c13a3-5d8c-477c-bf00-2e05a26a47a4"),
                            Name = "Hà Tĩnh"
                        },
                        new
                        {
                            Id = new Guid("eed2fa62-1ba4-43f6-9531-c765a0ec4a23"),
                            Name = "Hải Dương"
                        },
                        new
                        {
                            Id = new Guid("2b036964-9ba5-4306-82f2-67aa9d97557e"),
                            Name = "Hải Phòng"
                        },
                        new
                        {
                            Id = new Guid("dafbe1dc-33ad-4a1c-a8ce-cb8841ae2d0b"),
                            Name = "Hậu Giang"
                        },
                        new
                        {
                            Id = new Guid("e505e3cb-86c9-4c20-9a35-9916413864e6"),
                            Name = "Hòa Bình"
                        },
                        new
                        {
                            Id = new Guid("6d70269f-2a3f-4c3c-9af9-ca55b7dc8164"),
                            Name = "Hưng Yên"
                        },
                        new
                        {
                            Id = new Guid("7f94a2f6-3be8-4bc7-8c8a-ef4b2370e58f"),
                            Name = "Khánh Hòa"
                        },
                        new
                        {
                            Id = new Guid("2967b277-b26c-4013-a509-7edf3c19f971"),
                            Name = "Kiên Giang"
                        },
                        new
                        {
                            Id = new Guid("08d2bee7-9d2c-486d-82f4-6bc8423c2077"),
                            Name = "Kon Tum"
                        },
                        new
                        {
                            Id = new Guid("cea49dd0-d461-4e4a-9b23-0e6d1d1c90cb"),
                            Name = "Lai Châu"
                        },
                        new
                        {
                            Id = new Guid("ae298568-f495-4642-822a-f34b95c6cfbf"),
                            Name = "Lâm Đồng"
                        },
                        new
                        {
                            Id = new Guid("75d4e201-9245-436b-9bf5-88cd8fd47ecb"),
                            Name = "Lạng Sơn"
                        },
                        new
                        {
                            Id = new Guid("1b8032f8-af80-4951-bedf-b777e25a991c"),
                            Name = "Lào Cai"
                        },
                        new
                        {
                            Id = new Guid("2c6efbbc-9766-4aed-a6e3-4e6f67049863"),
                            Name = "Long An"
                        },
                        new
                        {
                            Id = new Guid("1d7c4373-f4ed-4504-aa63-52c72ea07ede"),
                            Name = "Nam Định"
                        },
                        new
                        {
                            Id = new Guid("2992c601-6e8d-49ec-8542-3e4538ffa635"),
                            Name = "Nghệ An"
                        },
                        new
                        {
                            Id = new Guid("798ba8ba-4542-4426-a35e-d998cb535627"),
                            Name = "Ninh Bình"
                        },
                        new
                        {
                            Id = new Guid("bf3f26f2-9c6e-4b50-bfcf-b749e3170b66"),
                            Name = "Ninh Thuận"
                        },
                        new
                        {
                            Id = new Guid("4e817918-fb84-424e-b811-669ebca394f1"),
                            Name = "Phú Thọ"
                        },
                        new
                        {
                            Id = new Guid("5dce9cfe-8113-4a2c-b033-aae4881479ee"),
                            Name = "Phú Yên"
                        },
                        new
                        {
                            Id = new Guid("5501562b-6d28-411a-a01a-a5c69055817a"),
                            Name = "Quảng Bình"
                        },
                        new
                        {
                            Id = new Guid("8872ff78-003b-4d35-88f8-fdad16f50e7e"),
                            Name = "Quảng Nam"
                        },
                        new
                        {
                            Id = new Guid("4ca81b47-9630-4457-b357-8826e2f9a277"),
                            Name = "Quảng Ngãi"
                        },
                        new
                        {
                            Id = new Guid("537e3b5c-058e-42aa-a95a-c70f2fb0fd57"),
                            Name = "Quảng Ninh"
                        },
                        new
                        {
                            Id = new Guid("f97e2dc3-c722-4081-af7b-4870b27fea09"),
                            Name = "Quảng Trị"
                        },
                        new
                        {
                            Id = new Guid("5c88a8ea-47ce-4774-9946-1193b8e0ceea"),
                            Name = "Sóc Trăng"
                        },
                        new
                        {
                            Id = new Guid("da9f8b07-a589-44f8-9cee-82f72d4c58aa"),
                            Name = "Sơn La"
                        },
                        new
                        {
                            Id = new Guid("ee735289-80b2-4363-a8c6-48ce26d9fcb9"),
                            Name = "Tây Ninh"
                        },
                        new
                        {
                            Id = new Guid("aa047c69-9d73-472b-9099-011837e81cc5"),
                            Name = "Thái Bình"
                        },
                        new
                        {
                            Id = new Guid("e44a09c3-e8fe-49a1-a911-eaa76866a7de"),
                            Name = "Thái Nguyên"
                        },
                        new
                        {
                            Id = new Guid("25d93433-8351-448e-9648-0be1102f6dcd"),
                            Name = "Thanh Hóa"
                        },
                        new
                        {
                            Id = new Guid("d6769a3a-f5a2-43f3-b638-4ceddecbf95b"),
                            Name = "Thừa Thiên Huế"
                        },
                        new
                        {
                            Id = new Guid("7b834cae-c157-40a9-8b1f-a06fd32576ac"),
                            Name = "Tiền Giang"
                        },
                        new
                        {
                            Id = new Guid("1b7d00ba-3141-4b33-9718-d061f1174a8a"),
                            Name = "Thành phố Hồ Chí Minh"
                        },
                        new
                        {
                            Id = new Guid("08783d32-7d9a-46d0-8671-cc7000304e18"),
                            Name = "Trà Vinh"
                        },
                        new
                        {
                            Id = new Guid("64230471-875b-41ea-878e-4e492c17ca32"),
                            Name = "Tuyên Quang"
                        },
                        new
                        {
                            Id = new Guid("36741948-1ab3-4cbf-b36f-3662ea0bb756"),
                            Name = "Vĩnh Long"
                        },
                        new
                        {
                            Id = new Guid("c81aaa6b-eff6-4c20-a83a-46cfdde882d9"),
                            Name = "Vĩnh Phúc"
                        },
                        new
                        {
                            Id = new Guid("eb3d78a2-7a1f-424d-a417-41200526caa3"),
                            Name = "Yên Bái"
                        });
                });

            modelBuilder.Entity("Travel_ASP.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Travel_ASP.Models.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Travel_ASP.Models.Tour", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("DayCount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxPeople")
                        .HasColumnType("int");

                    b.Property<int?>("MinPeople")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("ProvinceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("Travel_ASP.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(256);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0b2863d1-3468-4ad0-8881-ca52cdf1307d"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "616f1653-48e9-4a6f-81b3-1bdd52e565b5",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailConfirmed = false,
                            IsAdmin = true,
                            LockoutEnabled = true,
                            Name = "Admin",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEOT3zsv+7u3OTITUOGUmEf0o59xBl8gTJxMUvGW8ePIE3eVhFQ3QrlFfIk6Ps3zV2A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ZY5BGSWBARTE74T6ZLO7WKKMMILBEB2E",
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Travel_ASP.Models.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Travel_ASP.Models.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Travel_ASP.Models.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Travel_ASP.Models.UserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Travel_ASP.Models.RoleClaim", b =>
                {
                    b.HasOne("Travel_ASP.Models.Role", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Travel_ASP.Models.Tour", b =>
                {
                    b.HasOne("Travel_ASP.Models.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("Travel_ASP.Models.UserClaim", b =>
                {
                    b.HasOne("Travel_ASP.Models.User", "User")
                        .WithMany("UserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Travel_ASP.Models.UserLogin", b =>
                {
                    b.HasOne("Travel_ASP.Models.User", "User")
                        .WithMany("UserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Travel_ASP.Models.UserRole", b =>
                {
                    b.HasOne("Travel_ASP.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Travel_ASP.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Travel_ASP.Models.UserToken", b =>
                {
                    b.HasOne("Travel_ASP.Models.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Travel_ASP.Models.Role", b =>
                {
                    b.Navigation("RoleClaims");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Travel_ASP.Models.User", b =>
                {
                    b.Navigation("UserClaims");

                    b.Navigation("UserLogins");

                    b.Navigation("UserRoles");

                    b.Navigation("UserTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
