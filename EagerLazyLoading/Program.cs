using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace EagerLazyLoading;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new();

        //Lazy Loading - Tembel yükleme
        IList<Product> products = context.Products.ToList();

        //Eager Loading
        IList<Product> products2 = context.Products.Include(p => p.Category).ToList();

        Console.WriteLine("Hello, World!");
    }
}
