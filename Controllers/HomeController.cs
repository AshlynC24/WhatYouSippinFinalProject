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
    public IActionResult DrinkIndex(Drink drink)
    {
        var input = APIDrinks.GetDrinks(drink.strDrink);
        return View(input);
    }
    public IActionResult DrinkInfoIndex(int id)//Added this to show drink id info
    {
        var moreInfo = APIDrinks.GetDrinkInfo(id);
        return View(moreInfo);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

