using Entity_Framework_Setup.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Setup
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Enter the connectionstring. (Server name , Database name , security setting)

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreDemo;Integrated Security=True");


            
        }
        //Creates the name and table called People
        public DbSet <Person>People { get; set; }


    }
}
