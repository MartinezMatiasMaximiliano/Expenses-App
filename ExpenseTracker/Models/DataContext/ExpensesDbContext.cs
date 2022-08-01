using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Models.Classes;

namespace ExpenseTracker.DataContext.DataContext
{
    public class ExpensesDbContext : DbContext
    {

        public ExpensesDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Transaction> transactions { get; set; }

    }
}
