using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LAB7.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {/*
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            Database.EnsureCreated();
        }*/

    }

}
