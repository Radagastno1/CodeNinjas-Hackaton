using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using CORE.Interfaces;

namespace MVC.Controllers;

public class TrackController : Controller
{
    private readonly ILogger<TrackController> _logger;
    private readonly Iservice<CORE.Entities.Track> _trackService;

    public TrackController(ILogger<TrackController> logger, Iservice<CORE.Entities.Track> trackService)
    {
        _logger = logger;
        _trackService = trackService;
    }

    public IActionResult Go(int trackId)
    {
        var track = _trackService.GetById(trackId);
        return View(track);
    }
}
