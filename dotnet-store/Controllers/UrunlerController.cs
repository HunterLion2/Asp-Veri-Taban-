using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class UrunController:Controller {

    // Dependecy Indection => DI 

    // Bu kod, Dependency Injection kullanarak DataContext nesnesini UrunController sınıfına enjekte eder.
    // DataContext, veritabanı işlemleri için kullanılan bir bağlamdır.
    // DI sayesinde, bağımlılıklar dışarıdan sağlanır, bu da kodun daha esnek, test edilebilir ve sürdürülebilir olmasını sağlar.

    private readonly DataContext _context;
    public UrunController(DataContext context)
    {
        _context = context;
    }

    // Yukarıda yazıdğım Dependecy Indection özelliği aslında DbContext’in içerisindeki değerleri Controller’a çekmek içindir.

    public ActionResult Index() {
        return View();
    }

    public ActionResult List(string url) {
        var urunler = _context.Urunler.Where(urun => urun.Aktif && urun.Kategori.url == url).ToList();
        return View(urunler);
    }

}
