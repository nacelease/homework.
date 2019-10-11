using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sweet.Data;

namespace sweet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<sweet.Data.Store> Store { get; set; }
        public DbSet<sweet.Data.orders> orders { get; set; }
        public DbSet<sweet.Data.candy> candy { get; set; }
    }
}
