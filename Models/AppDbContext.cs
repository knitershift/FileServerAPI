﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileServerAPI.Models
{
    public class AppDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions options): base(options)
        {
        }
    }
}
