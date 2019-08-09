using Microsoft.EntityFrameworkCore;
using Tema3_ProductApp.Models;

namespace Tema3_ProductApp.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }


    }
}
