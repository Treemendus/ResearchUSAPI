using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ResearchUSAPI.Models;

namespace ResearchUSAPI
{
    public class ResearchUSContext : DbContext
    {
        public ResearchUSContext(DbContextOptions<ResearchUSContext> options) 
            : base (options) 
        { }

        public DbSet<User> Users {get;set;}
        public DbSet<Project> Projects {get;set;}

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseNpgsql("Filename=./ResearchUS.db");
        // }
        
        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     builder.Entity<User>().HasKey(m => m.user_id);

        //     // builder.Entity<User>().Property<DateTime>("UpdatedTimestamp");

        //     base.OnModelCreating(builder);
        // }

   
    }
}