using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;
public class TrackController : Controller
{
    private readonly ILogger<TrackController> _logger;

    public TrackController(ILogger<TrackController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}
