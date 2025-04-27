namespace dotnet_store.Models;
using System.ComponentModel.DataAnnotations;
public class KategoriEditModel
{
    public int Id { get; set; }
    
    [Display(Name = "Kategori Adı")]
    public string KategoriAdi { get; set; } = null!;

    [Display(Name = "Url")]
    public string Url { get; set; } = null!;
}

