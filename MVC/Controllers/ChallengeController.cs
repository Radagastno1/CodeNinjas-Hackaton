using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class ChallengeController : Controller
{
    private readonly ILogger<ChallengeController> _logger;

    public ChallengeController(ILogger<ChallengeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(UserViewModel userViewModel)
    {
        return View(userViewModel);
    }

}
