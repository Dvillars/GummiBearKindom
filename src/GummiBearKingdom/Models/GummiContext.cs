using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace GummiBearKingdom.Models
{
    public class GummiContext : DbContext
    {
        public virtual DbSet<Gummi> Gummies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Gummi;integrated security=True");
        }
    }
}
