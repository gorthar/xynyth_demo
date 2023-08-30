using Microsoft.EntityFrameworkCore;

namespace XynythService;

public class QuoteDbContext : DbContext
{
    public QuoteDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Quote> Quotes { get; set; }

}
