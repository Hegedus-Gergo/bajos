﻿using Microsoft.EntityFrameworkCore;
using PetGameAPI.Models;

namespace PetGameAPI.Data
{
    public class PetGameDbContext : DbContext
    {
        public PetGameDbContext(DbContextOptions<PetGameDbContext> options) : base(options) { 
        
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Tool> Tools { get; set; }
    }
}
