using DAL;
using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Services
{
    public class UserServiceWF : IUserRepository
    {
        private readonly TrandingCompanyContext db;

        public UserServiceWF()
        {
            this.db = new TrandingCompanyContext();
        }

        public string GetUser()
        {

            string login;
            var users = db.Users;

            bool t = true;
            while (true)
            {
                Console.WriteLine("Enter your login: ");
                login = Console.ReadLine();
                foreach (var r in users)
                {
                    if (r.Login == login)
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

            return login;
        }
        //створення
        public void Create(string firstName, string secondName, bool gender, DateTime birthday, string address, string login, string password)
        {
            DateTime dateJoined = DateTime.Now;

            User user = new User()
            {
                FirstName = firstName,
                SecondName = secondName,
                Gender = gender,
                Birthday = birthday,
                Address = address,
                DateJointed = dateJoined,
                Login = login,
                Password = password,
            };
            db.Users.Add(user);
            db.SaveChanges();

        }
        //зміни
        public void Change(int id)
        {
            User user = db.Users.Single(x => x.Id == id);

            Console.WriteLine("What do you want to change\n" +
                "1 - first name\n" +
                "2 - second name\n" +
                "3 - gender\n" +
                "4 - date of your birthday\n" +
                "5 - address\n" +
                "6 - login\n" +
                "7 - password\n");

            int answer = Convert.ToInt32(Console.ReadLine());


            switch (answer)
            {
                case 1:
                    Console.WriteLine("Enter first name: ");
                    string firstName = Console.ReadLine();
                    user.FirstName = firstName;
                    break;

                case 2:
                    Console.WriteLine("Enter second name: ");
                    string secondName = Console.ReadLine();
                    user.SecondName = secondName;
                    break;

                case 3:
                    Console.WriteLine("Enter 1 if you are male and 2 - female");
                    int genderNumber = Convert.ToInt32(Console.ReadLine());
                    bool gender = true;
                    while (true)
                    {
                        if (genderNumber == 1)
                        {
                            gender = true;
                            break;

                        }
                        if (genderNumber == 0)
                        {
                            gender = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You entered wrong number, please enret again: ");
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine($"Enter date of birth:\n" +
               $"Year: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Month: ");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Day: ");
                    int day = Convert.ToInt32(Console.ReadLine());
                    var date = new DateTime(year, month, day);
                    user.Birthday = date;
                    break;

                case 5:
                    Console.WriteLine("Enter your address: ");
                    string address = Console.ReadLine();
                    user.Address = address;
                    break;
                case 6:
                    Console.WriteLine("Enter login: ");
                    string login = Console.ReadLine();
                    user.Login = login;
                    break;
                case 7:
                    Console.WriteLine("Enter old password: ");
                    while (true)
                    {
                        string oldPassword = Console.ReadLine();
                        if (oldPassword == user.Password)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You entered wrong password, plear enter again");
                        }
                    }
                    Console.WriteLine("Enter password: ");
                    string password1 = Console.ReadLine();
                    while (true)
                    {
                        Console.WriteLine("Enter password again");
                        string password2 = Console.ReadLine();
                        if (password1 == password2)
                        {
                            break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
        //видалення
        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }
        //збереження змін
        public void Save()
        {
            db.SaveChanges();
        }

        public void Show()
        {
            var users = db.Users;
            Console.WriteLine("   {0,-10} {1,15} {2, 15}", "ID", "First name", "Second name");
            foreach (var user in users)
            {
                Console.WriteLine("   {0,-10} {1,15} {2,15}", user.Id, user.FirstName, user.SecondName);
            }
        }
        //виводить дані юзера по id яке ми передали
        public void Get(int id)
        {
            var query = from c in db.Users
                        where c.Id == id
                        select c;
            List<User> users = query.ToList();

            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.FirstName} {user.SecondName}");
            }
        }
        //показ
        public void ShowAll()
        {
            var users = db.Users;


            //Console.WriteLine("{0,-20}{1,25}{2,20}{3,15}{4,15}", "Name", "gender", "date of birthday", "address");

            foreach (var user in users)
            {
                Console.WriteLine("{0,-10}{1,10}{2,25}{3,20}{4,15}{5,15}", user.FirstName, user.SecondName, user.Gender, user.Birthday,
                    user.Address);
            }

        }

        public List<User> Get()
        {
            return db.Users.ToList();
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
        //витягує дані про юзера по логіну
        public int GetId(string login)
        {
            int id = 0;

            var query = from u in db.Users
                        where u.Login == login
                        select u;
            List<User> users = query.ToList();
            foreach (var user in users)
            {
                id = user.Id;
            }
            return id;
        }
        //перевірка паролю
        public bool CheckPassword(int id, string password)
        {
            bool checkPass = false;

            var query = from u in db.Users
                        where u.Id == id
                        select u;

            List<User> users = query.ToList();

            for (int i = 0; i < 4; i++)
            {
                foreach (var user in users)
                {
                    if (user.Password == password)
                    {
                        checkPass = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You entered wrong password, please enter again");
                        password = Console.ReadLine();
                    }
                }
                if (checkPass == true)
                {
                    i = 3;
                }
            }
            return checkPass;
        }
        //перевірка на адміна
        public void CheckAdmin()
        {

            var query = from c in db.Users
                        where c.Id == 3
                        select c;
            List<User> users = query.ToList();
            bool exit = true;
            while (exit)
            {
                string login = Console.ReadLine();
                foreach (var user in users)
                {

                    if (user.Login == login)
                    {
                        string password = Console.ReadLine();
                        if (user.Password == password)
                        {
                            Console.WriteLine("Hello admin");
                            exit = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have entered wrong login, please do it again");
                    }
                }
            }
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

    }
}
