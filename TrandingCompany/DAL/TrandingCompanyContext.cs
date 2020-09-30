using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL
{
    public class TrandingCompanyContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Good> Goods { get; set; }

        public DbSet<Response> Responses { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
