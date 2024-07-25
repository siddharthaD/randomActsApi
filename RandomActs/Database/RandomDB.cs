using System;
using Microsoft.EntityFrameworkCore;

namespace RandomActs.Database;

public class RandomDB : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "RandomDb");
        
        Console.WriteLine("Hello From inside");
    }

    public DbSet<RandomActivity> Activities { get; set; }
}