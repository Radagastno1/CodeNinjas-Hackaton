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
    public class Usercontroller : ControllerBase
    {
        private readonly ILogger<Usercontroller> _logger;
        private readonly User _user;

        public Usercontroller(ILogger<Usercontroller> logger, User user)
        {
            _logger = logger;
            _user = user;
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateNewUser([FromBody] User user)
        {

        }
        [HttpPost]
        public async Task<ActionResult<User>> UpdateUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User object is null.");
            }

            try
            {
                // _dbContext.User.Add(user);
                // await _dbContext.SaveChangesAsync();

                // return CreatedAtAction(nameof(CreateUser), new { id = user.UserId }, user);
            }

            catch (Exception ex)
            {

                Console.WriteLine($"Error saving the user to the database: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while saving the user.");
            }

        }
        [HttpPost]
        public async Task<ActionResult<User>> DeleteUser()
        {

        }
        //  public IActionResult<User> CreateNewUser([FromBody] User user)
        // {

        // }

    }
}