<<<<<<< HEAD
using CORE.Entities;
using CORE.Interfaces;
=======
// using CORE.Interfaces;
>>>>>>> 1112dd4ad32e57dbae7a4630dbd782c88fb8d5c0

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
    }
}
>>>>>>> 789476d04897a7557e7beebf4bec531366f4a77d
