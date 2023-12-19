using Microsoft.EntityFrameworkCore;

namespace TinyEnums;

public class TinyContext : DbContext
{
    public TinyContext(DbContextOptions<TinyContext> options) : base(options)
    {
    }

    public DbSet<Thing> Things { get; set; } = null!;
}