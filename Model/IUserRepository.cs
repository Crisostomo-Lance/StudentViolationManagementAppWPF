using System;
using System.Collections.Generic;
using System.Net;

namespace StudentViolationApplication.Model
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void add(UserModel userModel);
        void edit(UserModel userModel);
        void remove(int ID);
        UserModel GetByID(int ID);
        UserModel GetByUsername(string username);
        IEnumerable<UserModel> GetByAll();
    }
}
