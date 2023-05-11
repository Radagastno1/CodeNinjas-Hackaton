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

    public async Task<IActionResult> Go(int trackId)
    {
        //var track = await _trackService.GetById(trackId);

        //test
        var track = new CORE.Entities.Track()
        {
            latitude = 57.70657984036197M,
            longitude = 12.981750461096478M,
            track_name = "Kransmossen"
        };
        return View(track);
    }
}
