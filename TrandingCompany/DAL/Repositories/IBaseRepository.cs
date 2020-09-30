using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IBaseRepository
    {
        void Create();
        void Change(int id);
        void Delete(int id);
        void ShowAll();
        void Get(int id);
    }
}
