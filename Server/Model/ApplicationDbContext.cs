using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;



namespace Server.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Client> Client { get; set; }
        public DbSet<Client_Order> Client_Order { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Client>()
                .HasKey(s => s.ID_Client);
            modelBuilder.Entity<Client_Order>()
               .HasKey(s => s.ID_Order);
        }


    }
}