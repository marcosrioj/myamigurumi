using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyAmigurumi.Identity.Persistence.IdentityDb.Models;

namespace MyAmigurumi.Identity.Persistence.IdentityDb;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options), IDataProtectionKeyContext
{
    public DbSet<Group> Groups { get; set; }

    public DbSet<DataProtectionKey> DataProtectionKeys { get; }
}