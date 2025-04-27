using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Controllers;

public class KategoriController : Controller
{
    private readonly DataContext _context;
    public KategoriController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        var kategoriler = _context.Kategoriler.Select(i => new KategoriGetModel
        {
            Id = i.Id,
            KategoriAdi = i.KategoriAdi,
            Url = i.Url,
            UrunSayisi = i.Uruns.Count
        }).ToList();
        return View(kategoriler);
    }

    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(KategoriCreateModel model)
    {
        var entity = new Kategori
        {
            KategoriAdi = model.KategoriAdi,
            Url = model.Url,
        };

        _context.Kategoriler.Add(entity);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    // Aslında burada Kategoriler içerisinden aldığım bilgiyi Select seçeneği ile KategoriEditModel'e gönderip eşitletip sonrasında kullanıyorum bu sayede daha düzenli bir yapım oluyor.
    public ActionResult Edit(int id) {
        var entity = _context.Kategoriler.Select(i => new KategoriEditModel{
            Id = i.Id,
            KategoriAdi = i.KategoriAdi,
            Url = i.Url
        }).FirstOrDefault(i => i.Id == id);
        return View(entity);
    }

    [HttpPost]
    public ActionResult Edit(int id, KategoriEditModel model)
    {
        if(id != model.Id) {
            return NotFound();
        }

        var entity = _context.Kategoriler.FirstOrDefault(i => i.Id == model.Id);

        if(entity != null) {

            entity.KategoriAdi = model.KategoriAdi;
            entity.Url = model.Url;

            _context.SaveChanges();

            // TempData buradaki bilgiyi başka bir controller da kullanabilmemizi sağlar.
            TempData["Message"] = $"{model.KategoriAdi} Kategorisi Güncellendi";

            return RedirectToAction("Index");
        }

        return View(model);
    }

}