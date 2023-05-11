using CORE.Interfaces;

namespace CORE.Services;

public class ChallengeService : Iservice<CORE.Entities.ChallengeService>
{
    private readonly Iservice _iService;

    public ChallengeService(Iservice iService)
    {
        _iService = iService;
    }
}