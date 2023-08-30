using System.ComponentModel.DataAnnotations.Schema;

namespace XynythService;

[Table("Products")]
public class Product
{
    // create a product entity with the following properties: id, Name, Description, ImageUrl, Quotes

    public Guid id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    // navigation properties
    public Quote Quote { get; set; }
    public Guid QuoteId { get; set; }
}
