namespace DataAccess.Models;

public sealed class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
