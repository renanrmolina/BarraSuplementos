﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BarraSuplementos.Models;

namespace BarraSuplementos.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Produtos()
    {
        return View();
    }

    public IActionResult Detalhe()
    {
        return View();
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
