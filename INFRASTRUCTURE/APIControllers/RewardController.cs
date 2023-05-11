// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.Extensions.Logging;
// using Microsoft.AspNetCore.Mvc;
// using CORE.Entities;

// namespace INFRASTRUCTURE.APIControllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class RewardController : ControllerBase
//     {
//         private readonly ILogger<Challangecontroller> _logger;
//         private readonly Reward _reward;

//         public RewardController(ILogger<Challangecontroller> logger, Reward reward)
//         {
//             _logger = logger;
//             _reward = reward;
//         }

//         [HttpPost]
//         public async Task<ActionResult<Reward>> PostReward([FromBody] Reward reward)
//         {
//             if (!ModelState.IsValid)
//             {
//                 return BadRequest();
//             }

//             var post = await this._reward.CreateReward(reward);
//             return Ok();
//         }

//         [HttpGet]
//         public async Task<ActionResult<List<Reward>>> GetAllRewards()
//         {
//             var rewardList = await this._reward.GetAllRewardsList();
//             if (rewardList == null)
//             {
//                 return NotFound();
//             }
//             return Ok();
//         }

//         [HttpGet("{id:int}")]
//         public async Task<ActionResult<Reward>> GetRewardById(int id)
//         {
//             var reward = await this._reward.GetRewardByID(id);
//             if (reward == null)
//             {
//                 return NotFound();
//             }
//             return Ok(reward);
//         }

//     }
// }