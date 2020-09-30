using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public interface IGoodRepository
    {
        void Create(string name, float price);
        void Change(int id, string name, float price);
        void Delete(int id);
        void ShowAll();
        void Get(int id);
    }
}
