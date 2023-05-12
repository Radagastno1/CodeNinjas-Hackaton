<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CORE.Entities;
using CORE.Services;
using Microsoft.Extensions.Logging;
using CORE.Interfaces;

namespace INFRASTRUCTURE.APIControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Challangecontroller : ControllerBase
    {
        private readonly ILogger<Challangecontroller> _logger;
        private readonly Iservice<CORE.Entities.Challenge> _service;
        private readonly User _user;

        public Challangecontroller(ILogger<Challangecontroller> logger, Iservice<CORE.Entities.Challenge> service, User user)
        {
            _logger = logger;
            _service = service;
            _user = user;
        }

        [HttpPost]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode: 400)]
        public async Task<ActionResult<Challenge>> CreateUserChallenge([FromBody] Challenge challenge)
        {
            var createChallenge = await this._service.add(challenge);
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
//     public class Challangecontroller : ControllerBase
//     {
//         private readonly ILogger<Challangecontroller> _logger;
//         private readonly Challenge _challenge;
//         private readonly User _user;

//         public Challangecontroller(ILogger<Challangecontroller> logger, Challenge challenge, User user)
//         {
//             _logger = logger;
//             _challenge = challenge;
//             _user = user;
//         }

//         [HttpPost]
//         public async Task<ActionResult<Challenge>> CreateUserChallenge([FromBody] Challenge challenge)
//         {
//             var createChallenge = await this._challenge.CreateChallenge(challenge);
>>>>>>> b71e6091cb2d46c22cb600db07e5fb23b9966c9e

//             if (createChallenge == null)
//             {
//                 return BadRequest();
//             }

//             return Ok();
//         }

//         [HttpPost]
//         public async Task<ActionResult<User>> UserChallenge([FromBody] User user)
//         {
//             var userChallenge = await this.UserToUserChallenge(user);

//             if (userChallenge == null)
//             {
//                 return BadRequest();
//             }

//             return Ok();
//         }

//         [HttpGet]
//         public async Task<ActionResult<List<Challenge>>> GetAllChallanges()
//         {
//             var challangeList = await this._challenge.ChallangesList();
//             if (challangeList == null)
//             {
//                 return BadRequest();
//             }
//             return Ok();
//         }

//         [HttpGet("{int:id}")]
//         public async Task<ActionResult<Challenge>> GetChallengeById(int id)
//         {
//             var result = await this._challenge.ChallengeById(id);
//             if (result == null)
//             {
//                 return NotFound();
//             }
//             return Ok();
//         }
//     }
// }
