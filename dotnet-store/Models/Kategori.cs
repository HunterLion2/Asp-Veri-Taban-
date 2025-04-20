namespace dotnet_store.Models;

// Entity

public class Kategori {

    public int Id { get; set; }
    
    public string KategoriAdi { get; set; } = null!;
    
    public string url { get; set; } = null!;

    // Burada Urun bölümünün sonuna s takısını getirdiğimiz zaman bu değerin bir Urun modeline bağlandığını anlar.
    public List<Urun> Uruns {get; set;} = new();

}
