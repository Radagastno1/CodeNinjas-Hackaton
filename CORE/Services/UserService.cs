// using CORE.Interfaces;

// namespace CORE.Services;

<<<<<<< HEAD
// public class UserService : Iservice<CORE.Entities.User>
// {
//     private readonly Iservices _iServices;

//     public UserService(Iservices iServices)
//     {
//         _iServices = iServices;
//     }
// }
=======
public class UserService : Iservice<CORE.Entities.User>
{
    private readonly Iservice _iService;

    public UserService(Iservice iService)
    {
        _iService = iService;
    }
}
>>>>>>> 789476d04897a7557e7beebf4bec531366f4a77d
