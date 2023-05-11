using CORE.Interfaces;

namespace CORE.Services;

public class UserService : Iservice<CORE.Entities.User>
{
    private readonly Iservice _iService;

    public UserService(Iservice iService)
    {
        _iService = iService;
    }
}