using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimaWeb.Models;
using System.Collections.Generic;
using System.Diagnostics;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    static List<Prodotto>? Prodotti = new List<Prodotto>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        dbContext db = new dbContext();
        db.Registrazioni.Add(new Registrazione { Nome = "George", Cognome = "Lefter" });
        db.SaveChanges();
        return View();
    }
    public IActionResult Privacy()
    {
        string? nomeUtente = HttpContext.Session.GetString("NomeUtente");
        if (string.IsNullOrEmpty(nomeUtente))
        return Redirect("\\home\\index");
        return View();
    }

    [HttpGet]
    public IActionResult Purchase()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Cart(Prodotto prodottis)
    {
        Prodotti.Add(prodottis);
        return View(Prodotti);
    }

    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Riepilogo(Registrazione r)
    {
         HttpContext.Session.SetString("NomeUtente",r.Nome);
        return View(r);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}