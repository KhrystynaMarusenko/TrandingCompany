using DAL;
using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Services
{
    public class ResponseService: IResponseRepository
    {
        private TrandingCompanyContext db;

        public ResponseService()
        {
            this.db = new TrandingCompanyContext();
        }

        public int GetResponce()
        {
            int Id = 0;

            var responses = db.Responses;

            bool t = true;
            while (true)
            {
                Console.WriteLine("Enter id");
                Id = CheckNumber();
                foreach (var r in responses)
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

        //public void Create()
        //{
        //    Console.WriteLine("Enter response: ");
        //    string responseName = Console.ReadLine();
        //    DateTime dateTime = DateTime.Now;

        //    Response response = new Response()
        //    {
        //        ResponseName = responseName,
        //        CreateAt = dateTime
        //    };
        //    db.Responses.Add(response);
        //}

        public void Create(int userId, int goodId, string responseName)
        {
            DateTime dateTime = DateTime.Now;

            Response response = new Response()
            {
                ResponseName = responseName,
                CreateAt = dateTime,
                UserId = userId,
                GoodId = goodId
            };
            db.Responses.Add(response);
        }

        public void Change(int id, string name)
        {
            Response response = db.Responses.Single(x => x.Id == id);

            response.ResponseName = name;
        }

        public void Delete(int id)
        {
            Response response = db.Responses.Find(id);
            if (response != null)
                db.Responses.Remove(response);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Show()
        {
            var responses = db.Responses;
            Console.WriteLine("{0,-10} {1,15}", "ID", "Name");
            foreach (var response in responses)
            {
                Console.WriteLine("{0,-10} {1,15}",response.Id, response.ResponseName);
            }
        }

        public void Get(int id)
        {
            var query = from c in db.Responses
                        join u in db.Users on c.UserId equals u.Id
                        where c.GoodId == id
                        select new
                        {
                            id = c.Id,
                            login = u.Login,
                            response = c.ResponseName
                        };
            Console.WriteLine("{0,-10}{1, 30}{2, 50}", "Response Id", "login", "response");

            foreach(var q in query)
            {
                Console.WriteLine("{0,-10}{1, 30}{2, 50}", q.id, q.login, q.response);
            }
         

        }

        public void ShowAll()
        {
            var responses = db.Responses;
            Console.WriteLine("   {0,-10} {1,15}", "ID", "Response");
            foreach (var response in responses)
            {
                Console.WriteLine("   {0,-10} {1,15}", response.Id, response.ResponseName);
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

        public void SortResponse()
       {
            Console.WriteLine("You can sort responses by\n" +
                "1 - date, 2 - users' login");

            int number = CheckNumber();
            while (true)
            {
                if (number == 1)
                {
                    var query = from d in db.Responses
                                orderby d.CreateAt
                                select new
                                {
                                    response = d.ResponseName,
                                    date = d.CreateAt
                                };
                    Console.WriteLine("  {0,-10}{1,50}", "DATE OF CREATING", "RESPONSE");
                    foreach (var q in query)
                    {
                        Console.WriteLine("  {0,-10}{1,50}", q.date, q.response);
                    }
                    break;
                }
                if(number == 2)
                {
                    var query = from d in db.Responses
                                join l in db.Users on d.UserId equals l.Id
                                orderby l.Login
                                select new
                                {
                                    firstName = l.FirstName,
                                    secondName = l.SecondName,
                                    login = l.Login,
                                    response = d.ResponseName
                                };
                    Console.WriteLine("{0,-20}{1,30}{2, 50}", "Name", "Login", "Response");
                    foreach(var q in query)
                    {
                        Console.WriteLine("{0,-10}{1,10}{2,30}{3,50}", q.firstName, q.secondName, q.login, q.response);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("You have entered wrong number, pleasr enter again");
                }
            }
            
       }

        public void SearchResponse()
        {
            Console.WriteLine("You can search by 1 - date of creating and 2 - user's login");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            while(true)
            {
                if(searchNumber == 1)
                {
                    var responses = db.Responses;

                    bool t = true;
                    while (true)
                    {
                        Console.WriteLine("Enter date of creating");
                        Console.WriteLine("Enter day of creating(1 - 31)");
                        int day = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter month of creating(1 - 12)");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter year of creating");
                        int year = Convert.ToInt32(Console.ReadLine());
                        DateTime dateCreating = new DateTime(year, month, day);

                        foreach (var r in responses)
                        {
                            if (r.CreateAt == dateCreating)
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
                }
                if(searchNumber == 2)
                {
                    var users = db.Users;
                    var responses = db.Responses;
                    int idUser = 0;
                    

                    bool t = true;
                    while (true)
                    {
                        Console.WriteLine("Enter user's login");
                        string login = Console.ReadLine();
                        
                        foreach (var u in users)
                        {
                            if (u.Login == login)
                            {
                                t = false;
                                idUser = u.Id;
                                break;
                            }
                        }
                        if (!t)
                        {
                            foreach(var resp in responses)
                            {
                                if(resp.UserId == idUser)
                                {
                                    Console.WriteLine("everything is good");
                                    break;
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter again");
                        }
                    }
                }
            }
                
        }

       

    }
}
