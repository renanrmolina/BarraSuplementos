using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BarraSuplementos.Models;
using BarraSuplementos.Data;
using BarraSuplementos.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BarraSuplementos.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM home = new() {
            Categorias = _context.Categorias.Where(c => c.Destaque).ToList(),
            Produtos = _context.Produtos.Take(8).ToList()
        };
        return View(home);
    }

    public IActionResult Produtos()
    {
        HomeVM home = new() {
            Categorias = _context.Categorias.ToList(),
            Produtos = _context.Produtos.ToList()
        };
        return View(home);
    }

    public IActionResult Detalhe(int id)
    {
        var produto = _context.Produtos.Where(p => p.Id == id)
            .Include(p => p.Categoria)
            .Include(p => p.Marca)
            .SingleOrDefault();
        if (produto == null)
            return NotFound();
        return View(produto);
    }

    public IActionResult FaleConosco()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
