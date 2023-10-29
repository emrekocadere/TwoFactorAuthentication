using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoogleMicrosoftAuthenticator;

public class DbContext:IdentityDbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=sql; User Id=SA; Password=reallyStrongPwd123;TrustServerCertificate=True");
    }
}   
