﻿using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;
public sealed class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-GQ3I60J\\MSSQLSERVER01;Initial Catalog=TipsForNetDevelopersDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasIndex(e => e.Name)
            .IsUnique();
    }
}
