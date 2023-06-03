using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetWinFormApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\2023study\_githubprojects\filehub\DotNetWinFormApp\DB\WorkDB.db");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
