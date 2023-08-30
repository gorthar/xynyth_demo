namespace XynythService;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<QuoteDbContext>();
        context.Database.EnsureCreated();
        if (context.Quotes.Any())
        {
            Console.WriteLine("******* Database already seeded. *********\n\n\n");
            return;
        }
        Console.WriteLine("\n\n\n****** No data found! Seeding database... ***********\n\n\n");
        var quotes = new Quote[]{
            new Quote{
                Id = Guid.Parse("d9b0c9a0-0b1a-4b0e-8b0a-0b0b0b0b0b0c"),
                ReservedPrice = 100,
                SoldAmount = 100,
                CurrentHighestBid = 100,
                CurrentHighestBidder = "John Doe",
                CurrentBidTime = DateTime.UtcNow,
                CurrentBidCount = 1,
                QuoteEndsAt = DateTime.UtcNow.AddDays(1),
                Status = Status.Live,
                Product = new Product{
                    Name = "Product 1",
                    Description = "Product 1 Description",
                    ImageUrl = "https://picsum.photos/200/300"
                }
            },
            new Quote{
                Id = Guid.Parse("d9b0c9a0-0b1a-4b0e-8b0a-0b0b0b0b0b0a"),
                ReservedPrice = 200,
                SoldAmount = 200,
                CurrentHighestBid = 200,
                CurrentHighestBidder = "John Doe",
                CurrentBidTime = DateTime.UtcNow,
                CurrentBidCount = 1,
                QuoteEndsAt = DateTime.UtcNow.AddDays(1),
                Status = Status.Live,
                Product = new Product{
                    Name = "Product 2",
                    Description = "Product 2 Description",
                    ImageUrl = "https://picsum.photos/200/300"
                }
            },
            new Quote{
                Id = Guid.Parse("d9b0c9a0-0b1a-4b0e-8b0a-0b0b0b0b0b0b"),
                ReservedPrice = 300,
                SoldAmount = 300,
                CurrentHighestBid = 300,
                CurrentHighestBidder = "John Doe",
                CurrentBidTime = DateTime.UtcNow,
                CurrentBidCount = 1,
                QuoteEndsAt = DateTime.UtcNow.AddDays(1),
                Status = Status.Live,
                Product = new Product{
                    Name = "Product 3",
                    Description = "Product 3 Description",
                    ImageUrl = "https://picsum.photos/200/300"
                }
            },
            new Quote{
                Id = Guid.Parse("d9b0c9a0-0b1a-4b0e-8b0a-0b0b0b0b0b0d"),
                ReservedPrice = 400,
                SoldAmount = 400,
                CurrentHighestBid = 400,
                CurrentHighestBidder = "John Doe",
                CurrentBidTime = DateTime.UtcNow,
                CurrentBidCount = 1,
                QuoteEndsAt = DateTime.UtcNow.AddDays(1),
                Status = Status.Live,
                Product = new Product{
                    Name = "Product 4",
                    Description = "Product 4 Description",
                    ImageUrl = "https://picsum.photos/200/300"
                }
            },
            new Quote{
                Id = Guid.Parse("d9b0c9a0-0b1a-4b0e-8b0a-0b0b0b0b0b0e"),
                ReservedPrice = 500,
                SoldAmount = 500,
                CurrentHighestBid = 500,
                CurrentHighestBidder = "John Doe",
                CurrentBidTime = DateTime.UtcNow,
                CurrentBidCount = 1,
                QuoteEndsAt = DateTime.UtcNow.AddDays(1),
                Status = Status.Live,
                Product = new Product{
                    Name = "Product 5",
                    Description = "Product 5 Description",
                    ImageUrl = "https://picsum.photos/200/300"
                }
            },
        };
        context.Quotes.AddRange(quotes);
        context.SaveChanges();
    }
}
