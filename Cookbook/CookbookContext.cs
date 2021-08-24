using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cookbook.Models;



namespace Cookbook
{
    public class CookbookContext : DbContext
    {
        public CookbookContext(DbContextOptions<CookbookContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

    }
}
