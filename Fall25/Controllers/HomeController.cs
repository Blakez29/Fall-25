using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROBLEMS.MODELS;

namespace Fall25.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var test_model = new PROBLEM() { PROMPT = "How to start coding", PRIMARY_INPUT = "Effort", RESULT = "Pending" };
        Console.WriteLine(test_model.PROMPT);
        Console.WriteLine(test_model.RESULT);
        return View();
    }

    public IActionResult Privacy()
    {
       
        return View();
    }
}
