namespace XynythService;

public class QuotesDTOs
{
    public Guid Id { get; set; }

    public decimal ReservedPrice { get; set; }
    public string Winner { get; set; }
    public decimal SoldAmount { get; set; }
    public decimal CurrentHighestBid { get; set; }
    public string CurrentHighestBidder { get; set; }
    public DateTime CurrentBidTime { get; set; }
    public int CurrentBidCount { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime QuoteEndsAt { get; set; }
    public string Status { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

}
