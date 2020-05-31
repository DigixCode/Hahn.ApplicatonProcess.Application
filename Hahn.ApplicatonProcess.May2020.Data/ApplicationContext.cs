using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.May2020.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions options)
            :base(options)
        {
        }

        public static ApplicationContext CreateInMemoryInstance()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase("TestApplication")
                .Options;

            return new ApplicationContext(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Person>().HasData(
                new Models.Person { Name = "James", FamilyName = "Butt", Address = "6649 N Blue Gum St", EMailAddress = "jbutt@gmail.com", Age = 32, CountryOfOrigin = "US" },
                new Models.Person { Name = "Josephine", FamilyName = "Darakjy", Address = "4 B Blue Ridge Blvd", EMailAddress = "josephine_darakjy@darakjy.org", Age = 45, CountryOfOrigin = "US" },
                new Models.Person { Name = "Rebbecca", FamilyName = "Didio", Address = "171 E 24th St", EMailAddress = "rebbecca.didio@didio.com.au", Age = 29, CountryOfOrigin = "Australia" });
        }

        public DbSet<Models.Person> People { get; set; }

        
    }
}
