namespace dotnet_store.Models;
using System.ComponentModel.DataAnnotations;

public class UrunCreateModel {

    [Display(Name = "Ürün Adı")]
    public string UrunAdi { get; set; } = null!;
    
    [Display(Name = "Ürün Fiyat")]

    public double Fiyat { get; set; }

    [Display(Name = "Ürün Resmi")]

    public string? Resim { get; set; }
    public string? Aciklama { get; set; }
    public bool Aktif { get; set; }
    public bool Anasayfa { get; set; }
    public int KategoriId { get; set; }
}

