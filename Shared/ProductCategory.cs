namespace StationeryPlus.Shared;

public class ProductCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty; //video games space replace it with video_game and access it

    public string ImageUrl { get; set; } = string.Empty;



}