using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MLS.WebUI.Models.Identity
{
    public class UserDbContext : IdentityDbContext<AppUser, AppIdentityRole, int>
    {
        public DbSet<BadPasswordViewModel> BadPasswords { get; set; }
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
    }
}
