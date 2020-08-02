                                                                                          
using Core.Entities;                                                          // remove using API.Entities; // add Core.Entities
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data                                       // change API to Infrastructure
{
    public class StoreContext : DbContext                       // this class derives from StoreContext entity framework DbContext is our derivative
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products {get; set;}

    }
}