using DataAccess.Context;

namespace AnyAllMethods;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new();

        bool result = context.Products.Any();

        bool result2 = context.Products.Any(p => p.Name == "1. Product");

        bool result3 = context.Products.All(p => p.Name.Contains("P"));

        bool result4 = context.Products.All(p => p.Name == "1. Product");

        Console.WriteLine("Hello, World!");
    }
}
