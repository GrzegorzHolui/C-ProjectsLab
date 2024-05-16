using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorAppLaby2.Components;

namespace BlazorAppLaby2.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
	    public DbSet<BlazorAppLaby2.Components.Movie> Movie { get; set; } = default!;
	}
}
