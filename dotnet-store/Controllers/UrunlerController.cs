using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class UrunlerController:Controller {

    // Dependecy Indection => DI 

    // Bu kod, Dependency Injection kullanarak DataContext nesnesini UrunController sınıfına enjekte eder.
    // DataContext, veritabanı işlemleri için kullanılan bir bağlamdır.
    // DI sayesinde, bağımlılıklar dışarıdan sağlanır, bu da kodun daha esnek, test edilebilir ve sürdürülebilir olmasını sağlar.

    private readonly DataContext _context;
    public UrunlerController(DataContext context)
    {
        _context = context;
    }

    // Yukarıda yazıdğım Dependecy Indection özelliği aslında DbContext’in içerisindeki değerleri Controller’a çekmek içindir.

    public ActionResult Index() {
        return View();
    }

    public ActionResult List(string url, string q) {

        // AsQueryable() ile oluşturulan sorgular, yalnızca sonuçlara erişildiğinde (örneğin, ToList() çağrıldığında) çalıştırılır.
        // Bu, gereksiz veritabanı sorgularını önler ve performansı artırır.

        var query = _context.Urunler.Where(i => i.Aktif);

        if(!string.IsNullOrEmpty(url)) {
            // Filtreleme
            query = query.Where(i => i.Kategori.url == url);
        }

        if(!string.IsNullOrEmpty(q)) {
            // Contains() değeri girilen q değerinin UrunAdi içerisinde harf harf aranmasını sağlar.

            // Burada yaptığım şey aslında filtreleme yaparken aranan değer olan UrunAdlarını ve Benim inputa girdiğim değeri ToLower ile ikisinide küçük harf yaparım bu sayede büyük harf tutmamazlığı yaşamam.
            query = query.Where(i => i.UrunAdi.ToLower().Contains(q.ToLower()));

            ViewData["q"] = q;

            // Filtreleme
        }

        // var urunler = _context.Urunler.Where(urun => urun.Aktif && urun.Kategori.url == url).ToList();

        return View(query.Where(i => i.Aktif).ToList()); // Bu şekilde en son ToList değerine döndürürüz.
    }

    public ActionResult Details(int Id) {

        var urun = _context.Urunler.Find(Id);

        if(urun == null) {
            // Burada sadece başta bir değer yazdığımız zaman "List" gibi o zaman mevcut controller içerisinden List bölümüne gider.
            // Eğer "List" den sonra ikinci bir değer belirtirseniz bu belirticeğiniz değer Controller ismi olur bunu da başka controllerdan sayfa çağırmak istediğimiz zaman yaparız.
            return RedirectToAction("List"); // Burası detay sayfasına geldiğimiz zaman eğer urun değerinin ıd si bulunamazsa o zaman RedirectToAction("") metodu ile başka bir sayfaya yönlendirme yapabiliriz.
        }

        // Take değeri istenilen değerlerin içerisinden içine hangi değer yazılırsa o kadarını getirir.

        ViewData["BenzerUrunler"] = _context.Urunler.Where(i => i.Aktif && i.KategoriId == urun.KategoriId && i.Id != Id).Take(4).ToList();


        var urundetails = _context.Urunler.Find(Id);

        var smilarimage = _context.Urunler.Where(urun => urun.Smilar == true).ToList();

        ViewBag.SimilarProducts = smilarimage;

        return View(urun);
    }

}
