﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksAPI.Models;

namespace BooksAPI.Data
{
    public class BooksAPIContext : DbContext
    {
        public BooksAPIContext (DbContextOptions<BooksAPIContext> options)
            : base(options)
        {
        }

        public DbSet<BooksAPI.Models.Book> Book { get; set; } = default!;
    }
}
