using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace DataAccess
{
    public class ApplicationDbContext :IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        public ApplicationDbContext()
        { }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
