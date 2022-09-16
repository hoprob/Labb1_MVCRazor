using Labb1_MVCRazor.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Labb1_MVCRazor.Data;

public class Labb1_MVCRazorContext : IdentityDbContext<ApplicationUser>
{
    public Labb1_MVCRazorContext(DbContextOptions<Labb1_MVCRazorContext> options)
        : base(options)
    {
    }
    protected Labb1_MVCRazorContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
