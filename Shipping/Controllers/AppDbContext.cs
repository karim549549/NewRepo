using Microsoft.EntityFrameworkCore;
using Shipping.Model;
namespace Shipping.Controllers
{
    public class AppDbContext(DbContextOptions<AppDbContext> Options) : DbContext(Options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        DbSet<order> orders {  get; set; } 
        DbSet<Customer> Customers   { get; set; }
        DbSet <CustomerOrder> CustomerOrders { get; set; }
    }
}
