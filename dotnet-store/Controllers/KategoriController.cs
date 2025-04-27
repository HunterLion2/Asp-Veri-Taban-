using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Controllers;

public class KategoriController : Controller {

    private readonly DataContext _context;

    public KategoriController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index() {
        // Burada yaptığımız olay Select ile Kategoriler değerini KategoriGetModel değerine dönüştürmüş oluruz bu sayede Bir entity yapısından model yapısına döndürmüş oluruz.
        var adminkategori = _context.Kategoriler.Select(i => new KategoriGetModel{
            // Burada sağ taraftaki değerler Entity den yani database den gelir sonrasında burada da bu değerleri Model yapısına dönüştürüyoruz.
            Id = i.Id,
            KategoriAdi = i.KategoriAdi,
            url = i.url,
            // Count değeri Kategoriler tablosunun eşleştiği tablonun , bir biri ile eşleştirdiğimiz değerini alır. Burada bu değer KategoriId değeridir.
            UrunSayisi = i.Uruns.Count
        }).ToList();
        return View(adminkategori);
    }

    // Get ile Post arasındaki fark Create sayfasında Post işlemi yapıldığında HttpPost bölümü bilgi çekme yapıldığında HttpGet işlemi yapılır.

    [HttpGet]
    public ActionResult Create() {
        
        return View();
    }

    [HttpPost]
    // Post edilen değerleri burada Create methodunun beklemesi gerekir.
    public ActionResult Create(string kategoriAdi, string kategoriUrl) {
        var entity = new Kategori {
            KategoriAdi = kategoriAdi,
            url = kategoriUrl
        };
        // Add metodu ile input'lardan alınan bilgileri Kategoriler tablosuna ekleme emirini veririz fakat SaveChanges demediğimiz sürece değişiklikler kaydedilmez.
        _context.Kategoriler.Add(entity);

        _context.SaveChanges();

        return RedirectToAction("Index"); // Bu sayede SaveChanges olduktan sonra sayfa yönlendirmesi yaparız.
        // return View(); Bu değeri yazmam çünkü submit olduğunda hala daha aynı sayfanın dönmesini istemem bu yüzden RedirectToAction("Index") diyerek Index sayfasına yönlendiririm.
    }
}
