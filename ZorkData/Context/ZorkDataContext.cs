using System.Data.Entity;
using ZorkData.Models;

namespace ZorkData.Context
{
    public class ZorkDataContext : DbContext
    {
        public ZorkDataContext() : base("ZorkDB")
        {
            
        }

        public DbSet<World>? Worlds { get; set; }
        public DbSet<State>? States { get; set; }
        public DbSet<Locations>? Locations { get; set; }
        public DbSet<Levels>? Levels { get; set; }
        public DbSet<Items>? Items { get; set; }
        public DbSet<Exits>? Exits { get; set; }
        public DbSet<Directions>? Directions { get; set; }
        public DbSet<Characters>? Characters { get; set; }
        public DbSet<Dialogue>? Dialogues { get; set; }
        public DbSet<Missions>? Missions { get; set; }
        public DbSet<Objectives>? Objectives { get; set; }
        public DbSet<Rarity>? Rarity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here..

        }
    }
}
