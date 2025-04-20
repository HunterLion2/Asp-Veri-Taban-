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
        var adminkategori = _context.Kategoriler.Include(i => i.Uruns).ToList();
        return View(adminkategori);
    }

}
