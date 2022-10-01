using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infrastructura.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Quote> Quotes { get; set; }
}
