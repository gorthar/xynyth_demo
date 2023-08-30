namespace XynythService;

public class Quote
{
    // create a quote entity with the following properties: id, ReservedPrice, Winner, SoldAmount, CurrentHighestBid, CurrentHighestBidder, CurrentBidTime, CurrentBidCount, CreatedAt, UpdatedAt, QuoteEndsAt, Status, Product
    public Guid Id { get; set; }

    public decimal ReservedPrice { get; set; }
    public string Winner { get; set; }
    public decimal? SoldAmount { get; set; }
    public decimal? CurrentHighestBid { get; set; }
    public string CurrentHighestBidder { get; set; }
    public DateTime CurrentBidTime { get; set; }
    public int? CurrentBidCount { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime QuoteEndsAt { get; set; }
    public Status Status { get; set; }
    public Product Product { get; set; }

}
