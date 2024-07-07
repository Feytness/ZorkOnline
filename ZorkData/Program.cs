// See https://aka.ms/new-console-template for more information
using ZorkData.Context;
using ZorkData.Models;

Console.WriteLine("Hello, World!");

using (var ctx = new ZorkDataContext())
{
    ctx.Worlds?.Add(new World()
    {
        Name = "World1",
    });

    ctx.SaveChanges();
}