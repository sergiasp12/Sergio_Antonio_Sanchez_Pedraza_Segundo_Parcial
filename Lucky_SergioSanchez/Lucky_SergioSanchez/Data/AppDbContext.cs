﻿using Lucky_SergioSanchez.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky_SergioSanchez.Data
{
    public class AppDbContext:DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options)
        {

        }
        public DbSet<Lucky> Lucky { get; set; }
    }
}
