using DataAccess.Context;
using DataAccess.Models;

namespace SingleOrUnique;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new();

        //Product product = context.Products.Where(p => p.Name == "0. Product").SingleOrDefault()!;

        Product product = new()
        {
            Name = "0. Product"
        };

        context.Products.Add(product);
        context.SaveChanges();

        //Console.WriteLine(product.Name);


    }
}
