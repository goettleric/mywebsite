using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using website.Models;

namespace website.DAO
{
    public class Website_DBContext : DbContext
    {
        public Website_DBContext() : base("DefaultConnection")
        {

        }
        public DbSet<Blog> Blogs { get; set; }
    }
}