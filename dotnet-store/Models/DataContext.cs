using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;


public class DataContext : DbContext {
    // tanımlanan her bir DbSet, veritabanındaki bir tabloya karşılık gelir.
    // DbSet üzerinden, veritabanındaki ilgili tabloya sorgular yapabilir, veri ekleyebilir, güncelleyebilir veya silebilirsiniz.
    public DbSet<Urun> Urunler {get; set;}

    // Veritabanında bir Urunler tablosunu temsil eder.
    // Urun adında bir model sınıfınız olduğunu varsayar. Bu model, Urunler tablosunun yapısını tanımlar.
    // Uygulama içinde Urunler üzerinden sorgular yaparak Urun tablosundaki verilere erişebilirsiniz.

}

