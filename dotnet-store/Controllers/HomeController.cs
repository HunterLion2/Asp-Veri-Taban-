using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_store.Models;

namespace dotnet_store.Controllers;

public class HomeController : Controller
{
    private readonly DataContext _context;
    
    public HomeController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        var urunler = _context.Urunler.Where(urun => urun.Aktif && urun.Anasayfa).ToList(); // Veritabanından ürünleri al
        ViewData["Kategoriler"] = _context.Kategoriler.ToList();
        ViewData["Slider"] = _context.Sliders.ToList();
        return View(urunler); // Index.cshtml'e model olarak gönder
    }
}
