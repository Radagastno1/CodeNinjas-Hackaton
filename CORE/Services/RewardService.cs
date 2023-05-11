using CORE.Interfaces;

namespace CORE.Services;

public class RewardService : Iservice<CORE.Entities.Reward>
{
     private readonly Iservice _iService;

    public RewardService(Iservice iService)
    {
        _iService = iService;
    }
}