namespace dotnet_store.Models;

// Model

public class KategoriGetModel {

    public int Id { get; set; }
    
    public string KategoriAdi { get; set; } = null!;
    
    public string url { get; set; } = null!;

    public int UrunSayisi { get; set; }

}
