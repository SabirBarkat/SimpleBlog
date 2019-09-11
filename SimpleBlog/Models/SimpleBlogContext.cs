using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Models
{
    using System.Data.Entity;
    public class SimpleBlogContext : DbContext
    {
        public SimpleBlogContext() : base("Name=dsn") {}

        public DbSet<User> UserSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<User>().ToTable("Users");
        }

    } // class
}