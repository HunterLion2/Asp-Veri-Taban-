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

    public IActionResult Index()
    {
        var urunler = _context.Urunler.ToList(); // Veritabanından ürünleri al
        return View(urunler); // Index.cshtml'e model olarak gönder
    }
}
