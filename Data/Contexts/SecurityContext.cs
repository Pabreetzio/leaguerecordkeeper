using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models.Security;
namespace Data.Contexts
{
    public class SecurityContext: DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public SecurityContext(DbContextOptions<SecurityContext> contextOptions): base(contextOptions){ }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(b => b.Name)
                .IsRequired();
        }
    }
}
