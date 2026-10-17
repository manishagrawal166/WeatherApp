using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var sum = AddTwoNumbers(10,20);
        return View();
    }

    public IActionResult Privacy()
    {
        var sum = AddTwoNumbers(10,20);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private int AddTwoNumbers(int a, int b)
    {
        return a+b;
    }


}
