using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public interface IResponseRepository
    {
        void Create(int userId, int goodId, string responseName);
        void Change(int id, string name);
        void Delete(int id);
        void ShowAll();
        void Get(int id);
    }
}
