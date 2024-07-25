using System;
using System.IO;
using RandomActs.Database;
using Microsoft.AspNetCore.Hosting;

namespace RandomActs.SeedData;

public class DbInitialiser
{
    private RandomDB db;
    private string rootPath;
    public DbInitialiser(IWebHostEnvironment  environment, RandomDB db)
    {
        this.rootPath = environment.ContentRootPath;
        this.db = db;
    }

    public void Run()
    {
        Console.WriteLine("Hello"+Path.Combine(rootPath, "SeedData"));
    }
}