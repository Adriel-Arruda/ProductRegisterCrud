using Microsoft.EntityFrameworkCore;
using ProductRegisterCrud.Models;

namespace ProductRegisterCrud.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
    
        public DbSet<Product> Product { get; set; }
    
    }
}
