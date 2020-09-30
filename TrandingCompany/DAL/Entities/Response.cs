using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public string ResponseName { get; set; }
        public DateTime CreateAt { get; set; }

        public int GoodId { get; set; }
        public Good Good { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
