using Microsoft.EntityFrameworkCore;
using RubyOnBrain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyOnBrain.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<EntryType> EntryTypes { get; set; }
        public DbSet<ProgLang> ProgLangs { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=RobTestData2"); 
        }

        // Метод для WebApi
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
