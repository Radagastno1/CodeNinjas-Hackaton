using CORE.Entities;
using CORE.Services;
namespace CORE.Services;

public class UserService : interfaces.Services<CORE.Entities.User>
{
    private readonly Iservices _iServices;

    public UserService(Iservices iServices)
    {
        _iServices = iServices;
    }
}