namespace dotnet_store.Models;

// Aslında bizim burada oluşturmuş olduğumuz "models" değeri bizim veri tabanında bizim istediğimiz bilgilerdir 
// yani aslında biz burada bir veri tabanının şablonunu oluşturduk.
public class Urun {
    public int Id { get; set; }
    public string? UrunAdi { get; set; }
    public double Fiyat { get; set; }
    public string Aciklama { get; set; }
    public bool Aktif { get; set; }
    public string Resim { get; set; }
    public bool Anasayfa {get; set;}
}   

