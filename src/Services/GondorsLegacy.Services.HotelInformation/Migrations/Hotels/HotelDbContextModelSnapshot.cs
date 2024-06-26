﻿// <auto-generated />
using System;
using GondorsLegacy.Services.HotelInformation.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GondorsLegacy.Services.HotelInformation.Migrations.Hotels
{
    [DbContext(typeof(HotelDbContext))]
    partial class HotelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApartmentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsSecure")
                        .HasColumnType("bit");

                    b.Property<string>("Labels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POBox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("SecurityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Addresses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ca937045-e20d-4651-89b1-3dbebd8b1156"),
                            AdditionalInfo = "NULL",
                            ApartmentNumber = "5",
                            BuildingNumber = "9",
                            City = "İstanbul",
                            Country = "Türkiye",
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 21, DateTimeKind.Unspecified).AddTicks(6217), new TimeSpan(0, 3, 0, 0, 0)),
                            District = "Gaziosmanpaşa",
                            Floor = "1",
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            IsSecure = true,
                            Labels = "Özel Mülk",
                            Latitude = 34.100000000000001,
                            Longitude = 41.5,
                            Neighborhood = "Yenidoğan",
                            POBox = "34100",
                            PostCode = "34100",
                            Province = "İstanbul",
                            SecurityCode = "f4e465s1",
                            Street = "Kuyu",
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 21, DateTimeKind.Unspecified).AddTicks(6291), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(1703), new TimeSpan(0, 3, 0, 0, 0)),
                            Description = "Açıklama",
                            EmailAddress = "info@salvatorresort.com",
                            Name = "SALVATOR RESORT HOTEL",
                            Phone = "05303288200",
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(1718), new TimeSpan(0, 3, 0, 0, 0)),
                            Website = "https://www.salvatorresort.com"
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelCustomerReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Dislikes")
                        .HasColumnType("int");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsHelpful")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRecommended")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelCustomerReviews", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5ae56c1c-e4f8-4dce-a348-7e97e10e502d"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 3, 0, 0, 0)),
                            CustomerId = new Guid("7f1831d1-4fc0-4899-afab-156ed1ab5c24"),
                            Dislikes = 10,
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            IsHelpful = true,
                            IsRecommended = true,
                            IsVerified = true,
                            Likes = 10,
                            ReviewDate = new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Local).AddTicks(3621),
                            ReviewText = "Bu otele bayıldım",
                            ReviewTitle = "Bu otele bayıldım!",
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("e6c1fdf7-40b7-44a6-9d53-1bac83eea279"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(3628), new TimeSpan(0, 3, 0, 0, 0)),
                            CustomerId = new Guid("93803ce2-71d1-4b23-88e6-13c3a5f63398"),
                            Dislikes = 12,
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            IsHelpful = true,
                            IsRecommended = true,
                            IsVerified = true,
                            Likes = 17,
                            ReviewDate = new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Local).AddTicks(3629),
                            ReviewText = "Bu otele güzeldi",
                            ReviewTitle = "Bu otel güzeldi!",
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(3630), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelPolicy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HotelPolicyType")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelPolicies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("78850b86-a52b-45fa-b33f-f88f61d54273"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(5061), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelPolicyType = 14,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(5068), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("0d0d277b-4806-4e6b-a043-e5cde90def76"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(5072), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelPolicyType = 56,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(5073), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("3ab6b852-2c64-474f-9d2a-b5c7b027d186"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(5076), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelPolicyType = 44,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(5077), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("d7a90fc6-8073-4b0e-91dc-01f226bbac10"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(5080), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelPolicyType = 23,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(5081), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelRating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Amenities")
                        .HasColumnType("real");

                    b.Property<float>("Cleanliness")
                        .HasColumnType("real");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Location")
                        .HasColumnType("real");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<float>("ServiceQuality")
                        .HasColumnType("real");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<float>("ValueForMoney")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelRatings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d2e6cf3a-d001-4659-a10a-5d27272241b5"),
                            Amenities = 10f,
                            Cleanliness = 10f,
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(6309), new TimeSpan(0, 3, 0, 0, 0)),
                            Description = "NULL",
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            Location = 10f,
                            ServiceQuality = 10f,
                            Stars = 5,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(6315), new TimeSpan(0, 3, 0, 0, 0)),
                            ValueForMoney = 10f
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelRoom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelRooms", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("93abd8c4-2460-4839-a801-301272d4123f"),
                            Capacity = 50,
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(7492), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            RoomType = 0,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(7505), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("fe13f5b3-d735-473f-a510-307d9155deb0"),
                            Capacity = 75,
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(7515), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            RoomType = 3,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("e3454d91-301a-4c13-bc43-d008c744be09"),
                            Capacity = 80,
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(7520), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            RoomType = 5,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HotelServiceType")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelServices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8aaf0f3e-f150-4e9c-8da7-8f154e54a20e"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(8961), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelServiceType = 75,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(8973), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("33d5cf9a-b162-4bd1-9ccd-84ce176a3f22"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(8978), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelServiceType = 52,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(8979), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("7e3f89e2-be99-48e1-a43f-6d9aebd5a92b"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(8982), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelServiceType = 34,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(8983), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("f5c22a88-3e86-405c-86de-1b75bca1e98e"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(8986), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelServiceType = 9,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(8987), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("53d2af56-fcdf-407f-9a17-5b05dd0fc336"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(8990), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelServiceType = 73,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 4, 30, 16, 51, 35, 22, DateTimeKind.Unspecified).AddTicks(8991), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Address", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("Addresses")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelCustomerReview", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("HotelCustomerReviews")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelPolicy", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("Policies")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelRating", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("HotelRatings")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelRoom", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelService", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("Services")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.Hotel", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("HotelCustomerReviews");

                    b.Navigation("HotelRatings");

                    b.Navigation("Policies");

                    b.Navigation("Rooms");

                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
