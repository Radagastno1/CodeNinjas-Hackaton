<<<<<<< HEAD
=======
using CORE.Entities;
>>>>>>> 8f4abf6ea443dd7187185fa1a48fa25687b0ba0b
using CORE.Interfaces;

namespace CORE.Services;

public class UserService : Iservice<CORE.Entities.User>
{
<<<<<<< HEAD
    private readonly Iservices _iServices;

    public UserService(Iservices iServices)
    {
        _iServices = iServices;
=======
    public User add(User obj)
    {
        throw new NotImplementedException();
    }

    public User Delete(User obj)
    {
        throw new NotImplementedException();
    }

    public List<User> Get()
    {
        throw new NotImplementedException();
    }

    public User GetById(int id)
    {
        throw new NotImplementedException();
    }

    public User Put(User obj)
    {
        throw new NotImplementedException();
>>>>>>> 8f4abf6ea443dd7187185fa1a48fa25687b0ba0b
    }
}
