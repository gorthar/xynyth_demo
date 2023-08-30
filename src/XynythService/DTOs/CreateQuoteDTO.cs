using System.ComponentModel.DataAnnotations;

namespace XynythService;

public class CreateQuoteDTO
{
    [Required]
    public decimal ReservedPrice { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string ImageUrl { get; set; }
    [Required]
    public DateTime QuoteEndsAt { get; set; }
}
