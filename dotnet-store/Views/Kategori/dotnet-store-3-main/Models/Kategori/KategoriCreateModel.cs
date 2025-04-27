namespace dotnet_store.Models;
using System.ComponentModel.DataAnnotations;
public class KategoriCreateModel
{
    [Display(Name = "Kategori Adı")]
    public string KategoriAdi { get; set; } = null!;

    [Display(Name = "Url")]
    public string Url { get; set; } = null!;
}

