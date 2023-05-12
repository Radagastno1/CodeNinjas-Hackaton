<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CORE.Entities;
using CORE.Services;
using CORE.Interfaces;
using Microsoft.Extensions.Logging;

namespace INFRASTRUCTURE.APIControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Trackcontroller : ControllerBase
    {
        private readonly ILogger<Challangecontroller> _logger;
        private readonly Challenge _challenge;
        private readonly Iservice<CORE.Entities.Track> _service;

        public Trackcontroller(ILogger<Challangecontroller> logger, Challenge challenge, Iservice<CORE.Entities.Track> service)
        {
            _logger = logger;
            _challenge = challenge;
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Track>> CreateNewTrack([FromBody] Track track)
        {
            var createChallenge = await this._service.add(track);

            if (createChallenge == null)
            {
                return BadRequest();
            }
=======
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using CORE.Entities;
// using CORE.Services;
// using Microsoft.Extensions.Logging;

// namespace INFRASTRUCTURE.APIControllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class Trackcontroller : ControllerBase
//     {
//         private readonly ILogger<Challangecontroller> _logger;
//         private readonly Challenge _challenge;
//         private readonly Track _track;

//         public Challangecontroller(ILogger<Challangecontroller> logger, Challenge challenge, Track track)
//         {
//             _logger = logger;
//             _challenge = challenge;
//             _track = track;
//         }

//         [HttpPost]
//         public async Task<ActionResult<Track>> CreateNewTrack([FromBody] Track track)
//         {
//             var createChallenge = await this._track.CreateChallenge(track);

//             if (trackChallenge == null)
//             {
//                 return BadRequest();
//             }
>>>>>>> b71e6091cb2d46c22cb600db07e5fb23b9966c9e

//             return Ok();
//         }

//         // [HttpPost]
//         // public async Task<ActionResult<User>> UserTrack([FromBody] Track track)
//         // {
//         //     var trackChallenge = await this.UserToTrackChallenge(track);

//         //     if (trackChallenge == null)
//         //     {
//         //         return BadRequest();
//         //     }

//         //     return Ok();
//         // }
//     }
// }
