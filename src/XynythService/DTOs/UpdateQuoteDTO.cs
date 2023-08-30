namespace XynythService;

public class UpdateQuoteDTO
{
    public string Status { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public DateTime QuoteEndsAt { get; set; }
}
