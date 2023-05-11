using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CORE.Entities;
using Microsoft.Extensions.Logging;

namespace INFRASTRUCTURE.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class Challangecontroller : ControllerBase
    {
        private readonly ILogger<Challangecontroller> _logger;
        private readonly Challenge _chellange;

        public Challangecontroller(ILogger<Challangecontroller> logger, Challenge challenge)
        {
            _logger = logger;
            _chellange = challenge;
        }

        public async IActionResult<Challenge> CreateUserChallenge([FromBody] Challenge challenge)
        {
            var createChallenge = await this._chellange.CreateChallenge(challenge);

            if (!ModelState.IsValid)
            {
                throw new ArgumentNullException();
                return BadRequest();
            }
        }
    }
}
