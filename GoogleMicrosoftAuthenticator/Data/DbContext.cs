using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoogleMicrosoftAuthenticator;

public class DbContext:IdentityDbContext<User>
{
        public DbContext(DbContextOptions<GoogleMicrosoftAuthenticator.DbContext> options):base(options)
        {

        }
}   
