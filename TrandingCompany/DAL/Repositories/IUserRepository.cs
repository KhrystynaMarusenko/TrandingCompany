using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public interface IUserRepository
    {
        void Create(string firstName, string secondName, bool genderNumber, DateTime birthday, string address, string login, string password);
        void Change(int id);
        void Delete(int id);
        void ShowAll();
        void Get(int id);
        List<User> Get();
    }
}
