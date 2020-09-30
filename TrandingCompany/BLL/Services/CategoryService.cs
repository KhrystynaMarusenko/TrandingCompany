using DAL;
using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Services
{
    public class CategoryService : ICategoryRepository
    {
        private TrandingCompanyContext db;

        public CategoryService()
        {
            this.db = new TrandingCompanyContext();
        }

        public int GetCategory()
        {
            int Id = 0;

            var categories = db.Categories;

            bool t = true;
            while (true)
            {
                Console.WriteLine("Enter id");
                Id = CheckNumber();
                foreach (var r in categories)
                {
                    if (Convert.ToInt32(r.Id) == Id)
                    {
                        t = false;
                        break;
                    }
                }
                if (!t)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter again");
                }
            }

            return Id;
        }
        //додаємо
        public void Create(string name)
        {
            Category city = new Category()
            {
                CategoryName = name,
            };
            db.Categories.Add(city);

        }
        //зміни
        public void Change(int id, string name)
        {
            Category category = db.Categories.Single(x => x.Id == id);

            category.CategoryName = name;
        }
        //видалення
        public void Delete(int id)
        {
            Category category = db.Categories.Find(id);
            if (category != null)
                db.Categories.Remove(category);
        }
        //збереження змін
        public void Save()
        {
            db.SaveChanges();
        }
        //пошук
        public void Get(int id)
        {
            var query = from c in db.Categories
                        where c.Id == id
                        select c;
            List<Category> categories = query.ToList();

            foreach (var category in categories)
            {
                Console.WriteLine($"Name: {category.CategoryName}");
            }


        }
        //виводить всі данні
        public void ShowAll()
        {
            var categories = db.Categories;
            Console.WriteLine("   {0,-10} {1,15}", "ID", "Name");
            foreach (var category in categories)
            {
                Console.WriteLine("   {0,-10} {1,15}", category.Id, category.CategoryName);
            }

        }

        static int CheckNumber()
        {
            int n;
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input number was not in a correct format.\n");
                }
            }
            return n;
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public List<Category> Get()
        {
            return db.Categories.ToList();
        }
    }
    //private bool disposed = false;

    //public virtual void Dispose(bool disposing)
    //{
    //    if (!this.disposed)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //    }
    //    this.disposed = true;
    //}

    //public void Dispose()
    //{
    //    Dispose(true);
    //    GC.SuppressFinalize(this);
    //}

}

