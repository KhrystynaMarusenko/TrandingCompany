using System;
using BLL.Services;
using DAL.Entities;

namespace TrandingCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }

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
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Enter your login: ");
                        string login = Console.ReadLine();


                        int id = userService.GetId(login);

                        if (id == 0)
                        {
                            Console.WriteLine($"You have entered wrong login, please enter again");
                        }
                        else
                        {
                            Console.WriteLine("Enter password: ");
                            string password = Console.ReadLine();

                            bool pass = userService.CheckPassword(id, password);
                            if(pass)
                            {
                                CategoryMenu(id);

                            }
                        }
                    }
                }

                else if (number == 3)
                {
                    userService.Create();
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
                int categotyId = CheckNumber();
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

        static void GoodMenu(int Id, int idUser)
        {
            GoodService goodService = new GoodService();

            while (true)
            {
                goodService.Get(Id);

                Console.WriteLine("Please enter good's number and you will see responses anout it or press '0'" +
                    " if you want to return category");

                int goodId = CheckNumber();
               
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
                    int responseNumber = CheckNumber();

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
                    int responseNumber = CheckNumber();
                    Console.Clear();

                    if (responseNumber == 1)
                    {
                        responseService.Create(idUser, goodId);
                        break;
                    }
                    else if (responseNumber == 2)
                    {
                        responseService.Get(idUser);
                        Console.WriteLine("Please enter id of response which you want to change");
                        int responseId = CheckNumber();
                        responseService.Change(responseId);
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
