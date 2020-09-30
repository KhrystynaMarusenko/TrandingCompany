using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public interface ICategoryRepository
    {
        void Create(string name);
        void Change(int id, string name);
        void Delete(int id);
        void ShowAll();
        void Get(int id);
        List<Category> Get();
    }
}
