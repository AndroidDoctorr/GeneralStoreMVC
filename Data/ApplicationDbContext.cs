using Microsoft.EntityFrameworkCore;

namespace GS_MVC.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products {get;set;}
        public DbSet<Customer> Customers {get;set;}
        public DbSet<Transaction> Transactions {get;set;}
    }
}