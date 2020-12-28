using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneTheme.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Post>Posts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Comment>Comments { get; set; }
        public DbSet<Category>Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

    }
}
