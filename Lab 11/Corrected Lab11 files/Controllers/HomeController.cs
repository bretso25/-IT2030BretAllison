using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;
using System.Diagnostics;


public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult FAQ()
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Services()
    {
        return View();
    }
   [HttpGet]
    public IActionResult Tools()
    {
        HttpContext.Session.SetString("Course", "IT2030");
        HttpContext.Session.SetString("StudentID", "S00042043");
        HttpContext.Session.SetInt32("CurrentDate", 2022125);

        ViewBag.FV = 0;
        ViewBag.Total = 0;
        return View();
    }
    [HttpPost]
    public IActionResult Tools(FutureValueModel model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.FV = model.CalculateFutureValue();
            ViewBag.Total = model.CalculateTotal();
        }
        else
        {
            ViewBag.FV = 0;
            ViewBag.Total = 0;
        }
        return View(model);
    }

}
