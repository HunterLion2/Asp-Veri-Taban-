using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;


public class DataContext : DbContext {
    // tanımlanan her bir DbSet, veritabanındaki bir tabloya karşılık gelir.
    // DbSet üzerinden, veritabanındaki ilgili tabloya sorgular yapabilir, veri ekleyebilir, güncelleyebilir veya silebilirsiniz.

    public DataContext(DbContextOptions<DataContext> options) : base(options) {

    }

    public DbSet<Urun> Urunler {get; set;}

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

        modelBuilder.Entity<Urun>().HasData(
            new List<Urun>() {
                new Urun() { Id = 1, UrunAdi= "Apple Watch 7", Fiyat= 10000, Aktif= true, Resim = "1.jpeg", Anasayfa= false, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş"},
                new Urun() { Id = 2, UrunAdi= "Apple Watch 8", Fiyat= 20000, Aktif= false, Resim = "2.jpeg", Anasayfa= true, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş" },
                new Urun() { Id = 3, UrunAdi= "Apple Watch 9", Fiyat= 30000, Aktif= true, Resim = "3.jpeg", Anasayfa= false, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş"},
                new Urun() { Id = 4, UrunAdi= "Apple Watch 10", Fiyat= 40000, Aktif= true, Resim = "4.jpeg", Anasayfa= false, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş"},
                new Urun() { Id = 5, UrunAdi= "Apple Watch 11", Fiyat= 50000, Aktif= false, Resim = "5.jpeg", Anasayfa= true, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş"},
                new Urun() { Id = 6, UrunAdi= "Apple Watch 12", Fiyat= 60000, Aktif= true, Resim = "6.jpeg", Anasayfa= true, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş"},
                new Urun() { Id = 7, UrunAdi= "Apple Watch 13", Fiyat= 70000, Aktif= true, Resim = "7.jpeg", Anasayfa= false, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş"},
                new Urun() { Id = 8, UrunAdi= "Apple Watch 14", Fiyat= 80000, Aktif= true, Resim = "8.jpeg", Anasayfa= true, Aciklama="asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş"},
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

