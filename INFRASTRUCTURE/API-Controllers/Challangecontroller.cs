using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CORE.Entities;
using CORE.Services;
using Microsoft.Extensions.Logging;

namespace INFRASTRUCTURE.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class Challangecontroller : ControllerBase
    {
        private readonly ILogger<Challangecontroller> _logger;
        private readonly Challenge _chellange;
        private readonly User _user;

        public Challangecontroller(ILogger<Challangecontroller> logger, Challenge challenge, User user)
        {
            _logger = logger;
            _chellange = challenge;
            _user = user;
        }

        [HttpPost]
        public async Task<IActionResult<Challenge>> CreateUserChallenge([FromBody] Challenge challenge)
        {
            var createChallenge = await this._chellange.CreateChallenge(challenge);

            if (!ModelState.IsValid)
            {
                throw new ArgumentNullException();
                return BadRequest();
            }
            return (IActionResult<Challenge>)Ok();
        }

        [HttpPost]
        public async Task<IActionResult<User>> UserChallenge([FromBody] User user)
        {
            var userChallenge = await this.UserToUserChallenge(user);

            if (!ModelState.IsValid)
            {
                throw new ArgumentException();
                return BadRequest();
            }
            return Ok();
        }
    }

    public interface IActionResult<T>
    {
    }
}
