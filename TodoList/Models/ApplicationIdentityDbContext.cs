using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Models
{
    public class ApplicationIdentityDbContext : IdentityDbContext
    {
        public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> o) : base(o) {  }
        public DbSet<User> Users { get; set; }
        public DbSet<TodoList.Models.Record> Record { get; set; }
        public DbSet<TodoList.Models.TodoItem> TodoItem { get; set; }
    }
}
