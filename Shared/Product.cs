using System.ComponentModel.DataAnnotations.Schema;

namespace StationeryPlus.Shared;

public class Product
{
    public int Id { get; set; }

    public string? Title { get; set; } = String.Empty;

    public string? Description { get; set; } = String.Empty;

    public string? ImageURL { get; set; }


    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    public ProductCategory? Category { get; set; }
    public int CategoryId { get; set; }

}