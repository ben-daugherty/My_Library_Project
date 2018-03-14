using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using Mybrary.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Mybrary.DAL
{
    public class LibraryContext : DbContext
    {

        public LibraryContext() : base("LibraryContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}