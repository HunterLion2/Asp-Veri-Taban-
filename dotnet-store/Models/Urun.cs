namespace dotnet_store.Models;

// Aslında bizim burada oluşturmuş olduğumuz "models" değeri bizim veri tabanında bizim istediğimiz bilgilerdir 
// yani aslında biz burada bir veri tabanının şablonunu oluşturduk.
public class Urun {
    public int Id { get; set; }
    public string? UrunAdi { get; set; } = null!;
    public double Fiyat { get; set; }
    public string Aciklama { get; set; }
    public bool Aktif { get; set; }
    public string Resim { get; set; }
    public bool Anasayfa {get; set;}
    public bool Smilar { get; set; }
    public int KategoriId { get; set; }
    // Aslında benim burada yapmış olduğum şey Urun tablsonda oluşturduğumuz Kategori kolonunu , Kategori tablosuna bağlamış oluruz burada
    // alınan veri KategoriId'dir sonuna Id geldiği zaman aynı s takısında olduğu gibi bir anlam taşır.
    public Kategori Kategori { get; set; } = null!;
}   

