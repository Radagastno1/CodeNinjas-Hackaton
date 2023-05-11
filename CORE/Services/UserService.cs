using CORE.Interfaces;

namespace CORE.Services;

public class UserService : Iservice<CORE.Entities.User>
{
    private readonly Iservices _iServices;

    public UserService(Iservices iServices)
    {
        _iServices = iServices;
    }
}