using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain.Entities;

namespace Domain
{
    public class ApplicationUser : IdentityUser { };
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = new ConfigurationBuilder()
                .AddJsonFile("AppSettings.json").Build().GetSection("ConnectionString")["DefaultConnection"];

            optionsBuilder.UseSqlServer(connectionString);

            ///asdasdasd
            ///
        }

        DbSet<Manufactorer> Manufatorers;
    }
}
