using System;
using BLL.Services;
using DAL.Entities;
using DAL.Repositories;

namespace TrandingCompany
{
    class Program
    {
        //головна функція
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }
        //Функція де користувач логується
        static void Menu()
        {
            UserService userService = new UserService();
            while (true)
            {
                Console.WriteLine("please enter 1 - admin, 2 - user, 3 - create new user, 4 - end the program");
                int number = CheckNumber();
                Console.Clear();
                if (number == 1)
                {
                    userService.CheckAdmin();
                    CategoryMenu(number);
                }
                else if (number == 2)
                {
                    string login = userService.GetUser();

                    int id = userService.GetId(login);

                    Console.WriteLine("Enter password: ");
                    string password = Console.ReadLine();



                    bool pass = userService.CheckPassword(id, password);
                    if(pass)
                    {
                        CategoryMenu(id);

                    }
                    else
                    {
                        Console.WriteLine("Sorry but you have only 5 attemps for password");
                        break;
                    }
                    
                    
                }

                else if (number == 3)
                {
                    Console.WriteLine("Enter first name: ");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Enter second name: ");
                    string secondName = Console.ReadLine();

                    Console.WriteLine("Enter 1 if you are male and 0 - female");
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

                    Console.WriteLine("Enter day of your birthday(1 - 31)");
                    int day = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month of your birthday(1 - 12)");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter year of your birthday");
                    int year = Convert.ToInt32(Console.ReadLine());

                    DateTime birthday = new DateTime(year, month, day);


                    Console.WriteLine("Enter your address: ");
                    string address = Console.ReadLine();

                    DateTime dateJoined = DateTime.Now;

                    Console.WriteLine("Enter login: ");
                    string login = Console.ReadLine();

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
                    userService.Create(firstName, secondName, gender, birthday, address, login, password1);
                    userService.Save();
                    Console.Clear();
                }
                else if(number == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("you have entered wrong number, please do it again");
                }
            }
        }
        //Меню для таблиці Categoty
        static void CategoryMenu(int idUser)
        {
            CategoryService categoryService = new CategoryService();
            while (true)
            {
                Console.Clear();
                categoryService.ShowAll();
                Console.WriteLine();
                Console.WriteLine("Which category do you want to choose? Please select a number\n" +
                    "or press '0' if you want log out");
                int categotyId = categoryService.GetCategory();
                if (categotyId == 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    GoodMenu(categotyId, idUser);
                   
                }
            }
        }
        //Меню для таблиці Good
        static void GoodMenu(int Id, int idUser)
        {
            GoodService goodService = new GoodService();

            while (true)
            {
                goodService.Get(Id);

                Console.WriteLine("Please enter good's number and you will see responses anout it or press '0'" +
                    " if you want to return category");

                int goodId = goodService.GetGood();
               
                if (goodId == 0)
                {
                    break;
                }
                else
                {
                    ResponseMenu(goodId, idUser, goodId);
                }
            }
        }
        //Меню для таблиці Response
        static void ResponseMenu(int Id, int idUser, int goodId)
        {
            ResponseService responseService = new ResponseService();
            responseService.Get(Id);

            if (idUser == 1)
            { 
                while (true)
                {
                    Console.WriteLine("What do you want to do next?");
                    Console.WriteLine("1 - search\n 2 - sort\n 3 - return to goods");
                    int responseNumber = responseService.GetResponce();
                    Console.Clear();

                    if (responseNumber == 1)
                    {
                        responseService.SearchResponse();
                        break;
                    }
                    else if (responseNumber == 2)
                    {
                        responseService.SortResponse();
                        break;
                    }
                    else if (responseNumber == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You have entered wrong number please enter again");
                    }
                    Console.Clear();
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("What do you want to do next?");
                    Console.WriteLine("1 - add\n 2 - change\n 3 - delete\n 4 - return to good");
                    int responseNumber = responseService.GetResponce();
                    Console.Clear();

                    if (responseNumber == 1)
                    {
                        Console.WriteLine("Enter response: ");
                        string responseName = Console.ReadLine();
                        responseService.Create(idUser, goodId, responseName);
                        responseService.Save();
                        break;
                    }
                    else if (responseNumber == 2)
                    {
                        responseService.Get(idUser);
                        Console.WriteLine("Please enter id of response which you want to change");
                        int responseId = CheckNumber();
                        Console.WriteLine("Enter new response : ");
                        string name = Console.ReadLine();
                        responseService.Change(responseId, name);
                        Console.Clear();
                        break;
                    }
                    else if (responseNumber == 3)
                    {
                        responseService.Get(idUser);
                        Console.WriteLine("Please enter id of response which you want to delete");
                        int responseId = CheckNumber();
                        responseService.Delete(responseId);
                        Console.Clear();
                        break;
                    }
                    else if (responseNumber == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You have entered wrong number please enter again");
                        Console.Clear();
                    }
                }
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
            Console.Clear();
            return n;
        }
    }
}
