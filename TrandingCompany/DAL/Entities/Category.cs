using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Good> Goods { get; set; }

        public Category()
        {
            Goods = new Collection<Good>();
        }
    }
}
