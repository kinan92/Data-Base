using System;
using System.Collections.Generic;
using System.Data.Entity;   // Add this fore call the data Base
using System.Linq;
using System.Web;

namespace Data_Base.Models
{
    public class PeopleDbContext : DbContext
    {
        public PeopleDbContext() : base("name=PeopleDbContext")
        {

        }

        public DbSet<Person> people { get; set; }   /// conaction to the list of person Class

    }
}