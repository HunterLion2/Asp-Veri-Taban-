using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;


public class DataContext : DbContext
{
    // tanımlanan her bir DbSet, veritabanındaki bir tabloya karşılık gelir.
    // DbSet üzerinden, veritabanındaki ilgili tabloya sorgular yapabilir, veri ekleyebilir, güncelleyebilir veya silebilirsiniz.

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Slider> Sliders {get; set;}

    public DbSet<Urun> Urunler { get; set; }

    public DbSet<Kategori> Kategoriler { get; set; }

    // Veritabanında bir Urunler tablosunu temsil eder.
    // Urun adında bir model sınıfınız olduğunu varsayar. Bu model, Urunler tablosunun yapısını tanımlar.
    // Uygulama içinde Urunler üzerinden sorgular yaparak Urun tablosundaki verilere erişebilirsiniz.

    // OnModelCreating, Entity Framework Core'da veritabanı modeli oluşturulurken çağrılan bir metottur.
    // Bu metot, veritabanı tablolarının ve ilişkilerinin nasıl oluşturulacağını özelleştirmek için kullanılır.

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Aslında buraya çağırılan bilgiler direkt olarak veritabanı açıldığında gelicek olan bilgilerdir.
        // Buraya yazılan bilgileri kaydetmek için "Mignations" oluşturulur yani aslında bu şekilde kalıcı bilgi oluşturulduktan sonra Migrations değeri çağırılır.

        modelBuilder.Entity<Slider>().HasData(
            new List<Slider> {
                new Slider() {Id = 1, Resim = "slider-1.jpeg"},
                new Slider() {Id = 2, Resim = "slider-2.jpeg"},
                new Slider() {Id = 3, Resim = "slider-3.jpeg"}
            }
        );

        modelBuilder.Entity<Kategori>().HasData(

            new List<Kategori> {
                new Kategori() {Id = 1, KategoriAdi= "Telefon", url = "telefon"},
                new Kategori() {Id = 2, KategoriAdi= "Elektronik", url = "elektronik"},
                new Kategori() {Id = 3, KategoriAdi= "Beyaz Eşya", url = "beyaz-esya"},
                new Kategori() {Id = 4, KategoriAdi= "Giyim", url = "giyim"},
                new Kategori() {Id = 5, KategoriAdi= "Kozmetik", url = "kozmetik"},
                new Kategori() {Id = 6, KategoriAdi= "Kategori 1", url = "kategori-1"},
                new Kategori() {Id = 7, KategoriAdi= "Kategori 2", url = "kategori-2"},
                new Kategori() {Id = 8, KategoriAdi= "Kategori 3", url = "kategori-3"},
                new Kategori() {Id = 9, KategoriAdi= "Kategori 4", url = "kategori-4"},
                new Kategori() {Id = 10, KategoriAdi= "Kategori 5", url = "kategori-5"},
            }
        );

        modelBuilder.Entity<Urun>().HasData(
            new List<Urun>() {
                new Urun() { Id = 1, UrunAdi= "Apple Watch 7", Fiyat= 10000, Aktif= true, Resim = "1.jpeg", Anasayfa= false, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", Smilar= false, KategoriId = 1},
                new Urun() { Id = 2, UrunAdi= "Apple Watch 8", Fiyat= 20000, Aktif= false, Resim = "2.jpeg", Anasayfa= true, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", Smilar= false, KategoriId = 2},
                new Urun() { Id = 3, UrunAdi= "Apple Watch 9", Fiyat= 30000, Aktif= true, Resim = "3.jpeg", Anasayfa= false, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", Smilar= true, KategoriId = 2},
                new Urun() { Id = 4, UrunAdi= "Apple Watch 10", Fiyat= 40000, Aktif= true, Resim = "4.jpeg", Anasayfa= false, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", Smilar= false, KategoriId = 1},
                new Urun() { Id = 5, UrunAdi= "Apple Watch 11", Fiyat= 50000, Aktif= false, Resim = "5.jpeg", Anasayfa= true, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", Smilar= true, KategoriId = 3},
                new Urun() { Id = 6, UrunAdi= "Apple Watch 12", Fiyat= 60000, Aktif= true, Resim = "6.jpeg", Anasayfa= true, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", Smilar= true, KategoriId = 4},
                new Urun() { Id = 7, UrunAdi= "Apple Watch 13", Fiyat= 70000, Aktif= true, Resim = "7.jpeg", Anasayfa= false, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", Smilar= false, KategoriId = 3},
                new Urun() { Id = 8, UrunAdi= "Apple Watch 14", Fiyat= 80000, Aktif= true, Resim = "8.jpeg", Anasayfa= true, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", Smilar= false, KategoriId = 5},
            }
        );
    }

    // ---------------------------------------------------------------

    // 3. modelBuilder.Entity<Urun>()

    // modelBuilder.Entity<Urun>() ifadesi, Urun modeline ait yapılandırmaları tanımlamak için kullanılır.
    // Bu, Urun modelinin veritabanındaki bir tabloya karşılık geldiğini belirtir.

    // 4. HasData()

    // HasData() metodu, veritabanına başlangıç verileri (seed data) eklemek için kullanılır.
    // Bu veriler, veritabanı oluşturulduğunda otomatik olarak tabloya eklenir.
    // Örneğin, burada Urun tablosuna 6 adet ürün eklenmiştir.

    // ----------------------------------------------------------------

}

