using DAL;
using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Services
{
    public class GoodService: IBaseRepository
    {
        private TrandingCompanyContext db;

        public GoodService()
        {
            this.db = new TrandingCompanyContext();
        }

        public IEnumerable<Good> GetAll()
        {
            return db.Goods;
        }
       
        public int GetGood()
        {
            int Id = 0;

            var goods = db.Goods;

            bool t = true;
            while (true)
            {
                Console.WriteLine("Enter id");
                Id = CheckNumber();
                foreach (var r in goods)
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
      
        public void Create()
        {
            Console.WriteLine("Enter name of good: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter price of good {name} ");
            float price = float.Parse(Console.ReadLine());

            Good good = new Good()
            {
                GoodName = name,
                Price = price,

            };
            db.Goods.Add(good);

        }
       
        public void Change(int id)
        {
            Good good = db.Goods.Single(x => x.Id == id);

            Console.WriteLine("What do you want to change\n" +
                "1 - name of good\n" +
                "2 - price\n");
            int answer = CheckNumber();

            switch (answer)
            {
                case 1:
                    Console.WriteLine("Enter name of good: ");
                    string name = Console.ReadLine();
                    good.GoodName = name;
                    break;
                case 2:
                    Console.WriteLine($"Enter price : ");
                    float price = float.Parse(Console.ReadLine());
                    good.Price = price;
                    break;
                default:
                    break;
            }
        }
       
        public void Delete(int id)
        {
            Good good = db.Goods.Find(id);
            if (good!= null)
                db.Goods.Remove(good);
        }
     
        public void Save()
        {
            db.SaveChanges();
        }
     
        public void Show()
        {
            var goods = db.Goods;
            Console.WriteLine("   {0,-10} {1,15}", "ID", "Name");
            foreach (var good in goods)
            {
                Console.WriteLine("   {0,-10} {1,15}", good.Id, good.GoodName);
            }
        }
    
        public void Get(int id)
        {
            var query = from c in db.Goods
                        where c.CategoryId == id
                        select c;
            List<Good> goods = query.ToList(); 
            Console.WriteLine("{0,-10}{1,20}","Id" ,"Name" );
            foreach (var good in goods)
            {
                Console.WriteLine("{0,-10}{1,20}", good.Id, good.GoodName);
            }


        }
     
        public void ShowAll()
        {
            var goods = db.Goods;
            Console.WriteLine("   {0,-10} {1,15} {1,15}", "ID", "Name", "Prise");
            foreach (var good in goods)
            {
                Console.WriteLine("   {0,-10} {1,15} {1,15}", good.Id, good.GoodName, good.Price);
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

        public int GetId(string name)
        {
            int id = 0;
            var query = from u in db.Goods
                        where u.GoodName == name
                        select u;
            List<Good> goods = query.ToList();
            foreach (var good in goods)
            {
                id = good.Id;
            }
            return id;
        }

    
    }
}
