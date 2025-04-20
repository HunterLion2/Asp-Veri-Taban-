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
            UrunSayisi = i.Uruns.Count
        }).ToList();
        return View(adminkategori);
    }

    public ActionResult Create() {
        
        return View();
    }

}
