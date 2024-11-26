using DataAccess.Context;
using DataAccess.Models;

namespace StartConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new();

        IList<Product> products = new List<Product>();
        IList<Category> categories = new List<Category>();

        for (int i = 0; i < 10; i++)
        {
            Category category = new()
            {
                Name = i + ". Category"
            };
            categories.Add(category);
        }

        for (int i = 0; i < 1000; i++)
        {
            Random random = new Random();

            Product product = new()
            {
                Name = i + ". Product ",
                CategoryId = random.Next(1, 9)
            };
            products.Add(product);
        }

        context.Categories.AddRange(categories);
        context.Products.AddRange(products);
        context.SaveChanges();

        Console.WriteLine("Hello, World!");
    }
}
