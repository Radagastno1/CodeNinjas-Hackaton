<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 9882940db1776b4b9a72eca8ee7c8c87b4c1c84e
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CORE.Entities;
using CORE.Services;
using CORE.Interfaces;
using Microsoft.Extensions.Logging;
<<<<<<< HEAD

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
>>>>>>> 2ee4ce451ecb0166ad1bdb360173a803bd2edbef

             return Ok();
         }

         [HttpPost]
        public async Task<ActionResult<User>> UserTrack([FromBody] Track track)
         {
             var trackChallenge = await this.UserToTrackChallenge(track);
              if (trackChallenge == null)
            {
                  return BadRequest();
            }

<<<<<<< HEAD
              return Ok();
         }
     }
}
=======
//         [HttpPost]
//         public async Task<ActionResult<Track>> CreateNewTrack([FromBody] Track track)
//         {
//             var createChallenge = await this._track.CreateChallenge(track);
=======

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
>>>>>>> 9882940db1776b4b9a72eca8ee7c8c87b4c1c84e

            if (createChallenge == null)
            {
                return BadRequest();
            }

             return Ok();
     }

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
<<<<<<< HEAD
//     }
// }
>>>>>>> 2ee4ce451ecb0166ad1bdb360173a803bd2edbef
=======
   }
 }
>>>>>>> 9882940db1776b4b9a72eca8ee7c8c87b4c1c84e
