<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 9882940db1776b4b9a72eca8ee7c8c87b4c1c84e
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using CORE.Entities;
using CORE.Interfaces;
<<<<<<< HEAD

namespace INFRASTRUCTURE.APIControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RewardController : ControllerBase
    {
        private readonly ILogger<Challangecontroller> _logger;
        private readonly Iservice<CORE.Entities.Reward> _service;

        public RewardController(ILogger<Challangecontroller> logger, Iservice<CORE.Entities.Reward> service)
        {
            _logger = logger;
            _service = service;
        }
=======
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.Extensions.Logging;
// using Microsoft.AspNetCore.Mvc;
// using CORE.Entities;
>>>>>>> 2ee4ce451ecb0166ad1bdb360173a803bd2edbef

        [HttpPost]
         public async Task<ActionResult<Reward>> PostReward([FromBody] Reward reward)
         {
             if (!ModelState.IsValid)            {
                return BadRequest();
            }

<<<<<<< HEAD
            var post = await this._service.add(reward);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<Reward>>> GetAllRewards()
        {
            var rewardList = await this._service.Get();
            if (rewardList == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Reward>> GetRewardById(int id)
        {
            var reward = await this._service.GetById(id);
            if (reward == null)
            {
                return NotFound();
            }
            return Ok(reward);
        }
     }
 }
=======
//         public RewardController(ILogger<Challangecontroller> logger, Reward reward)
//         {
//             _logger = logger;
//             _reward = reward;
//         }
=======

namespace INFRASTRUCTURE.APIControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RewardController : ControllerBase
    {
        private readonly ILogger<Challangecontroller> _logger;
        private readonly Iservice<CORE.Entities.Reward> _service;

        public RewardController(
            ILogger<Challangecontroller> logger,
            Iservice<CORE.Entities.Reward> service
        )
        {
            _logger = logger;
            _service = service;
        }
>>>>>>> 9882940db1776b4b9a72eca8ee7c8c87b4c1c84e

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

<<<<<<< HEAD
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
>>>>>>> 2ee4ce451ecb0166ad1bdb360173a803bd2edbef
=======
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
    }
}
>>>>>>> 9882940db1776b4b9a72eca8ee7c8c87b4c1c84e
