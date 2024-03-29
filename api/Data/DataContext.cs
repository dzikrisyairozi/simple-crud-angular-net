﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
    }
}
