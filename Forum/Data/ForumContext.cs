using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Forum.Models;

namespace Forum.Data
{
    public class ForumContext : DbContext
    {
        public ForumContext (DbContextOptions<ForumContext> options)
            : base(options)
        {
        }

        public DbSet<AccountType> AccountTypes { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
