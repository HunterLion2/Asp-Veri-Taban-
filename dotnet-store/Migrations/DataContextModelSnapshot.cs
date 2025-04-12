﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_store.Models;

#nullable disable

namespace dotnet_store.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("dotnet_store.Models.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Kategori");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KategoriAdi = "Telefon",
                            url = "telefon"
                        },
                        new
                        {
                            Id = 2,
                            KategoriAdi = "Elektronik",
                            url = "elektronik"
                        },
                        new
                        {
                            Id = 3,
                            KategoriAdi = "Beyaz Eşya",
                            url = "beyaz-esya"
                        },
                        new
                        {
                            Id = 4,
                            KategoriAdi = "Giyim",
                            url = "giyim"
                        },
                        new
                        {
                            Id = 5,
                            KategoriAdi = "Kozmetik",
                            url = "kozmetik"
                        });
                });

            modelBuilder.Entity("dotnet_store.Models.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Aktif")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Anasayfa")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Fiyat")
                        .HasColumnType("REAL");

                    b.Property<int>("KategoriId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Smilar")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UrunAdi")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aciklama = "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş",
                            Aktif = true,
                            Anasayfa = false,
                            Fiyat = 10000.0,
                            KategoriId = 1,
                            Resim = "1.jpeg",
                            Smilar = false,
                            UrunAdi = "Apple Watch 7"
                        },
                        new
                        {
                            Id = 2,
                            Aciklama = "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş",
                            Aktif = false,
                            Anasayfa = true,
                            Fiyat = 20000.0,
                            KategoriId = 2,
                            Resim = "2.jpeg",
                            Smilar = false,
                            UrunAdi = "Apple Watch 8"
                        },
                        new
                        {
                            Id = 3,
                            Aciklama = "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş",
                            Aktif = true,
                            Anasayfa = false,
                            Fiyat = 30000.0,
                            KategoriId = 2,
                            Resim = "3.jpeg",
                            Smilar = true,
                            UrunAdi = "Apple Watch 9"
                        },
                        new
                        {
                            Id = 4,
                            Aciklama = "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş",
                            Aktif = true,
                            Anasayfa = false,
                            Fiyat = 40000.0,
                            KategoriId = 1,
                            Resim = "4.jpeg",
                            Smilar = false,
                            UrunAdi = "Apple Watch 10"
                        },
                        new
                        {
                            Id = 5,
                            Aciklama = "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş",
                            Aktif = false,
                            Anasayfa = true,
                            Fiyat = 50000.0,
                            KategoriId = 3,
                            Resim = "5.jpeg",
                            Smilar = true,
                            UrunAdi = "Apple Watch 11"
                        },
                        new
                        {
                            Id = 6,
                            Aciklama = "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş",
                            Aktif = true,
                            Anasayfa = true,
                            Fiyat = 60000.0,
                            KategoriId = 4,
                            Resim = "6.jpeg",
                            Smilar = true,
                            UrunAdi = "Apple Watch 12"
                        },
                        new
                        {
                            Id = 7,
                            Aciklama = "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş",
                            Aktif = true,
                            Anasayfa = false,
                            Fiyat = 70000.0,
                            KategoriId = 3,
                            Resim = "7.jpeg",
                            Smilar = false,
                            UrunAdi = "Apple Watch 13"
                        },
                        new
                        {
                            Id = 8,
                            Aciklama = "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş",
                            Aktif = true,
                            Anasayfa = true,
                            Fiyat = 80000.0,
                            KategoriId = 5,
                            Resim = "8.jpeg",
                            Smilar = false,
                            UrunAdi = "Apple Watch 14"
                        });
                });

            modelBuilder.Entity("dotnet_store.Models.Urun", b =>
                {
                    b.HasOne("dotnet_store.Models.Kategori", "Kategori")
                        .WithMany("Uruns")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("dotnet_store.Models.Kategori", b =>
                {
                    b.Navigation("Uruns");
                });
#pragma warning restore 612, 618
        }
    }
}
