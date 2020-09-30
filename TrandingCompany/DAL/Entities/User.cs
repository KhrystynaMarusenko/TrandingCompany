using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public bool Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public DateTime DateJointed { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<Response> Responses { get; set; }

        public User()
        {
            Responses = new Collection<Response>();
        }

    }
}
