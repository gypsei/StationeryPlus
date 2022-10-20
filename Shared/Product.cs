namespace StationeryPlus.Shared;

public class Product
{
    public int Id { get; set; }

    public string? Title { get; set; } = String.Empty;

    public string? Description { get; set; } = String.Empty;

    public string? ImageURL { get; set; }

    public int? Price { get; set; }
    
}