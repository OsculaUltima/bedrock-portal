﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MinecraftWrapper.Data.Entities;

namespace MinecraftWrapper.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext ( DbContextOptions<ApplicationDbContext> options )
            : base ( options )
        {
        }

        public DbSet<ApplicationLog> ApplicationLog { get; set; }
        public DbSet<NewsItem> NewsItem { get; set; }
        public DbSet<UserPreference> UserPreference { get; set; }
        public DbSet<UtilityRequest> UtilityRequest { get; set; }
        public DbSet<UserCurrency> UserCurrency { get; set; }
        public DbSet<StoreItem> StoreItem { get; set; }
    }
}
