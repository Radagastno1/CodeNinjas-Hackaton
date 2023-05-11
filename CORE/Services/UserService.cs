<<<<<<< HEAD
=======
using CORE.Entities;
>>>>>>> 8f4abf6ea443dd7187185fa1a48fa25687b0ba0b
using CORE.Interfaces;

namespace CORE.Services;

public class UserService : Iservice<CORE.Entities.User>
{
<<<<<<< HEAD
    public async Task<User> add(User obj)
=======
<<<<<<< HEAD
    private readonly Iservices _iServices;

    public UserService(Iservices iServices)
    {
        _iServices = iServices;
=======
    public User add(User obj)
>>>>>>> 85f87e71ab1afa47b7a6a3394f30bf9c540c49c3
    {
        throw new NotImplementedException();
    }

    public async Task<User> Delete(User obj)
    {
        throw new NotImplementedException();
    }

    public async Task<List<User>> Get()
    {
        throw new NotImplementedException();
    }

    public async Task<User> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<User> Put(User obj)
    {
        throw new NotImplementedException();
>>>>>>> 8f4abf6ea443dd7187185fa1a48fa25687b0ba0b
    }
}
