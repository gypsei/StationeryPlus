using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StationeryPlus.Shared { 

public class Product
{
    public int Id { get; set; }

    public string? Title { get; set; } = String.Empty;

    public string? Description { get; set; } = String.Empty;

    public string? ImageURL { get; set; } = string.Empty;


    public ProductCategory? Category { get; set; }
    public int CategoryId { get; set; }

    public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
    }
}