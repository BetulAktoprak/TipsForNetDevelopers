using DataAccess.Context;
using DataAccess.Models;

namespace IQueryable;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new();

        IQueryable<Product> products = context.Products.AsQueryable();

        IList<Product> productList = products.Where(p => p.Id > 500 && p.Id < 600).ToList();

        Console.WriteLine("Hello, World!");
    }
}
