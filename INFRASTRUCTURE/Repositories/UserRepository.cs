using CORE.Entities;
using CORE.Interfaces;

namespace INFRASTRUCTURE.Repositories;

public class UserRepository : IRepository<CORE.Entities.User>
{
    public User Create(User obj)
    {
        throw new NotImplementedException();
    }

    public void DeleteById(int id)
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

    public User Update(User obj)
    {
        throw new NotImplementedException();
    }
}