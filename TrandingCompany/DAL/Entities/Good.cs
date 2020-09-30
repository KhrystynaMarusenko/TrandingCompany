using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DAL.Entities
{
    public class Good
    {
        public int Id { get; set; }
        public string GoodName { get; set; }
        public float Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Response> Responses { get; set; }
        
        public Good()
        {
            Responses = new Collection<Response>();
        }
    }
}
