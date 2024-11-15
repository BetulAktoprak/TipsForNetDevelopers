﻿using DataAccess.Context;
using DataAccess.Models;

namespace StartConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new();

        IList<Product> products = new List<Product>();

        for (int i = 0; i < 1000; i++)
        {
            Product product = new()
            {
                Name = i + ". Product "
            };
            products.Add(product);
        }

        context.Products.AddRange(products);
        context.SaveChanges();

        Console.WriteLine("Hello, World!");
    }
}
