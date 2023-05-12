// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using CORE.Entities;
// using Microsoft.Extensions.Logging;



// namespace INFRASTRUCTURE.APIControllers
// {
//     public class User
//     {
//         [ApiController]
//         [Route("api/[controller]")]
//         public class Usercontroller : ControllerBase
//         {
//             private readonly ILogger<Usercontroller> _logger;
//             private readonly User _user;

//             private readonly Challenge _challenge;

//             public Usercontroller(ILogger<Usercontroller> logger, User user, Challenge challenge)
//             {
//                 _challenge = challenge;
//                 _logger = logger;
//                 _user = user;
//             }

//             [HttpPost]
//             public async Task<ActionResult<User>> CreateNewUser([FromBody] User user)
//             {
//                 if (user == null)
//                 {
//                     return BadRequest("User object is null.");
//                 }

//                 try
//                 {
//                     dbContext.User.Add(user);
//                     await _dbContext.SaveChangesAsync();

//                     return CreatedAtAction(nameof(CreateUser), new { id = user.UserId }, user);
//                 }

//                 catch (Exception ex)
//                 {

//                     Console.WriteLine($"Error saving the user to the database: {ex.Message}");

//                     return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while saving the user.");
//                 }

//             }
//             [HttpGet]
//             public async Task<ActionResult<List<User>>> GetUserTop10()
//             {
//                 var user = await _dbContext.User.ToListAsync();

<<<<<<< HEAD
                if (User == null)
                {
                    return NotFound();
                }
=======
//                 //                 if (User == null)
//                 //                 {
//                 //                     return NotFound();
//                 //                 }

//                 //                 // return Ok(user.TakeLast(10)); Show top 10 fastest runner order by ascending
//                 //             }

//                 [HttpPut]
//                 public async Task<ActionResult<User>> UpdateUser([FromBody] User user)
//                 {


//                 }
//                 [HttpDelete]
//                 public async Task<IActionResult> DeleteUser(int userId)
//                 {
//                     var userToDelete = await _dbContext.User.FindAsync(userId);

//                     _dbContextTranan.user.Remove(userToDelete);

//                     await _dbContextTranan.SaveChangesAsync();

//                     return NoContent();

//                 }
>>>>>>> 2ee4ce451ecb0166ad1bdb360173a803bd2edbef

                // return Ok(user.TakeLast(10)); Show top 10 fastest runner order by ascending
            }

            [HttpPut]
            public async Task<ActionResult<User>> UpdateUser([FromBody] User user)
            {


            }

            [HttpDelete]
            public async Task<IActionResult> DeleteUser(int userId)
            {
                var userToDelete = await _dbContext.User.FindAsync(userId);

                _dbContextTranan.user.Remove(userToDelete);

                await _dbContextTranan.SaveChangesAsync();

                return NoContent();

            }


        }
    }
}




