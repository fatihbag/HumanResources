﻿// <auto-generated />
using System;
using HR.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HR.Infrastructure.Migrations
{
    [DbContext(typeof(HumanResourcesDbContext))]
    [Migration("20230220235237_test6")]
    partial class test6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HR.Domain.Entities.AppCompany", b =>
                {
                    b.Property<Guid>("AppCompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CompanyFounded")
                        .HasColumnType("datetime2");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyTitle")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DealEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DealStartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MersisNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("int");

                    b.Property<int>("Sector")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TaxAdministration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AppCompanyID");

                    b.ToTable("AppCompany");
                });

            modelBuilder.Entity("HR.Domain.Entities.AppRole", b =>
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

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("61389629-0334-4f06-9a5b-b9081d213d47"),
                            ConcurrencyStamp = "33350ddf-978c-425c-bb9e-f5e557fc28d0",
                            Name = "Personnel",
                            NormalizedName = "PERSONNEL"
                        },
                        new
                        {
                            Id = new Guid("11482fea-3b0d-43b2-aa27-8425de91690d"),
                            ConcurrencyStamp = "3e182a2c-bbfb-41d7-9f28-c18dfb39ea35",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("0e881658-a975-4e9a-896c-85e76a3810a6"),
                            ConcurrencyStamp = "1122e9ed-250d-4ef5-8223-c1beea73d7ee",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        });
                });

            modelBuilder.Entity("HR.Domain.Entities.AppRoleClaims", b =>
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

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EndingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

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

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sector")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8f23799b-b6e5-4a8b-8fdb-e78fadebaf31"),
                            AccessFailedCount = 0,
                            Address = "Yanişehir mah. 18 sok no:41 daire:4, Denizli/Merkezefendi",
                            BirthDate = new DateTime(1997, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "71410032-18aa-43d3-9316-573ac70c1260",
                            CreateDate = new DateTime(2023, 2, 21, 2, 52, 37, 411, DateTimeKind.Local).AddTicks(4119),
                            Department = 2,
                            Email = "ramazan.yaylali@bilgeadamboost.com",
                            EmailConfirmed = false,
                            EndingDate = new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdentityNumber = "41485012455",
                            ImagePath = "/img/userspic/Ramazan.jpg",
                            IsActive = false,
                            LockoutEnabled = false,
                            Name = "Ramazan",
                            NormalizedEmail = "RAMAZAN.YAYLALI@BILGEADAMBOOST.COM",
                            NormalizedUserName = "RAMAZANY",
                            PasswordHash = "AQAAAAEAACcQAAAAEGBGHoMCzzOPK/iFw+ErutyOAXHarpjcXAGjCXZnawxCBMDpU59bLPyLDVpq8M6o8g==",
                            PhoneNumber = 5365867759L,
                            PhoneNumberConfirmed = false,
                            PlaceOfBirth = "Acıpayam",
                            Salary = 10000m,
                            Sector = 10,
                            SecurityStamp = "1e13aa31-bc3a-43de-b59f-bd8e48128ec8",
                            StartingDate = new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            Surname = "YAYLALI",
                            TwoFactorEnabled = false,
                            UserName = "RamazanY"
                        },
                        new
                        {
                            Id = new Guid("957e3a7a-a315-4237-82cf-aeee7144b033"),
                            AccessFailedCount = 0,
                            Address = "Yalı mahallesi Caher Dudayev Bulvarı No:107 D:B, İzmir/Karşıyaka ",
                            BirthDate = new DateTime(1988, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "f3b3f885-f566-48fa-8bfb-3fe0c6099819",
                            CreateDate = new DateTime(2023, 2, 21, 2, 52, 37, 411, DateTimeKind.Local).AddTicks(4197),
                            Department = 3,
                            Email = "hazel.calkar@bilgeadamboost.com",
                            EmailConfirmed = false,
                            IdentityNumber = "31354697822",
                            IsActive = true,
                            LockoutEnabled = false,
                            Name = "Hazel",
                            NormalizedEmail = "HAZEL.CALKAR@BILGEADAMBOOST.COM",
                            NormalizedUserName = "HAZELC",
                            PasswordHash = "AQAAAAEAACcQAAAAECDG7VG7l1wBeY3MYz1B2+YPloMvCd3QC6FrOxiz/qvA3tUOwXtWzFeGYGwK4x+PZA==",
                            PhoneNumber = 5365867759L,
                            PhoneNumberConfirmed = false,
                            PlaceOfBirth = "İzmir",
                            Salary = 13000m,
                            Sector = 10,
                            SecurityStamp = "c000ceed-d6df-418e-b5ca-b28c1e8cc7d9",
                            StartingDate = new DateTime(2020, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            Surname = "ÇALKAR",
                            TwoFactorEnabled = false,
                            UserName = "HazelC"
                        },
                        new
                        {
                            Id = new Guid("6140e871-8ff5-4588-a03e-590c9eb1a251"),
                            AccessFailedCount = 0,
                            Address = "Bostanlı mahallesi Cengiz Kocatoros Sokağı No: 85/A, İzmir/Karşıyaka ",
                            BirthDate = new DateTime(1982, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "a614d588-c48a-4f86-b1b1-bbe9b56a62f9",
                            CreateDate = new DateTime(2023, 2, 21, 2, 52, 37, 411, DateTimeKind.Local).AddTicks(4217),
                            Department = 3,
                            Email = "aysenur.altınsoy@bilgeadamboost.com",
                            EmailConfirmed = false,
                            IdentityNumber = "78953246782",
                            IsActive = true,
                            LockoutEnabled = false,
                            Name = "Ayşenur",
                            NormalizedEmail = "AYSENUR.ALTINSOY@BILGEADAMBOOST.COM",
                            NormalizedUserName = "AYSENURA",
                            PasswordHash = "AQAAAAEAACcQAAAAENh7YteSR339TVB8lLaWEpN/zePZSzIy6FPsR0ClgOR55wiom9lD96sv1RIay9w6fA==",
                            PhoneNumber = 5365867759L,
                            PhoneNumberConfirmed = false,
                            PlaceOfBirth = "İzmir",
                            Salary = 14000m,
                            Sector = 10,
                            SecurityStamp = "d92d844c-bd4b-4e04-b269-159b0285950a",
                            StartingDate = new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            Surname = "ALTINSOY",
                            TwoFactorEnabled = false,
                            UserName = "AysenurA"
                        },
                        new
                        {
                            Id = new Guid("0c9aafd8-dbe6-4d4b-a20f-74fd58a5d4c0"),
                            AccessFailedCount = 0,
                            Address = "Caferağa mahallesi Mühürdar Cd. No:76 kat:5, İstanbul/Sarıyer",
                            BirthDate = new DateTime(1995, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "f21308a5-c9c5-4c01-a866-8f2a364b714b",
                            CreateDate = new DateTime(2023, 2, 21, 2, 52, 37, 411, DateTimeKind.Local).AddTicks(4230),
                            Department = 2,
                            Email = "serkan.temiz@bilgeadamboost.com",
                            EmailConfirmed = false,
                            IdentityNumber = "19637426548",
                            IsActive = true,
                            LockoutEnabled = false,
                            Name = "Serkan",
                            NormalizedEmail = "SERKAN.TEMIZ@BILGEADAMBOOST.COM",
                            NormalizedUserName = "SERKANT",
                            PasswordHash = "AQAAAAEAACcQAAAAEHRQwfcZjk+LGlzP7hf0uHdJIj0XeWdOOXtREDdXwBmqEUP+garEDbMbHOG1To/6oQ==",
                            PhoneNumber = 5425324892L,
                            PhoneNumberConfirmed = false,
                            PlaceOfBirth = "İstanbul",
                            Salary = 14000m,
                            Sector = 8,
                            SecurityStamp = "08784d77-0919-4c0c-b6a3-8dd4ea7727f8",
                            StartingDate = new DateTime(2020, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            Surname = "TEMİZ",
                            TwoFactorEnabled = false,
                            UserName = "SerkanT"
                        },
                        new
                        {
                            Id = new Guid("72d306bd-7ccf-4735-b77f-5fcdcf960167"),
                            AccessFailedCount = 0,
                            Address = "Cumhuriyet mah. 5034 sok no:2 daire:3,Denizli/Pamukkale",
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "fe11ee69-358e-4788-a91f-d2ab78ebb807",
                            CreateDate = new DateTime(2023, 2, 21, 2, 52, 37, 411, DateTimeKind.Local).AddTicks(4303),
                            Department = 2,
                            Email = "fatih.bag@bilgeadamboost.com",
                            EmailConfirmed = false,
                            EndingDate = new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdentityNumber = "12312345678",
                            IsActive = false,
                            LockoutEnabled = false,
                            Name = "Fatih",
                            NormalizedEmail = "FATIH.BAG@BILGEADAMBOOST.COM",
                            NormalizedUserName = "FATIHB",
                            PasswordHash = "AQAAAAEAACcQAAAAEPS/eeBZIi9JVtlpJ61r3Dx6sMMA1skiWQhctoHjvHZIUTMh5VDtJQ+NZnNfdNWNFQ==",
                            PhoneNumber = 5318700685L,
                            PhoneNumberConfirmed = false,
                            PlaceOfBirth = "Denizli",
                            Salary = 13000m,
                            Sector = 7,
                            SecurityStamp = "e7107006-5069-4e6c-8fe3-3119eaf865cd",
                            StartingDate = new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            Surname = "BAG",
                            TwoFactorEnabled = false,
                            UserName = "FatihB"
                        });
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUserAdvance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AdvanceType")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("ApprovalDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("ApprovalStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ReplyDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("RequestDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("AppUserAdvance");
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUserCliams", b =>
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

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("8f23799b-b6e5-4a8b-8fdb-e78fadebaf31"),
                            RoleId = new Guid("61389629-0334-4f06-9a5b-b9081d213d47")
                        },
                        new
                        {
                            UserId = new Guid("957e3a7a-a315-4237-82cf-aeee7144b033"),
                            RoleId = new Guid("61389629-0334-4f06-9a5b-b9081d213d47")
                        },
                        new
                        {
                            UserId = new Guid("6140e871-8ff5-4588-a03e-590c9eb1a251"),
                            RoleId = new Guid("61389629-0334-4f06-9a5b-b9081d213d47")
                        },
                        new
                        {
                            UserId = new Guid("0c9aafd8-dbe6-4d4b-a20f-74fd58a5d4c0"),
                            RoleId = new Guid("11482fea-3b0d-43b2-aa27-8425de91690d")
                        },
                        new
                        {
                            UserId = new Guid("72d306bd-7ccf-4735-b77f-5fcdcf960167"),
                            RoleId = new Guid("11482fea-3b0d-43b2-aa27-8425de91690d")
                        });
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Entities.AppRoleClaims", b =>
                {
                    b.HasOne("HR.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUser", b =>
                {
                    b.HasOne("HR.Domain.Entities.AppCompany", "Company")
                        .WithMany("Personnels")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Company");
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUserAdvance", b =>
                {
                    b.HasOne("HR.Domain.Entities.AppUser", "AppUser")
                        .WithMany("AppUserAdvances")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUserCliams", b =>
                {
                    b.HasOne("HR.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUserLogin", b =>
                {
                    b.HasOne("HR.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUserRole", b =>
                {
                    b.HasOne("HR.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUserToken", b =>
                {
                    b.HasOne("HR.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HR.Domain.Entities.AppCompany", b =>
                {
                    b.Navigation("Personnels");
                });

            modelBuilder.Entity("HR.Domain.Entities.AppUser", b =>
                {
                    b.Navigation("AppUserAdvances");
                });
#pragma warning restore 612, 618
        }
    }
}