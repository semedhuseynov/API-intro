﻿using System;
using APIintro.Models;
using Microsoft.EntityFrameworkCore;

namespace APIintro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

    }
}
 
