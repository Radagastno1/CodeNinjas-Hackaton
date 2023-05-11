using CORE.Interfaces;

namespace CORE.Services;

public class TrackService : Iservice<CORE.Entities.Track>
{
     private readonly Iservice _iService;

    public UserService(Iservice iService)
    {
        _iService = iService;
    }
}