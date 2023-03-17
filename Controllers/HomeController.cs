using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WhatYouSippin_FinalProject.Models;

namespace WhatYouSippin_FinalProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Drink drink = new Drink();
        return View(drink);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult ViewDrink(Drink drink)
    {
        var cocktail = APIDrinks.callAPI(drink.strDrink);
        return View(cocktail);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

