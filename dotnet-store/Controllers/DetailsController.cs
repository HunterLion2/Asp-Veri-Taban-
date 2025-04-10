using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class DetailsController:Controller {
    
    private readonly DataContext _context;
    public DetailsController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index(int id) {
        // Burada ki FirstOrDefault değeri ile Find değeri aynı işlevi görür.
        
        // var urundetails = _context.Urunler.FirstOrDefault(urun => urun.Id == id);
        var urundetails = _context.Urunler.Find(id);

        var smilarimage = _context.Urunler.Where(urun => urun.Smilar == true).ToList();

        ViewBag.SimilarProducts = smilarimage;
        return View(urundetails);
    }
}